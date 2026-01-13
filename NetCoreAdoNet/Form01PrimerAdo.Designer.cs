namespace NetCoreAdoNet
{
    partial class Form01PrimerAdo
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
            btnRead = new Button();
            btnConectar = new Button();
            btnDesconectar = new Button();
            label1 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            label2 = new Label();
            lstTipos = new ListBox();
            label3 = new Label();
            lblConexion = new Label();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(30, 188);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(107, 40);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(30, 71);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(107, 40);
            btnConectar.TabIndex = 3;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(30, 128);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(107, 40);
            btnDesconectar.TabIndex = 4;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 25);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 5;
            label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(154, 49);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(129, 214);
            lstApellidos.TabIndex = 6;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(306, 49);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(129, 214);
            lstColumnas.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 25);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 7;
            label2.Text = "Columnas";
            // 
            // lstTipos
            // 
            lstTipos.FormattingEnabled = true;
            lstTipos.Location = new Point(452, 49);
            lstTipos.Name = "lstTipos";
            lstTipos.Size = new Size(129, 214);
            lstTipos.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 25);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 9;
            label3.Text = "Tipos dato";
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(41, 288);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(75, 21);
            lblConexion.TabIndex = 11;
            lblConexion.Text = "Conexion";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 327);
            Controls.Add(lblConexion);
            Controls.Add(lstTipos);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(label2);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Controls.Add(btnRead);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnConectar;
        private Button btnDesconectar;
        private Label label1;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private Label label2;
        private ListBox lstTipos;
        private Label label3;
        private Label lblConexion;
    }
}