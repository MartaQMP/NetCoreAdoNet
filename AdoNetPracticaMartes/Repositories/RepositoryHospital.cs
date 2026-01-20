using AdoNetPracticaMartes.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

#region PROCEDIMIENTOS ALMACENADOS
/*
	CREATE PROCEDURE SP_ALL_HOSPITALES
	AS
		SELECT * FROM HOSPITAL
	GO

------------------------------------------

	CREATE PROCEDURE SP_DOCTORES_PLANTILLA_HOSPITAL(@nombre nvarchar(50))
	AS
		SELECT DOCTOR.SALARIO, DOCTOR.APELLIDO,DOCTOR.ESPECIALIDAD AS CARGO
		FROM DOCTOR
		INNER JOIN HOSPITAL ON HOSPITAL.HOSPITAL_COD = DOCTOR.HOSPITAL_COD
		WHERE HOSPITAL.NOMBRE = @nombre
		UNION
		SELECT PLANTILLA.SALARIO, PLANTILLA.APELLIDO, PLANTILLA.FUNCION AS CARGO
		FROM PLANTILLA
		INNER JOIN HOSPITAL ON HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD
		WHERE HOSPITAL.NOMBRE = @nombre;
	GO

------------------------------------------

	CREATE PROCEDURE SP_SUMA_MEDIA_PERSONAS_HOSPITAL(@nombre nvarchar(50))
	AS 
		SELECT isnull(SUM(SALARIO),0) AS SUMASALARIAL, isnull(AVG(SALARIO),0) AS MEDIASALARIAL, COUNT(*) AS PERSONAS FROM
			(SELECT DOCTOR.SALARIO, DOCTOR.APELLIDO,DOCTOR.ESPECIALIDAD AS CARGO
			FROM DOCTOR
			INNER JOIN HOSPITAL ON HOSPITAL.HOSPITAL_COD = DOCTOR.HOSPITAL_COD
			WHERE HOSPITAL.NOMBRE = @nombre
			UNION 
			SELECT PLANTILLA.SALARIO, PLANTILLA.APELLIDO, PLANTILLA.FUNCION AS CARGO
			FROM PLANTILLA
			INNER JOIN HOSPITAL ON HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD
			WHERE HOSPITAL.NOMBRE = @nombre)
		QUERY
	GO
 */
#endregion

namespace AdoNetPracticaMartes.Repositories
{

    public class RepositoryHospital
    {
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;

		public RepositoryHospital()
		{
			IConfigurationRoot root = HelpersConfiguration.GetConfiguration();
			string connectionString = root.GetConnectionString("SqlLocalTajamar");
			this.cn = new SqlConnection(connectionString);
			this.com = new SqlCommand();
			this.com.Connection = this.cn;
		}


		public async Task<List<Hospital>> GetHospitalesAsync()
		{
			string sql = "SP_ALL_HOSPITALES";
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			List<Hospital> hospitales = new List<Hospital>();
			await this.cn.OpenAsync();
			this.reader = await this.com.ExecuteReaderAsync();
			while(await this.reader.ReadAsync())
			{
				Hospital hospital = new Hospital();
				hospital.HospitalCod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
				hospital.Camas = int.Parse(this.reader["NUM_CAMA"].ToString());
				hospital.Nombre = this.reader["NOMBRE"].ToString();
				hospital.Direccion = this.reader["DIRECCION"].ToString();
				hospital.Telefono = this.reader["TELEFONO"].ToString();
				hospitales.Add(hospital);
			}
			await this.reader.CloseAsync();
			await this.cn.CloseAsync();
			return hospitales;
		}

		public async Task<List<Empleado>> GetEmpleadosAsync(string nombreHosp)
		{
			List<Empleado> empleados = new List<Empleado>();
			string sql = "SP_DOCTORES_PLANTILLA_HOSPITAL";
			this.com.Parameters.AddWithValue("@nombre", nombreHosp);
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			await this.cn.OpenAsync();
			this.reader = await this.com.ExecuteReaderAsync();
			while(await this.reader.ReadAsync())
			{
				Empleado empleado = new Empleado();
				empleado.Apellidos = this.reader["APELLIDO"].ToString();
				empleado.Cargo = this.reader["CARGO"].ToString();
				empleado.Salario = int.Parse(this.reader["SALARIO"].ToString());
				empleados.Add(empleado);
			}
			await this.reader.CloseAsync();
			await this.cn.CloseAsync();
			this.com.Parameters.Clear();
			return empleados;
		}

		public async Task<Salario> GetSumaMediaPersonas(string nombre)
		{
			Salario salario = new Salario();
			string sql = "SP_SUMA_MEDIA_PERSONAS_HOSPITAL";
			this.com.Parameters.AddWithValue("@nombre", nombre);
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = sql;
			await this.cn.OpenAsync();
			this.reader = await this.com.ExecuteReaderAsync();
			await this.reader.ReadAsync();
			salario.SumaSalarial = int.Parse(this.reader["SUMASALARIAL"].ToString());
			salario.MediaSalarial = int.Parse(this.reader["MEDIASALARIAL"].ToString());
			salario.Personas = int.Parse(this.reader["PERSONAS"].ToString());
			await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
			return salario;
        }
    }
}
