using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form05UpdateSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        string connectionString;
        SqlDataReader reader;

        public Form05UpdateSalas()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cargarSalas();
        }

        private void cargarSalas()
        {
            string sql = "SELECT DISTINCT NOMBRE FROM SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstSalas.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE SALA SET NOMBRE = @newname WHERE NOMBRE = @oldname";
            string newName = this.txtNombre.Text;
            string oldName = this.lstSalas.SelectedItem.ToString();
            SqlParameter pamNew = new SqlParameter("@newname", newName);
            SqlParameter pamOld = new SqlParameter("@oldname", oldName);
            this.com.Parameters.Add(pamNew);
            this.com.Parameters.Add(pamOld);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.cargarSalas();
            this.txtNombre.Text = "";
            MessageBox.Show("Sala actualizada");
        }
    }
}
