namespace NetCoreAdoNet
{
    partial class Form10UpdateEmpleados
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
            lstOficios = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            txtIncremento = new TextBox();
            label3 = new Label();
            btnIncremento = new Button();
            lbl3 = new Label();
            lblMediaSalarial = new Label();
            lblSumaSalarial = new Label();
            lblMaximoSalarial = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 14;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(27, 59);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(211, 256);
            lstOficios.TabIndex = 13;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 28);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 16;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(254, 59);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(192, 256);
            lstEmpleados.TabIndex = 15;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(473, 59);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 29);
            txtIncremento.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(473, 28);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 18;
            label3.Text = "Subir salario";
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(473, 109);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(97, 37);
            btnIncremento.TabIndex = 19;
            btnIncremento.Text = "Incremento";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(27, 409);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(0, 21);
            lbl3.TabIndex = 20;
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(27, 375);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(121, 21);
            lblMediaSalarial.TabIndex = 21;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(27, 343);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(118, 21);
            lblSumaSalarial.TabIndex = 22;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMaximoSalarial
            // 
            lblMaximoSalarial.AutoSize = true;
            lblMaximoSalarial.Location = new Point(27, 409);
            lblMaximoSalarial.Name = "lblMaximoSalarial";
            lblMaximoSalarial.Size = new Size(134, 21);
            lblMaximoSalarial.TabIndex = 23;
            lblMaximoSalarial.Text = "lblMaximoSalarial";
            // 
            // Form10UpdateEmpleados
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 448);
            Controls.Add(lblMaximoSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lbl3);
            Controls.Add(btnIncremento);
            Controls.Add(label3);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(lstEmpleados);
            Controls.Add(label1);
            Controls.Add(lstOficios);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form10UpdateEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form10UpdateEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListBox lstEmpleados;
        private TextBox txtIncremento;
        private Label label3;
        private Button btnIncremento;
        private Label lbl3;
        private Label lblMediaSalarial;
        private Label lblSumaSalarial;
        private Label lblMaximoSalarial;
    }
}