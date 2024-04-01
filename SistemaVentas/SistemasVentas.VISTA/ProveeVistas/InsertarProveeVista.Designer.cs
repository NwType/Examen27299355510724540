namespace SistemasVentas.VISTA.ProveeVistas
{
    partial class InsertarProveeVista
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(161, 336);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(401, 336);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 107);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "IDPRODUCTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 147);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "IDPROVEEDOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 190);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "FECHA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 231);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "PRECIO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(268, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(268, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(268, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(145, 23);
            textBox4.TabIndex = 9;
            // 
            // InsertarProveeVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "InsertarProveeVista";
            Text = "InsertarProveeVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}