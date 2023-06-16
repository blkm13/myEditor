namespace MySimplePaint
{
    partial class Form2
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
            information = new Button();
            start = new Button();
            exit = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // information
            // 
            information.BackColor = Color.Red;
            information.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            information.Location = new Point(5, 487);
            information.Name = "information";
            information.Size = new Size(164, 81);
            information.TabIndex = 0;
            information.Text = "Information";
            toolTip1.SetToolTip(information, "Информация о приложении");
            information.UseVisualStyleBackColor = false;
            information.Click += information_Click;
            // 
            // start
            // 
            start.BackColor = Color.Red;
            start.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            start.Location = new Point(210, 487);
            start.Name = "start";
            start.Size = new Size(164, 81);
            start.TabIndex = 1;
            start.Text = "Start";
            toolTip1.SetToolTip(start, "Выбрать картинку");
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Red;
            exit.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            exit.Location = new Point(417, 487);
            exit.Name = "exit";
            exit.Size = new Size(164, 81);
            exit.TabIndex = 2;
            exit.Text = "Exit";
            toolTip1.SetToolTip(exit, "Закрыть приложение");
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Главная1;
            ClientSize = new Size(593, 577);
            Controls.Add(exit);
            Controls.Add(start);
            Controls.Add(information);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button information;
        private Button start;
        private Button exit;
        private ToolTip toolTip1;
    }
}