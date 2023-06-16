namespace MySimplePaint
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.мини1;
            button1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(417, 411);
            button1.Name = "button1";
            button1.Size = new Size(164, 164);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.мини2;
            button2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(12, 411);
            button2.Name = "button2";
            button2.Size = new Size(164, 164);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.мини3;
            button3.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(215, 411);
            button3.Name = "button3";
            button3.Size = new Size(164, 164);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SandyBrown;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.DarkRed;
            textBox1.Location = new Point(255, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 40);
            textBox1.TabIndex = 4;
            textBox1.Text = " А ну, малыш, давай!";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SandyBrown;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.ForeColor = Color.DarkRed;
            textBox2.Location = new Point(255, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 40);
            textBox2.TabIndex = 5;
            textBox2.Text = "  Картинку выбирай!";
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.BackgroundImage = Properties.Resources.curve_arrow_pointing_left;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.FromArgb(255, 192, 255);
            button4.Location = new Point(3, 1);
            button4.Name = "button4";
            button4.Size = new Size(33, 33);
            button4.TabIndex = 6;
            toolTip1.SetToolTip(button4, "Вернуться в меню");
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Главная1;
            ClientSize = new Size(593, 590);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private ToolTip toolTip1;
    }
}