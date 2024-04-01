namespace SistemasVentas.VISTA.VendedorVista
{
    partial class AnadirVentaVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirVentaVista));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(478, 43);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 21;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 19;
            label1.Text = "CLIENTE";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(242, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 83);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 22;
            label4.Text = "FECHA ";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(132, 116);
            button2.Name = "button2";
            button2.Size = new Size(93, 39);
            button2.TabIndex = 24;
            button2.Text = "SELECCIONAR PRODUCTO";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(174, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(468, 198);
            dataGridView1.TabIndex = 25;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Location = new Point(434, 396);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 27;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Location = new Point(261, 396);
            button4.Name = "button4";
            button4.Size = new Size(93, 23);
            button4.TabIndex = 26;
            button4.Text = "GUARDAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 65);
            label3.Name = "label3";
            label3.Size = new Size(159, 22);
            label3.TabIndex = 29;
            label3.Text = "SUPER MARKET";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-14, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // AnadirVentaVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AnadirVentaVista";
            Text = "AnadirVentaVista";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Label label3;
        private PictureBox pictureBox1;
    }
}