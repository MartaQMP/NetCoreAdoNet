namespace NetCoreAdoNet
{
    partial class Form07DepartamentosEmpleados
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
            lstEmpleados = new ListBox();
            label2 = new Label();
            lstDepartamentos = new ListBox();
            label1 = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(264, 67);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(206, 235);
            lstEmpleados.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 20;
            label2.Text = "Empleados";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(31, 67);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(206, 235);
            lstDepartamentos.TabIndex = 23;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 22;
            label1.Text = "Departamentos";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(515, 67);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 39);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form07DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 344);
            Controls.Add(btnEliminar);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form07DepartamentosEmpleados";
            Text = "Form07DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleados;
        private Label label2;
        private ListBox lstDepartamentos;
        private Label label1;
        private Button btnEliminar;
    }
}