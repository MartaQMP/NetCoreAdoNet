using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Respositories
{
    public class RepositoryHospital
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryHospital()
        {
            string connectioString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectioString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task <List<Hospital>> CargarHospitalesAsync()
        {
            string sql = "SELECT * FROM HOSPITAL";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            List<Hospital> hospitales = new List<Hospital>();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                Hospital hos = new Hospital();
                hos.IdHos = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hos.Nombre = this.reader["NOMBRE"].ToString();
                hos.Direccion = this.reader["DIRECCION"].ToString();
                hos.Telefono = this.reader["TELEFONO"].ToString();
                hos.NumCamas = int.Parse(this.reader["NUM_CAMA"].ToString());
                hospitales.Add(hos);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }


        public async Task CreateHospitalAsync(int id, string nombre, string direccion, string telefono, int numCamas)
        {
            string sql = "INSERT INTO HOSPITAL VALUES(@id, @nombre, @direccion, @telefono, @numCamas)";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNom = new SqlParameter("@nombre", nombre);
            SqlParameter pamDir = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelf = new SqlParameter("@telefono", telefono);
            SqlParameter pamCam = new SqlParameter("@numCamas", numCamas);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNom);
            this.com.Parameters.Add(pamDir);
            this.com.Parameters.Add(pamTelf);
            this.com.Parameters.Add(pamCam);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateHospitalAsync(int id, string nombre, string direccion, string telefono, int numCamas)

        {
            string sql = "UPDATE HOSPITAL SET NOMBRE = @nombre, DIRECCION = @direccion, TELEFONO = @telefono, NUM_CAMA=@numCamas WHERE HOSPITAL_COD = @id";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@numCamas", numCamas);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteHospitalAsync(int id)
        {
            string sql = "DELETE FROM HOSPITAL WHERE HOSPITAL_COD = @id";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

    }
}
