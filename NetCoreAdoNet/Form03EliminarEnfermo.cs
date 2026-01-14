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
    public partial class Form03EliminarEnfermo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        string connectionString;
        SqlDataReader reader;

        public Form03EliminarEnfermo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.cargarEnfermos();
        }

        private void cargarEnfermos()
        {
            string sql = "SELECT * FROM ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            //LOS PARAMETROS DEBEN SEL DEL MISMO TIPO DE DATO QUE LA COLUMNA
            int inscripcion = int.Parse(this.txtInscripcion.Text);
            string sql = "DELETE FROM ENFERMO WHERE INSCRIPCION =@inscripcion";
            //DEBEMOS CONFIGURAR UNO O  VARIOS PARAMETROS
            SqlParameter parIns = new SqlParameter("@inscripcion", inscripcion);
            this.com.Parameters.Add(parIns);

            /*
             * NOMBRE DEL PARAMETRO EN LA CONSULTA, NO PUEDE ESTAR REPETIDO
             * parIns.ParameterName = "@inscripcion";
             * parIns.DbType = DbType.Int32;
             * //POR DEFECTO LA DIRECCION ES INPUT
             * parIns.Direction = ParameterDirection.Input;
             * //EL VALOR DEL PARAMETRO PARA SUSTITUIR LA CONSULTA
             * parIns.Value = inscripcion;
             * //AGREGAMOS EL PARAMETRO A LA COLECCION
             * this.com.Parameters.Add(parIns);
            */


            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            //LIBERAMOS LOS PARAMETROS DE LA COLLECION
            this.com.Parameters.Clear();
            this.cargarEnfermos();
            this.txtInscripcion.Text = "";
            MessageBox.Show("Enfermo eliminado");
        }
    }
}
