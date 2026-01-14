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
    public partial class Form04EliminarPlantilla : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.cargarPlantilla();
        }

        private void cargarPlantilla()
        {
            string sql = "SELECT * FROM PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string id = this.reader["EMPLEADO_NO"].ToString();
                this.lstPlantilla.Items.Add(id + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM PLANTILLA WHERE EMPLEADO_NO = "+this.txtInscripcion.Text;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.reader.Close();
            this.cn.Close();
            MessageBox.Show("Empleado de la plantilla eliminado");
            this.cargarPlantilla();
            this.txtInscripcion.Text = "";
        }
    }
}
