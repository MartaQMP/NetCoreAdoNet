using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region PROCEDIMIENTOS ALMACENADOS
/*
    CREATE PROCEDURE SP_ALL_DEPARTAMENTOS
    AS
	    SELECT * FROM DEPT
    GO

-----------------------------

    CREATE PROCEDURE SP_EMPLEADOS_DEPARTAMENTOS_OUT (@nombre nvarchar(50), @suma INT OUT, @media INT OUT, @personas INT OUT)
    AS
	    DECLARE @iddept INT
	    SELECT @iddept = DEPT_NO FROM DEPT WHERE DNOMBRE = @nombre
	    --LA CONSULTA DEL PROCEDIMIENTO--
	    SELECT * FROM EMP WHERE DEPT_NO = @iddept
	    --RELLENAMOS LAS VARIABLES DE SALIDA--
	    SELECT @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO) FROM EMP WHERE DEPT_NO = @iddept
    GO
 */
#endregion

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarDepartamentos();
        }

        private async Task CargarDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.cmbDepartamentos.Items.Clear();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.cmbDepartamentos.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            /* TENEMOS UN PARAMETRO DE ENTRADA SE SIGUE HACIENDO IGUAL AddWithValue */
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            this.com.Parameters.AddWithValue("@nombre", nombre);
            /* LOS PARAMETROS DE SALIDA DEBEMOS CREARLOS DE FORMA EXPLICITA
             * EN ESTE EJEMPLO NO HEMOS PUESTO VALORES POR DEFECTP A LOS PARAMETROS
             * POR LO QUE SON OBLIGATORIOS */
            SqlParameter pamSuma = new SqlParameter();
            SqlParameter pamMedia = new SqlParameter();
            SqlParameter pamPers = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamMedia.ParameterName = "@media";
            pamPers.ParameterName = "@personas";
            pamSuma.Value = 0;
            pamMedia.Value = 0;
            pamPers.Value = 0;
            pamSuma.Direction = ParameterDirection.Output;
            pamMedia.Direction = ParameterDirection.Output;
            pamPers.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            this.com.Parameters.Add(pamMedia);
            this.com.Parameters.Add(pamPers);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstEmpleados.Items.Clear();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            await this.reader.CloseAsync();
            this.txtSuma.Text = pamSuma.Value.ToString();
            this.txtMedia.Text = pamMedia.Value.ToString();
            this.txtPersonas.Text = pamPers.Value.ToString();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
