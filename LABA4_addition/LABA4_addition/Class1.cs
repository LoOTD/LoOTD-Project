using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA4_addition
{

    internal class Class1
    {
        private Thread countdownThread = null;
        private ManualResetEvent _pauseEvent = new ManualResetEvent(true);
        private AxWindowsMediaPlayer _WMP2;

        public Class1(System.Windows.Forms.Label label2, AxWindowsMediaPlayer WMP2)
        {
            _WMP2 = WMP2;
            countdownThread = new Thread(() => CountDown(label2));
            countdownThread.Start();
        }

        private void CountDown(System.Windows.Forms.Label label2)
        {
            for (int i = 10; i >= 0; i--)
            {
                _pauseEvent.WaitOne();
                Thread.Sleep(1000);
                UpdateLabel(label2, i);
            }
        }


        private void UpdateLabel(System.Windows.Forms.Label label2, int value)
        {
            if (label2.InvokeRequired)
            {
                label2.BeginInvoke((MethodInvoker)(() => label2.Text = "Прошло секунд: " + value));
            }
            else label2.Text = "Прошло секунд: " + value;
        }

        public void ResetCountDown(System.Windows.Forms.Label label2)
        {
                if (countdownThread != null && countdownThread.IsAlive)
                {
                    countdownThread.Abort();
                }
                countdownThread = new Thread(() => CountDown(label2));
                countdownThread.Start();
        }

        public void StopCountDown()
        {
            _pauseEvent.Reset();
        }

        public void StartCountDown()
        {
            _pauseEvent.Set();
        }

        public void Stop()
        {
            _WMP2.Invoke((MethodInvoker)(() => _WMP2.Ctlcontrols.pause()));
        }

        public void Start()
        {
            _WMP2.Invoke((MethodInvoker)(() => _WMP2.Ctlcontrols.play()));
        }

        public void Media()
        {
            string filePath = "C:\\Users\\lotd8\\OneDrive\\Рабочий стол\\University\\С#\\Learning_Work\\LABA4_addition\\LABA4_addition\\Image\\planting_bomb_out.mp4";
            _WMP2.URL = filePath;
            _WMP2.Invoke((MethodInvoker)(() => _WMP2.Ctlcontrols.play()));
        }
    }
}
