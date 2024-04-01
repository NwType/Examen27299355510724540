namespace SistemasVentas.VISTA.UsuarioVistas
{
    partial class UsuarioInsertarVistasP
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "PERSONA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(395, 36);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 2;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 82);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE DE USUARIO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 119);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 5;
            label3.Text = "CONTRASENIA";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 111);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(216, 23);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 164);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 7;
            label4.Text = "FECHA DE REGISTRO";
            // 
            // button2
            // 
            button2.Location = new Point(34, 236);
            button2.Name = "button2";
            button2.Size = new Size(93, 23);
            button2.TabIndex = 8;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(340, 236);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 10;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // UsuarioInsertarVistasP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UsuarioInsertarVistasP";
            Text = "UsuarioInsertarVistasP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Button button3;
    }
}