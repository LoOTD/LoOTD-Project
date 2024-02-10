using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tusk2
{
    public partial class Tusk2 : Form
    {
        public Tusk2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Tusk2_MouseHover(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string a_1 = Convert.ToString(a);
            string b_1 = Convert.ToString(b);
            a_1 = "Приходит";
            b_1 = "Уходит";
        }
    }
}
