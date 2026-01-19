namespace NetCoreAdoNet
{
    partial class Form12MensajesServidor
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
            txtId = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtLocalidad = new TextBox();
            label3 = new Label();
            btnNuevo = new Button();
            lblServidor = new Label();
            label5 = new Label();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(32, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(120, 29);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 29);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 103);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(32, 213);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(120, 29);
            txtLocalidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 189);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(32, 265);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 60);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo Departamento";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.BackColor = SystemColors.ActiveCaptionText;
            lblServidor.ForeColor = SystemColors.Window;
            lblServidor.Location = new Point(32, 352);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(86, 21);
            lblServidor.TabIndex = 7;
            lblServidor.Text = "lblServidor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 24);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 8;
            label5.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(202, 48);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(314, 319);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 395);
            Controls.Add(lstDepartamentos);
            Controls.Add(label5);
            Controls.Add(lblServidor);
            Controls.Add(btnNuevo);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form12MensajesServidor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtLocalidad;
        private Label label3;
        private Button btnNuevo;
        private Label lblServidor;
        private Label label5;
        private ListBox lstDepartamentos;
    }
}