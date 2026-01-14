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
            foreach(Departamento dep in depts)
            {
                this.lstDepartamentos.Items.Add(dep.IdDept + " - " + dep.Nombre + " - " + dep.Localidad);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
