using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace OS_LABA4_Threads
{
    public partial class Form1 : Form
    {
        private Class1 class1Instance;

        public Form1()
        {
            InitializeComponent();

            class1Instance = new Class1(label2, pictureBox2);
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Thread countupThread = new Thread(CountUp);
            countupThread.Start();
        }

        private void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                this.Invoke((MethodInvoker)(() => label1.Text = "Прошло секунд: " + i));
                Thread.Sleep(1000);
            }
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}