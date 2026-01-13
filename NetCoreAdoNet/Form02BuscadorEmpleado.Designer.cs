namespace NetCoreAdoNet
{
    partial class Form02BuscadorEmpleado
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
            btnBuscar = new Button();
            label1 = new Label();
            txtSalario = new TextBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(42, 103);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(167, 37);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Empleados";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 1;
            label1.Text = "Introduzca salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(42, 64);
            txtSalario.Margin = new Padding(4, 5, 4, 5);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(167, 29);
            txtSalario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 165);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(42, 189);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(167, 193);
            lstEmpleados.TabIndex = 4;
            // 
            // Form02BuscadorEmpleado
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 431);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form02BuscadorEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form02BuscadorEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Label label1;
        private TextBox txtSalario;
        private Label label2;
        private ListBox lstEmpleados;
    }
}