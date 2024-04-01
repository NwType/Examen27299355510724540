namespace SistemasVentas.VISTA.UsuarioVistas
{
    partial class InsertarUsuarioVista
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 319);
            button1.Name = "button1";
            button1.Size = new Size(116, 32);
            button1.TabIndex = 0;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 319);
            button2.Name = "button2";
            button2.Size = new Size(108, 32);
            button2.TabIndex = 1;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 81);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "PERSONA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE DE USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 165);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "CONTRASENIA";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 207);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 5;
            label4.Text = "FECHAREG";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 23);
            textBox3.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(333, 77);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 10;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(163, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // InsertarUsuarioVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 390);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "InsertarUsuarioVista";
            Text = "InsertarUsuarioVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;
        private DateTimePicker dateTimePicker1;
    }
}