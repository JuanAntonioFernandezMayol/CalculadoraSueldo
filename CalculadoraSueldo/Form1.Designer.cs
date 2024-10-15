namespace CalculadoraSueldo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(365, 45);
            button1.Name = "button1";
            button1.Size = new Size(249, 115);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 1;
            label1.Text = "Horas Trabajadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 2;
            label2.Text = "Precio x h";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 35);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 35);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(682, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 35);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(702, 56);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(716, 152);
            label4.Name = "label4";
            label4.Size = new Size(24, 30);
            label4.TabIndex = 7;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(889, 303);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
