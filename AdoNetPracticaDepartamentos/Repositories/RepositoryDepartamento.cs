using AdoNetPracticaDepartamentos.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

#region STORED PROCEDURES
/*
    CREATE PROCEDURE SP_INSERTAR_DEPARTAMENTO(@id int, @nombre nvarchar(50), @localidad nvarchar(50))
    AS
	    INSERT INTO DEPT VALUES (@id, @nombre, @localidad)
    GO

-------------------------------------------------

    CREATE PROCEDURE SP_UPDATE_EMPLEADO(@seleccionado nvarchar(50), @apellido nvarchar(50), @oficio nvarchar(50), @salario int)
    AS 
	    DECLARE @emp_no int
	    SELECT @emp_no = EMP_NO FROM EMP WHERE APELLIDO = @seleccionado
	    UPDATE EMP SET APELLIDO=@apellido, OFICIO=@oficio, SALARIO=@salario WHERE EMP_NO=@emp_no
    GO

-------------------------------------------------

    CREATE PROCEDURE SP_EMPLEADOS(@nombreDept nvarchar(50))
    AS
	    declare @id int
	    select @id = DEPT_NO FROM DEPT WHERE DNOMBRE=@nombreDept
	    select * from EMP where DEPT_NO=@id
    GO

-------------------------------------------------

    CREATE PROCEDURE SP_DEPARTAMENTOS(@id int)
    AS
	    SELECT * FROM DEPT WHERE DEPT_NO = @id
    GO
*/
#endregion


namespace AdoNetPracticaDepartamentos.Repositories
{
    public class RepositoryDepartamento
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryDepartamento()
        {
            IConfigurationRoot root = HelpersConfiguration.GetConfiguration();
            string connectionString = root.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            string sql = "SELECT * FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            List<Departamento> departamentos = new List<Departamento>();
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while(await this.reader.ReadAsync())
            {
                Departamento dept = new Departamento();
                dept.IdDept = int.Parse(this.reader["DEPT_NO"].ToString());
                dept.Nombre = this.reader["DNOMBRE"].ToString();
                dept.Localidad = this.reader["LOC"].ToString();
                departamentos.Add(dept);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<Departamento> GetDepartamentoAsync(string nombre)
        {
            string sql = "SP_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            Departamento departamento = new Departamento();
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                departamento.IdDept = int.Parse(this.reader["DEPT_NO"].ToString());
                departamento.Nombre = this.reader["DNOMBRE"].ToString();
                departamento.Localidad = this.reader["LOC"].ToString();
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return departamento;
        }


        public async Task<List<Empleado>> GetEmpleadosAsync(string nombreDept)
        {
            string sql = "SP_EMPLEADOS";
            this.com.Parameters.AddWithValue("@nombreDept", nombreDept);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            List<Empleado> empleados = new List<Empleado>();
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                Empleado emp = new Empleado();
                emp.Emp_no = int.Parse(this.reader["EMP_NO"].ToString());
                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Oficio = this.reader["OFICIO"].ToString();
                emp.Salario = int.Parse(this.reader["SALARIO"].ToString());
                empleados.Add(emp);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task<Empleado> GetEmpleadoAsync(string apellido)
        {
            string sql = "SELECT * FROM EMP WHERE APELLIDO = @apellido";
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            Empleado emp = new Empleado();
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            await this.reader.ReadAsync();
            emp.Emp_no = int.Parse(this.reader["EMP_NO"].ToString());
            emp.Apellido = this.reader["APELLIDO"].ToString();
            emp.Oficio = this.reader["OFICIO"].ToString();
            emp.Salario = int.Parse(this.reader["SALARIO"].ToString());
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return emp;
        }

        public async Task<int> InsertDepartamentoAsync(int id, string nombre, string localidad)
        {
            string sql = "SP_INSERTAR_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<int> UpdateEmpleadoAsync(string seleccionado, string apellido, string oficio, int salario)
        {
            string sql = "SP_UPDATE_EMPLEADO";
            this.com.Parameters.AddWithValue("@seleccionado", seleccionado);
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@salario", salario);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }
    }
}
