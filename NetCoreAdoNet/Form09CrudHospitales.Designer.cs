namespace NetCoreAdoNet
{
    partial class Form09CrudHospitales
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
            btnModificar = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtNombre = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lstHospitales = new ListBox();
            txtTelefono = new TextBox();
            lable23 = new Label();
            txtCamas = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(118, 273);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 34);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 273);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 34);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(224, 273);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 34);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(343, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 29);
            txtNombre.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 88);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 17;
            label4.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(343, 187);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 29);
            txtDireccion.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 163);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 15;
            label3.Text = "Direccion";
            // 
            // txtId
            // 
            txtId.Location = new Point(343, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 29);
            txtId.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 14);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 13;
            label2.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 12;
            label1.Text = "Hospitales";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(17, 45);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(295, 214);
            lstHospitales.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(343, 262);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 29);
            txtTelefono.TabIndex = 25;
            // 
            // lable23
            // 
            lable23.AutoSize = true;
            lable23.Location = new Point(343, 238);
            lable23.Name = "lable23";
            lable23.Size = new Size(68, 21);
            lable23.TabIndex = 24;
            lable23.Text = "Telefono";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(343, 334);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(100, 29);
            txtCamas.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 310);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 22;
            label6.Text = "Camas";
            // 
            // Form09CrudHospitales
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 389);
            Controls.Add(txtTelefono);
            Controls.Add(lable23);
            Controls.Add(txtCamas);
            Controls.Add(label6);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstHospitales);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form09CrudHospitales";
            Text = "Form09CrudHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private ListBox lstHospitales;
        private TextBox txtTelefono;
        private Label lable23;
        private TextBox txtCamas;
        private Label label6;
    }
}