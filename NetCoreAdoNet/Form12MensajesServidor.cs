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

--------------------------------

    CREATE PROCEDURE SP_INSERT_DEPARTAMENTO(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
    AS
        INSERT INTO DEPT VALUES (@numero, @nombre, @localidad)
    GO

--------------------------------
--PRINT PARA SABER EL ERROR--

    ALTER PROCEDURE SP_INSERT_DEPARTAMENTO(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
    AS
	    IF(UPPER(@localidad) = 'TERUEL')
	    BEGIN
		    PRINT 'TERUEL NO EXISTE'
	    END
	    ELSE 
	    BEGIN
		    INSERT INTO DEPT VALUES (@numero, @nombre, @localidad)
	    END
    GO

--------------------------------
--CON PARAMETRO DE SALIDA--

    ALTER PROCEDURE SP_INSERT_DEPARTAMENTO(@nombre nvarchar(50), @localidad nvarchar(50), @maxid int out)
    AS
	    DECLARE @id int
	    SELECT @id = MAX(DEPT_NO) + 1 FROM DEPT
	    INSERT INTO DEPT VALUES (@id, @nombre, @localidad)
	    --DONDE DESEEMOS, ASIGNAMOS VALOR AL PARAMETRO DE SALIDA
	    set @maxid = @id
    GO
*/
#endregion

namespace NetCoreAdoNet
{

    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form12MensajesServidor()
        {
            InitializeComponent();
            //string connectionString = @"Data Source=sqlpaco3430.database.windows.net;Initial Catalog=AZURETAJAMAR;Persist Security Info=True;User ID=adminsql;Password=Admin123;Trust Server Certificate=True";
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarDepartaentosAsync();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblServidor.Text = e.Message;
        }

        private async void CargarDepartaentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.lstDepartamentos.Items.Clear();
            this.reader = await this.com.ExecuteReaderAsync();
            while(await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                string id = this.reader["DEPT_NO"].ToString();
                string localidad = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(id + " - " + nombre + " - " + localidad);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lblServidor.Text = "";
            int idDept = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            string sql = "SP_INSERT_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@numero", idDept);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            //int registros = await this.com.ExecuteNonQueryAsync();
            int registros = this.com.ExecuteNonQuery();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            MessageBox.Show("Registros insertados: " + registros);
            this.CargarDepartaentosAsync();
        }
    }
}
