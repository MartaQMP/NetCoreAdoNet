namespace NetCoreAdoNet
{
    partial class Form04EliminarPlantilla
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
            lstPlantilla = new ListBox();
            label2 = new Label();
            txtInscripcion = new TextBox();
            bnEliminar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(196, 50);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(206, 235);
            lstPlantilla.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 8;
            label2.Text = "Plantilla";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(20, 50);
            txtInscripcion.Margin = new Padding(4);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(127, 29);
            txtInscripcion.TabIndex = 7;
            // 
            // bnEliminar
            // 
            bnEliminar.Location = new Point(20, 87);
            bnEliminar.Margin = new Padding(4);
            bnEliminar.Name = "bnEliminar";
            bnEliminar.Size = new Size(127, 54);
            bnEliminar.TabIndex = 6;
            bnEliminar.Text = "Eliminar Plantilla";
            bnEliminar.UseVisualStyleBackColor = true;
            bnEliminar.Click += bnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 5;
            label1.Text = "Inscripcion";
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 310);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(txtInscripcion);
            Controls.Add(bnEliminar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form04EliminarPlantilla";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPlantilla;
        private Label label2;
        private TextBox txtInscripcion;
        private Button bnEliminar;
        private Label label1;
    }
}