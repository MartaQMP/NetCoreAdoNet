namespace NetCoreAdoNet
{
    partial class Form03EliminarEnfermo
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
            bnEliminar = new Button();
            txtInscripcion = new TextBox();
            label2 = new Label();
            lstEnfermos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Inscripcion";
            // 
            // bnEliminar
            // 
            bnEliminar.Location = new Point(31, 90);
            bnEliminar.Margin = new Padding(4);
            bnEliminar.Name = "bnEliminar";
            bnEliminar.Size = new Size(127, 54);
            bnEliminar.TabIndex = 1;
            bnEliminar.Text = "Eliminar Enfermo";
            bnEliminar.UseVisualStyleBackColor = true;
            bnEliminar.Click += bnEliminar_Click;
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(31, 53);
            txtInscripcion.Margin = new Padding(4);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(127, 29);
            txtInscripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.Location = new Point(207, 53);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(206, 235);
            lstEnfermos.TabIndex = 4;
            // 
            // Form03EliminarEnfermo
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 314);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(txtInscripcion);
            Controls.Add(bnEliminar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form03EliminarEnfermo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form03EliminarEnfermo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bnEliminar;
        private TextBox txtInscripcion;
        private Label label2;
        private ListBox lstEnfermos;
    }
}