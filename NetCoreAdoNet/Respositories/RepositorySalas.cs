using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace NetCoreAdoNet.Respositories
{
    public class RepositorySalas
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositorySalas()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetNombreSalasAsync()
        {
            string sql = "SELECT DISTINCT NOMBRE FROM SALA";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> nombresSalas = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                nombresSalas.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return nombresSalas;
        }

        public async Task<int> UpdateSalaAsync(string newName, string oldName)
        {
            string sql = "UPDATE SALA SET NOMBRE = @newName WHERE NOMBRE = @oldName";
            SqlParameter pamNew = new SqlParameter("@newname", newName);
            SqlParameter pamOld = new SqlParameter("@oldname", oldName);
            this.com.Parameters.Add(pamNew);
            this.com.Parameters.Add(pamOld);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

    }

}
