using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySimplePaint
{
    public partial class Informatin : Form
    {
        public Informatin()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            // Задать цвет фона кнопки
            button1.BackColor = Color.FromArgb(190, 255, 255);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
