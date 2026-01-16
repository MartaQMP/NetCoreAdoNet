using NetCoreAdoNet.Models;
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
    public partial class Form09CrudHospitales : Form
    {
        RepositoryHospital repo;

        public Form09CrudHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospital();
            this.cargarHospitales();
        }

        public async void cargarHospitales()
        {
            List<Hospital> hospitales = await this.repo.CargarHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach(Hospital hos in hospitales)
            {
                this.lstHospitales.Items.Add(hos.IdHos + " - " + hos.Nombre);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            this.repo.CreateHospitalAsync(id, nombre, direccion, telefono, camas);
            this.cargarHospitales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            this.repo.UpdateHospitalAsync(id, nombre, direccion, telefono, camas);
            this.cargarHospitales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            this.repo.DeleteHospitalAsync(id);
            this.cargarHospitales();
        }
    }
}
