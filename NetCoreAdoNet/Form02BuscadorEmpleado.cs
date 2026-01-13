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
    public partial class Form02BuscadorEmpleado : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;

        public Form02BuscadorEmpleado()
        {
            InitializeComponent(); 
            this.connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //VAMOS A CONCATENAR, POR LO QUE NUESTRO SALARIO ES UN STRING
            string salario = this.txtSalario.Text;
            //CONSULTA SQL
            string sql = "SELECT * FROM EMP WHERE SALARIO >= " + salario;
            //CONNECTION
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //LA CONSULTA
            this.com.CommandText = sql;
            //ENTRAR Y SALIR
            this.cn.Open();
            //EJECUTAMOS LAS CONSULTAS
            this.reader = this.com.ExecuteReader();
            //DIBUJAMOS LOS DATOS
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sala = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " " + sala);
            }
            //SALIMOS
            this.reader.Close();
            this.cn.Close();
        
            
        }
    }
}
