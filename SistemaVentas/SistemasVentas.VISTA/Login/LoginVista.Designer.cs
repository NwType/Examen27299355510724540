namespace SistemasVentas.VISTA.Login
{
    partial class LoginVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVista));
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 171);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 3;
            label2.Text = "CONTRASENIA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 106);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.Location = new Point(334, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientActiveCaption;
            textBox2.Location = new Point(334, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 56);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Location = new Point(242, 226);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "INICIAR SESION";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(324, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(230, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(461, 34);
            label3.Name = "label3";
            label3.Size = new Size(159, 22);
            label3.TabIndex = 1;
            label3.Text = "SUPER MARKET";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(143, 24);
            label4.TabIndex = 3;
            label4.Text = "BIENVENIDO";
            // 
            // LoginVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(826, 354);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginVista";
            Text = "LoginVista";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
    }
}