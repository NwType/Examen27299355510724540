namespace SistemasVentas.VISTA.ProveedorVistas
{
    partial class EditarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProveedor));
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(408, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(408, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 201);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 12;
            label3.Text = "DIRECCION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 158);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 11;
            label2.Text = "TELEFONO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 112);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 10;
            label1.Text = "NOMBRE";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Location = new Point(408, 299);
            button2.Name = "button2";
            button2.Size = new Size(89, 42);
            button2.TabIndex = 9;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(293, 299);
            button1.Name = "button1";
            button1.Size = new Size(91, 42);
            button1.TabIndex = 8;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(124, 69);
            label4.Name = "label4";
            label4.Size = new Size(159, 22);
            label4.TabIndex = 58;
            label4.Text = "SUPER MARKET";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(293, 25);
            label5.Name = "label5";
            label5.Size = new Size(252, 24);
            label5.TabIndex = 67;
            label5.Text = "EDITAR PROVEEDORES";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(551, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 68;
            pictureBox2.TabStop = false;
            // 
            // EditarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EditarProveedor";
            Text = "EditarProveedor";
            Load += EditarProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox pictureBox2;
    }
}