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
    public partial class Form10UpdateEmpleados : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.cargarOficios();
        }

        public async void cargarOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string oficio in oficios)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }

        private async void btnIncremento_Click(object sender, EventArgs e)
        {
            string oficio = this.lstOficios.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);
            int registros = await this.repo.UpdateSalarioEmpleadosAsync(this.lstOficios.SelectedItem.ToString(), incremento);
            MessageBox.Show("Registros cambiados: " + registros);
            DatosEmpleado data = await this.repo.GetDatosEmpleadoAsync(oficio);
            this.lblMaximoSalarial.Text = data.MaximoSalarial.ToString();
            this.lblMediaSalarial.Text = data.MediaSalarial.ToString();
            this.lblSumaSalarial.Text = data.SumaSalarial.ToString();
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstOficios.SelectedIndex;
            if (index != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                List<string> empleados = await this.repo.GetEmpleadosByOficioAsync(this.lstOficios.SelectedItem.ToString());
                this.lstEmpleados.Items.Clear();
                foreach (string empleado in empleados)
                {
                    this.lstEmpleados.Items.Add(empleado);
                }
                DatosEmpleado data = await this.repo.GetDatosEmpleadoAsync(oficio);
                this.lblMaximoSalarial.Text = data.MaximoSalarial.ToString();
                this.lblMediaSalarial.Text = data.MediaSalarial.ToString();
                this.lblSumaSalarial.Text = data.SumaSalarial.ToString();
            }
        }
    }
}
