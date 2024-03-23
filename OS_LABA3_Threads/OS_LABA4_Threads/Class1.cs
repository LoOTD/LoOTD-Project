using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_LABA4_Threads
{
    internal class Class1
    {
        private PictureBox _pictureBox2;

        public Class1(System.Windows.Forms.Label label2, PictureBox pictureBox2)
        {
            _pictureBox2 = pictureBox2;
            Thread countdownThread = new Thread(() => CountDown(label2));
            countdownThread.Start();
        }

        private void CountDown(System.Windows.Forms.Label label2)
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                UpdateLabel(label2, i);
            }
            UpdatePictureBoxImage(_pictureBox2);
        }

        public void UpdatePictureBoxImage(PictureBox _pictureBox2)
        {
            if (_pictureBox2.InvokeRequired)
            {
                _pictureBox2.Image = null;
            }
            else _pictureBox2.Image = null;
        }

        private void UpdateLabel(System.Windows.Forms.Label label2, int value)
        {
            if (label2.InvokeRequired)
            {
                label2.BeginInvoke((MethodInvoker)(() => label2.Text = "Прошло секунд: " + value));
            }
            else label2.Text = "Прошло секунд: " + value;
        }
    }
}
