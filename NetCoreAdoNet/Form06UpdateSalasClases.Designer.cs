namespace NetCoreAdoNet
{
    partial class Form06UpdateSalasClases
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
            lstSalas = new ListBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(29, 48);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(206, 235);
            lstSalas.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 18;
            label2.Text = "Salas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(267, 47);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 29);
            txtNombre.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(267, 84);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 54);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update salas";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 15;
            label1.Text = "Nuevo nombre";
            // 
            // Form06UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(432, 309);
            Controls.Add(lstSalas);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form06UpdateSalasClases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form06UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSalas;
        private Label label2;
        private TextBox txtNombre;
        private Button btnUpdate;
        private Label label1;
    }
}