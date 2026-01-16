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
    public partial class Form08CrudDepartamentos : Form
    {
        RepositoryDepartamento repo;
        public Form08CrudDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamento();
            this.cargarDepartamento();
        }

        private async Task cargarDepartamento()
        {
            List<Departamento> depts = await this.repo.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (Departamento dep in depts)
            {
                this.lstDepartamentos.Items.Add(dep.IdDept + " - " + dep.Nombre + " - " + dep.Localidad);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteDepartamento(id);
            await this.cargarDepartamento();
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.CreateDepartamento(id, nombre, localidad);
            await this.cargarDepartamento();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.UpdateDepartamento(id, nombre, localidad);
            await this.cargarDepartamento();
        }
    }
}
