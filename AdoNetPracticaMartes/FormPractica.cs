using AdoNetPracticaMartes.Models;
using AdoNetPracticaMartes.Repositories;

namespace AdoNetPracticaMartes
{
    public partial class FormPractica : Form
    {
        RepositoryHospital repo;
        public FormPractica()
        {
            InitializeComponent();
            this.repo = new RepositoryHospital();
            this.CargarHospitales();
        }

        private async Task CargarHospitales()
        {
            this.cmbHospitales.Items.Clear();
            List<Hospital> hospitales = await this.repo.GetHospitalesAsync();
            foreach(Hospital hospital in hospitales)
            {
                this.cmbHospitales.Items.Add(hospital.Nombre);
            }
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            
        }

        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstEmpleados.Items.Clear();
            string nombreHos = this.cmbHospitales.SelectedItem.ToString();
            List<Empleado> empleados = await this.repo.GetEmpleadosAsync(nombreHos);
            foreach (Empleado empleado in empleados)
            {
                this.lstEmpleados.Items.Add(empleado.Apellidos + " - " + empleado.Cargo + " - " + empleado.Salario);
            }
            Salario salario = await this.repo.GetSumaMediaPersonas(nombreHos);
            this.txtSuma.Text = salario.SumaSalarial.ToString();
            this.txtPersonas.Text = salario.Personas.ToString();
            this.txtMedia.Text = salario.MediaSalarial.ToString();
        }
    }
}
