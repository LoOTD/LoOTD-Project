using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_LABA1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void botton_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int a_1 = Convert.ToInt32(a);
            int res = (int)Math.Pow(a_1, 2) - 3 + a_1;
            textBox2.Text = res.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            textBox3.Text = "Пришёл";
            textBox4.Text = "Ушёл";
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            textBox3.Text = "Ушёл";
            textBox4.Text = "Пришёл";
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void Start_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = RandomColor();
        }
        private Color RandomColor()
        {
            Random rand = new Random();
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }
    }
}
