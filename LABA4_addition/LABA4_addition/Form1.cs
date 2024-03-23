using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AxWMPLib;

namespace LABA4_addition
{
    public partial class Form1 : Form
    {
        private Class1 class1Instance;

        private Thread countupThread = null;

        private ManualResetEvent pauseEvent =  new ManualResetEvent(true);


        public Form1()
        {
            InitializeComponent();

            class1Instance = new Class1(label2, WMP2);
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
            class1Instance.Media();

            Media();
        }

        private void CountUp()
        {
            for (double i = 0.00; i <= 10.00; i++)
            {
                pauseEvent.WaitOne();
                label1.BeginInvoke((MethodInvoker)(() =>
                {
                    label1.Text = "Прошло секунд: " + i;
                }));
                Thread.Sleep(1000);
            }
        }


        private void Stop_Click_1(object sender, EventArgs e)
        {
            pauseEvent.Reset();
            class1Instance.StopCountDown();

            WMP1.Invoke((MethodInvoker)(() => WMP1.Ctlcontrols.pause()));
            class1Instance.Stop();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            pauseEvent.Set();
            class1Instance.StartCountDown();

            WMP1.Invoke((MethodInvoker)(() => WMP1.Ctlcontrols.play()));
            class1Instance.Start();
        }

        private void Media()
        {
            string filePath = "C:\\Users\\lotd8\\OneDrive\\Рабочий стол\\University\\С#\\Learning_Work\\LABA4_addition\\LABA4_addition\\Image\\planting_bomb.mp4";
            
            WMP1.URL = filePath;
            WMP1.Invoke((MethodInvoker)(() => WMP1.Ctlcontrols.play()));
        }

        private void RestartCountUp()
        {
            if (countupThread != null && countupThread.IsAlive)
            {
                countupThread.Abort();
            }
            countupThread = new Thread(CountUp);
            countupThread.Start();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            class1Instance.Media();
            Media();
            RestartCountUp();
        }
    }
}
