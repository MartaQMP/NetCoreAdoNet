using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace NetCoreAdoNet.Respositories
{
    public class RepositoryDepartamentosEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectiomString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectiomString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetNombreDepartamentosAsync()
        {
            string sql = "SELECT * FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            List<string> departamentos = new List<string>();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string dept = this.reader["DNOMBRE"].ToString();
                departamentos.Add(dept);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<List<string>> GetNombreEmpleadossAsync(string dept)
        {
            string sql = "SELECT EMP.APELLIDO, EMP_NO FROM EMP INNER JOIN DEPT ON EMP.DEPT_NO = DEPT.DEPT_NO WHERE DNOMBRE = @dept";
            SqlParameter pamDept = new SqlParameter("@dept", dept);
            this.com.Parameters.Add(pamDept);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            List<string> empleados = new List<string>();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string id = this.reader["EMP_NO"].ToString();
                string emp = this.reader["APELLIDO"].ToString();
                empleados.Add(id +" "+emp);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task<int> EliminarEmpleadoAsync(int id)
        {
            string sql = "DELETE FROM EMP WHERE EMP_NO = @id";
            SqlParameter pamEmp = new SqlParameter("@id", id);
            this.com.Parameters.Add(pamEmp);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros; 
        }

        public async Task<int> BuscarEmpleadoApellidoAsync(string nombre)
        {
            string sql = "SELECT EMP_NO FROM EMP WHERE APELLIDO = @ape";
            SqlParameter pamEmp = new SqlParameter("@ape", nombre);
            this.com.Parameters.Add(pamEmp);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int idEmp = 0;
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                idEmp = int.Parse(this.reader["EMP_NO"].ToString());     
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return idEmp;
        }


        public async Task<string> BuscarEmpleadoAsync(string nombre, int index)
        {
            string sql = "SELECT * FROM EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            string apellido = "";
            int contador = 0;
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                if(contador == index)
                {
                    apellido = this.reader["APELLIDO"].ToString();
                }
                contador++;
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return apellido;
        }

        
    }
}
