namespace SistemasVentas.VISTA.AdministradorAlmacenVista
{
    partial class AdministradorAlmacenVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorAlmacenVista));
            label3 = new Label();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(62, 55);
            label3.Name = "label3";
            label3.Size = new Size(159, 22);
            label3.TabIndex = 40;
            label3.Text = "SUPER MARKET";
            // 
            // button6
            // 
            button6.BackColor = Color.DarkGray;
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(121, 289);
            button6.Name = "button6";
            button6.Size = new Size(89, 27);
            button6.TabIndex = 46;
            button6.Text = "REPORTES";
            button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-47, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(15, 280);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 45;
            pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(121, 132);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 42;
            button1.Text = "DETALLE DE INGRESO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(121, 210);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 44;
            button2.Text = "PROVEEDORES";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox7);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 450);
            panel1.TabIndex = 47;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(250, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(474, 281);
            dataGridView1.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 23);
            textBox1.TabIndex = 49;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(637, 84);
            button3.Name = "button3";
            button3.Size = new Size(87, 29);
            button3.TabIndex = 50;
            button3.Text = "BUSCAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(740, 132);
            button4.Name = "button4";
            button4.Size = new Size(87, 29);
            button4.TabIndex = 51;
            button4.Text = "ANADIR";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(379, 21);
            label1.Name = "label1";
            label1.Size = new Size(275, 24);
            label1.TabIndex = 52;
            label1.Text = "INGRESO DE PRODUCTOS";
            // 
            // AdministradorAlmacenVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(830, 450);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "AdministradorAlmacenVista";
            Text = "AdministradorAlmacenVista";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox3;
        private Button button2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}