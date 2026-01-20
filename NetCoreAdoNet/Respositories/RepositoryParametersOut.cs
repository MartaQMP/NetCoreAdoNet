using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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
	    SELECT @suma = isnull(SUM(SALARIO), 0), @media = isnull(AVG(SALARIO), 0), @personas = COUNT(EMP_NO) FROM EMP WHERE DEPT_NO = @iddept
    GO

 */
#endregion

namespace NetCoreAdoNet.Respositories
{
    public class RepositoryParametersOut
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryParametersOut()
        {
            IConfigurationRoot root = HelpersConfiguration.GetConfiguration();
            string connectionString = root.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            List<string> departamentos = new List<string>();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<EmpleadosParametersOut> GetEmpleadosModelAsync(string nombreDept)
        {
            EmpleadosParametersOut empleados = new EmpleadosParametersOut();

            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            /* TENEMOS UN PARAMETRO DE ENTRADA SE SIGUE HACIENDO IGUAL AddWithValue */
            this.com.Parameters.AddWithValue("@nombre", nombreDept);
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
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Apellidos.Add(apellido);
            }
            await this.reader.CloseAsync();
            empleados.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            empleados.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            empleados.Personas = int.Parse(pamPers.Value.ToString());
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }
    }
}
