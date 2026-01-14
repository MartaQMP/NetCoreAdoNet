namespace NetCoreAdoNet
{
    partial class Form08CrudDepartamentos
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
            lstDepartamentos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtLocalidad = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(24, 44);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(295, 214);
            lstDepartamentos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 1;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 19);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(344, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 29);
            txtId.TabIndex = 3;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(344, 192);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 29);
            txtLocalidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 168);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(344, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 29);
            txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 93);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(344, 251);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 34);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(24, 277);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(344, 291);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 34);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 352);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstDepartamentos);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form08CrudDepartamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form08CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDepartamentos;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtLocalidad;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}