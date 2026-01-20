namespace NetCoreAdoNet
{
    partial class Form14Settings
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
            btnLeer = new Button();
            lblConexion = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnHelper = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(24, 23);
            btnLeer.Margin = new Padding(4);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(142, 45);
            btnLeer.TabIndex = 0;
            btnLeer.Text = "Leer Settings";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(24, 89);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(92, 21);
            lblConexion.TabIndex = 1;
            lblConexion.Text = "lblConexion";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 216);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(220, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 216);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnHelper
            // 
            btnHelper.Location = new Point(243, 23);
            btnHelper.Margin = new Padding(4);
            btnHelper.Name = "btnHelper";
            btnHelper.Size = new Size(142, 45);
            btnHelper.TabIndex = 4;
            btnHelper.Text = "Leer Helper";
            btnHelper.UseVisualStyleBackColor = true;
            btnHelper.Click += btnHelper_Click;
            // 
            // Form14Settings
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 356);
            Controls.Add(btnHelper);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblConexion);
            Controls.Add(btnLeer);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form14Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form14Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeer;
        private Label lblConexion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnHelper;
    }
}