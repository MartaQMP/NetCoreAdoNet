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
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;
        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.cargarDepartamentos();
        }

        private async void cargarDepartamentos()
        {
            List<string> departamentos = await this.repo.GetNombreDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string dept in departamentos)
            {
                this.lstDepartamentos.Items.Add(dept);
            }
        }



        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string empleado = this.lstEmpleados.SelectedItem.ToString();
            int index = this.lstEmpleados.SelectedIndex;
            string apellido = await this.repo.BuscarEmpleadoAsync(empleado, index);
            int id = await this.repo.BuscarEmpleadoApellidoAsync(apellido);
            int registros = await this.repo.EliminarEmpleadoAsync(id);
            this.cargarEmpleados(this.lstDepartamentos.SelectedItem.ToString());
            MessageBox.Show("Empleado eliminado");
        }

        private async void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarEmpleados(this.lstDepartamentos.SelectedItem.ToString());
        }

        private async Task cargarEmpleados(string nombre)
        {
            List<string> empleados = await this.repo.GetNombreEmpleadossAsync(nombre);
            this.lstEmpleados.Items.Clear();
            foreach (string emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp);
            }
        }
    }
}
