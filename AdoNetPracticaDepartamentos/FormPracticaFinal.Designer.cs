namespace AdoNetPracticaDepartamentos
{
    partial class FormPracticaFinal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLocalidad = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            lstEmpleados = new ListBox();
            label2 = new Label();
            cmbDepartamentos = new ComboBox();
            label1 = new Label();
            txtSalario = new TextBox();
            label6 = new Label();
            txtOficio = new TextBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label8 = new Label();
            btnInsertar = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(19, 262);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(157, 29);
            txtLocalidad.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 238);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 30;
            label5.Text = "Localidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(19, 193);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 29);
            txtNombre.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 169);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 28;
            label4.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(19, 123);
            txtId.Name = "txtId";
            txtId.Size = new Size(157, 29);
            txtId.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 99);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 26;
            label3.Text = "Id";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(211, 56);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(285, 298);
            lstEmpleados.TabIndex = 25;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 23);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 24;
            label2.Text = "Empleados";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(19, 56);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(157, 29);
            cmbDepartamentos.TabIndex = 23;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 22;
            label1.Text = "Departamentos";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(529, 193);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(157, 29);
            txtSalario.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 169);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 36;
            label6.Text = "Salario";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(529, 124);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(157, 29);
            txtOficio.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(529, 100);
            label7.Name = "label7";
            label7.Size = new Size(51, 21);
            label7.TabIndex = 34;
            label7.Text = "Oficio";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(529, 54);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(157, 29);
            txtApellido.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(532, 30);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 32;
            label8.Text = "Apellido";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(19, 306);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(157, 60);
            btnInsertar.TabIndex = 38;
            btnInsertar.Text = "Insertar Departamento";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(529, 262);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 60);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Actualizar Empleado";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormPracticaFinal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 369);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsertar);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(txtOficio);
            Controls.Add(label7);
            Controls.Add(txtApellido);
            Controls.Add(label8);
            Controls.Add(txtLocalidad);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FormPracticaFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox txtLocalidad;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtId;
        private Label label3;
        private ListBox lstEmpleados;
        private Label label2;
        private ComboBox cmbDepartamentos;
        private Label label1;
        private TextBox txtSalario;
        private Label label6;
        private TextBox txtOficio;
        private Label label7;
        private TextBox txtApellido;
        private Label label8;
        private Button btnInsertar;
        private Button btnUpdate;
    }
}
