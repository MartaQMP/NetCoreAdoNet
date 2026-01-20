namespace AdoNetPracticaMartes
{
    partial class FormPractica
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
            txtPersonas = new TextBox();
            label5 = new Label();
            txtMedia = new TextBox();
            label4 = new Label();
            txtSuma = new TextBox();
            label3 = new Label();
            lstEmpleados = new ListBox();
            label2 = new Label();
            cmbHospitales = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(34, 255);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(157, 29);
            txtPersonas.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 231);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 20;
            label5.Text = "Personas";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(34, 186);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(157, 29);
            txtMedia.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 162);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 18;
            label4.Text = "Media Salarial";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(34, 116);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(157, 29);
            txtSuma.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 92);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 16;
            label3.Text = "Suma Salarial";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(226, 47);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(285, 235);
            lstEmpleados.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 14);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 13;
            label2.Text = "Empleados";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(34, 47);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(157, 29);
            cmbHospitales.TabIndex = 12;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // FormPractica
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 322);
            Controls.Add(txtPersonas);
            Controls.Add(label5);
            Controls.Add(txtMedia);
            Controls.Add(label4);
            Controls.Add(txtSuma);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FormPractica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersonas;
        private Label label5;
        private TextBox txtMedia;
        private Label label4;
        private TextBox txtSuma;
        private Label label3;
        private ListBox lstEmpleados;
        private Label label2;
        private ComboBox cmbHospitales;
        private Label label1;
    }
}
