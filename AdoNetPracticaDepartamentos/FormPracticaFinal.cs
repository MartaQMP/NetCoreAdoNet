using AdoNetPracticaDepartamentos.Models;
using AdoNetPracticaDepartamentos.Repositories;
using System.Threading.Tasks;

namespace AdoNetPracticaDepartamentos
{
    public partial class FormPracticaFinal : Form
    {
        RepositoryDepartamento repo;
        public FormPracticaFinal()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamento();
            this.CargarDepartamentos();
        }

        private async void CargarDepartamentos()
        {
            List<Departamento> depts = await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (Departamento dept in depts)
            {
                this.cmbDepartamentos.Items.Add(dept.Nombre);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            int registros = await this.repo.InsertDepartamentoAsync(id, nombre, localidad);
            MessageBox.Show("Regsitros insertados: " + registros);
            this.CargarDepartamentos();
            this.txtNombre.Text = "";
            this.txtLocalidad.Text = "";
            this.txtId.Text = "";
            this.lstEmpleados.Items.Clear();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string seleccionado = this.lstEmpleados.SelectedItem.ToString();
            string apellido = this.txtApellido.Text;
            string oficio = this.txtOficio.Text;
            int salario = int.Parse(this.txtSalario.Text);
            int registros = await this.repo.UpdateEmpleadoAsync(seleccionado, apellido, oficio, salario);
            MessageBox.Show("Registros actualizados: " + registros);
            this.CargarDepartamentos();
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDept = this.cmbDepartamentos.SelectedItem.ToString();
            Departamento dept = await this.repo.GetDepartamentoAsync(nombreDept);
            //VER INFO DEPARTAMENTO
            this.txtId.Text = dept.IdDept.ToString();
            this.txtNombre.Text = dept.Nombre;
            this.txtLocalidad.Text = dept.Localidad;
            List<Empleado> empleados = await this.repo.GetEmpleadosAsync(nombreDept);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido);
            }
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            Empleado emp = await this.repo.GetEmpleadoAsync(apellido);
            this.txtApellido.Text = emp.Apellido;
            this.txtOficio.Text = emp.Oficio;
            this.txtSalario.Text = emp.Salario.ToString();

        }
    }
}
