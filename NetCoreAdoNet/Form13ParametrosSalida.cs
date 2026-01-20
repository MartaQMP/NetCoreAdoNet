using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using NetCoreAdoNet.Respositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametersOut repo;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametersOut();
            this.CargarDepartamentos();
        }

        private async Task CargarDepartamentos()
        {
            this.cmbDepartamentos.Items.Clear();
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            foreach(string nombreDept in departamentos){
                this.cmbDepartamentos.Items.Add(nombreDept);
            }
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            this.lstEmpleados.Items.Clear();
            string nombreDept = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadosParametersOut empleados = await this.repo.GetEmpleadosModelAsync(nombreDept);
            foreach(string apellido in empleados.Apellidos)
            {
                this.lstEmpleados.Items.Add(apellido);
            }
            this.txtSuma.Text = empleados.SumaSalarial.ToString();
            this.txtMedia.Text = empleados.MediaSalarial.ToString();
            this.txtPersonas.Text = empleados.Personas.ToString();
        }
    }
}
