namespace NetCoreAdoNet
{
    partial class Form13ParametrosSalida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbDepartamentos = new ComboBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            btnMostrar = new Button();
            label3 = new Label();
            txtSuma = new TextBox();
            txtMedia = new TextBox();
            label4 = new Label();
            txtPersonas = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(28, 56);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(157, 29);
            cmbDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 23);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(220, 56);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(228, 319);
            lstEmpleados.TabIndex = 3;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(28, 112);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(157, 40);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 183);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 5;
            label3.Text = "Suma Salarial";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(28, 207);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(157, 29);
            txtSuma.TabIndex = 6;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(28, 277);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(157, 29);
            txtMedia.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 253);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 7;
            label4.Text = "Media Salarial";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(28, 346);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(157, 29);
            txtPersonas.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 322);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 9;
            label5.Text = "Personas";
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 407);
            Controls.Add(txtPersonas);
            Controls.Add(label5);
            Controls.Add(txtMedia);
            Controls.Add(label4);
            Controls.Add(txtSuma);
            Controls.Add(label3);
            Controls.Add(btnMostrar);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form13ParametrosSalida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Label label2;
        private ListBox lstEmpleados;
        private Button btnMostrar;
        private Label label3;
        private TextBox txtSuma;
        private TextBox txtMedia;
        private Label label4;
        private TextBox txtPersonas;
        private Label label5;
    }
}