using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Respositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "SELECT DISTINCT  OFICIO  FROM  EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficiosList = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficiosList.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficiosList;
        }

        public async Task<List<string>> GetEmpleadosByOficioAsync(string oficio)
        {
            string sql = "SELECT  APELLIDO  FROM  EMP  WHERE  OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string ape = this.reader["APELLIDO"].ToString();
                apellidos.Add(ape);
            }
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();
            return apellidos;
        }

        public async Task<int> UpdateSalarioEmpleadosAsync(string oficio, int incremento)
        {
            string sql = "UPDATE  EMP  SET  SALARIO = SALARIO  +  @incremento  WHERE  OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<int> SumaSalarialAsync(string oficio)
        {
            string sql = "SELECT SUM(SALARIO), MAX(SALARIO), AVG(SALARIO) FROM EMP WHERE OFICIO = @oficio";
            SqlParameter pamOfi = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOfi);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int suma = 0, maximo = 0, media = 0;
            this.reader = await this.com.ExecuteReaderAsync();
            return suma;
        }
    }


}
