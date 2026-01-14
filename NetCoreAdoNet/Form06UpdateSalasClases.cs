using NetCoreAdoNet.Respositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form06UpdateSalasClases : Form
    {
        RepositorySalas repo;

        public Form06UpdateSalasClases()
        {
            InitializeComponent();
            this.repo = new RepositorySalas();
            this.cargarSalas();
        }

        private async void cargarSalas()
        {
            List<string> nombreSalas = await this.repo.GetNombreSalasAsync();
            this.lstSalas.Items.Clear();
            foreach(string nombre in nombreSalas)
            {
                this.lstSalas.Items.Add(nombre);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldName = this.lstSalas.SelectedItem.ToString();
            string newName = this.txtNombre.Text;
            int registros = await this.repo.UpdateSalaAsync(newName, oldName);
            MessageBox.Show("Sala modificada");
            this.txtNombre.Text = "";
            this.cargarSalas();
        }
    }
}
