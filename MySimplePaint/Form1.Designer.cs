﻿namespace MySimplePaint
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            save = new Button();
            colorBox = new PictureBox();
            bChooseColor = new Button();
            pColor = new Button();
            bMenu = new Button();
            panel4 = new Panel();
            bLine = new Button();
            bSquare = new Button();
            bCircle = new Button();
            panel3 = new Panel();
            numericUpDown1 = new NumericUpDown();
            bEraser = new Button();
            bPen = new Button();
            fill = new Button();
            bClear = new Button();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)colorBox).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BackgroundImage = Properties.Resources.qpQENUNbrvU;
            panel1.Controls.Add(save);
            panel1.Controls.Add(colorBox);
            panel1.Controls.Add(bChooseColor);
            panel1.Controls.Add(pColor);
            panel1.Controls.Add(bMenu);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(667, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 666);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // save
            // 
            save.BackColor = Color.White;
            save.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            save.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            save.FlatStyle = FlatStyle.Flat;
            save.Location = new Point(18, 573);
            save.Name = "save";
            save.Size = new Size(168, 33);
            save.TabIndex = 15;
            save.Text = "Save";
            toolTip1.SetToolTip(save, "Вернуться в меню ");
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // colorBox
            // 
            colorBox.Cursor = Cursors.Hand;
            colorBox.Image = Properties.Resources.палитра1;
            colorBox.Location = new Point(12, 275);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(188, 79);
            colorBox.TabIndex = 14;
            colorBox.TabStop = false;
            colorBox.Click += colorBox_Click;
            colorBox.MouseClick += colorBox_MouseClick;
            // 
            // bChooseColor
            // 
            bChooseColor.BackColor = Color.White;
            bChooseColor.Image = Properties.Resources.free_icon_color_palette_1277263;
            bChooseColor.Location = new Point(12, 217);
            bChooseColor.Name = "bChooseColor";
            bChooseColor.Size = new Size(61, 52);
            bChooseColor.TabIndex = 13;
            toolTip1.SetToolTip(bChooseColor, "Открыть палитру цветов");
            bChooseColor.UseVisualStyleBackColor = false;
            bChooseColor.Click += bChooseColor_Click;
            // 
            // pColor
            // 
            pColor.BackColor = Color.White;
            pColor.Location = new Point(143, 217);
            pColor.Name = "pColor";
            pColor.Size = new Size(57, 52);
            pColor.TabIndex = 10;
            pColor.UseVisualStyleBackColor = false;
            pColor.Click += pColor_Click;
            // 
            // bMenu
            // 
            bMenu.BackColor = Color.White;
            bMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            bMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            bMenu.FlatStyle = FlatStyle.Flat;
            bMenu.Location = new Point(18, 612);
            bMenu.Name = "bMenu";
            bMenu.Size = new Size(168, 33);
            bMenu.TabIndex = 7;
            bMenu.Text = "Menu";
            toolTip1.SetToolTip(bMenu, "Вернуться в меню ");
            bMenu.UseVisualStyleBackColor = false;
            bMenu.Click += bMenu_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Ivory;
            panel4.Controls.Add(bLine);
            panel4.Controls.Add(bSquare);
            panel4.Controls.Add(bCircle);
            panel4.Location = new Point(6, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(188, 53);
            panel4.TabIndex = 11;
            panel4.Paint += panel4_Paint;
            // 
            // bLine
            // 
            bLine.BackColor = Color.White;
            bLine.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            bLine.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            bLine.FlatStyle = FlatStyle.Flat;
            bLine.Image = Properties.Resources.free_icon_line_8133619;
            bLine.Location = new Point(139, 10);
            bLine.Name = "bLine";
            bLine.Size = new Size(37, 34);
            bLine.TabIndex = 3;
            toolTip1.SetToolTip(bLine, "Прямая");
            bLine.UseVisualStyleBackColor = false;
            bLine.Click += button5_Click;
            // 
            // bSquare
            // 
            bSquare.BackColor = Color.White;
            bSquare.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            bSquare.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            bSquare.FlatStyle = FlatStyle.Flat;
            bSquare.Image = Properties.Resources.free_icon_square_outline_54538;
            bSquare.Location = new Point(75, 10);
            bSquare.Name = "bSquare";
            bSquare.Size = new Size(37, 34);
            bSquare.TabIndex = 5;
            toolTip1.SetToolTip(bSquare, "Прямоугольник");
            bSquare.UseVisualStyleBackColor = false;
            bSquare.Click += button4_Click;
            // 
            // bCircle
            // 
            bCircle.BackColor = Color.White;
            bCircle.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            bCircle.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            bCircle.FlatStyle = FlatStyle.Flat;
            bCircle.Image = Properties.Resources.free_icon_circle_outline_32341;
            bCircle.Location = new Point(8, 10);
            bCircle.Name = "bCircle";
            bCircle.Size = new Size(37, 33);
            bCircle.TabIndex = 4;
            toolTip1.SetToolTip(bCircle, "Овал");
            bCircle.UseVisualStyleBackColor = false;
            bCircle.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Ivory;
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(bEraser);
            panel3.Controls.Add(bPen);
            panel3.Controls.Add(fill);
            panel3.Controls.Add(bClear);
            panel3.Location = new Point(9, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 85);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(9, 49);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(166, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // bEraser
            // 
            bEraser.BackColor = Color.White;
            bEraser.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            bEraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            bEraser.FlatStyle = FlatStyle.Flat;
            bEraser.Image = Properties.Resources.free_icon_eraser_6779506;
            bEraser.Location = new Point(93, 10);
            bEraser.Name = "bEraser";
            bEraser.Size = new Size(37, 33);
            bEraser.TabIndex = 3;
            toolTip1.SetToolTip(bEraser, "Ластик");
            bEraser.UseVisualStyleBackColor = false;
            bEraser.Click += button2_Click;
            // 
            // bPen
            // 
            bPen.BackColor = Color.White;
            bPen.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            bPen.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            bPen.FlatStyle = FlatStyle.Flat;
            bPen.Image = Properties.Resources.free_icon_paint_7471117__1_;
            bPen.Location = new Point(52, 10);
            bPen.Name = "bPen";
            bPen.Size = new Size(37, 33);
            bPen.TabIndex = 2;
            toolTip1.SetToolTip(bPen, "Кисть");
            bPen.UseVisualStyleBackColor = false;
            bPen.Click += button1_Click;
            // 
            // fill
            // 
            fill.BackColor = Color.White;
            fill.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            fill.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            fill.FlatStyle = FlatStyle.Flat;
            fill.Image = Properties.Resources.free_icon_fill_color_7570003;
            fill.Location = new Point(9, 10);
            fill.Name = "fill";
            fill.Size = new Size(37, 33);
            fill.TabIndex = 1;
            toolTip1.SetToolTip(fill, "Заливка");
            fill.UseVisualStyleBackColor = false;
            fill.Click += fill_Click_1;
            // 
            // bClear
            // 
            bClear.BackColor = Color.White;
            bClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            bClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            bClear.FlatStyle = FlatStyle.Flat;
            bClear.Image = Properties.Resources.free_icon_recycle_bin_3156999;
            bClear.Location = new Point(136, 10);
            bClear.Name = "bClear";
            bClear.Size = new Size(39, 33);
            bClear.TabIndex = 6;
            toolTip1.SetToolTip(bClear, "Удалить все");
            bClear.UseVisualStyleBackColor = false;
            bClear.Click += bClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(667, 667);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.qpQENUNbrvU1;
            ClientSize = new Size(880, 666);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)colorBox).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button pColor;
        private Button fill;
        private Button bMenu;
        private Button bClear;
        private Button bLine;
        private Button bSquare;
        private Button bCircle;
        private Button bEraser;
        private Button bPen;
        private Panel panel4;
        private Button bChooseColor;
        private PictureBox colorBox;
        private ToolTip toolTip1;
        private NumericUpDown numericUpDown1;
        private Button save;
    }
}