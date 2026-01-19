namespace NetCoreAdoNet
{
    partial class Form11ProcedimientosHospitalPlantilla
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
            label2 = new Label();
            cmbHospitales = new ComboBox();
            txtIncremento = new TextBox();
            btnModificar = new Button();
            label3 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(292, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Incremento";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(28, 52);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(184, 29);
            cmbHospitales.TabIndex = 2;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(292, 52);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(187, 29);
            txtIncremento.TabIndex = 3;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(168, 101);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(162, 34);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar salarios";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 208);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 5;
            label3.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(28, 244);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(451, 193);
            lstPlantilla.TabIndex = 6;
            // 
            // Form11ProcedimientosHospitalPlantilla
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 456);
            Controls.Add(lstPlantilla);
            Controls.Add(label3);
            Controls.Add(btnModificar);
            Controls.Add(txtIncremento);
            Controls.Add(cmbHospitales);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form11ProcedimientosHospitalPlantilla";
            Text = "Form11ProcedimientosHospitalPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbHospitales;
        private TextBox txtIncremento;
        private Button btnModificar;
        private Label label3;
        private ListBox lstPlantilla;
    }
}