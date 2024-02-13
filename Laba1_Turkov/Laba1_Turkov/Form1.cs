using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Laba1_Turkov
{
    public partial class Form1 : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeStatusStrip();

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();

            button1.Click += button1_Click;
            fontDialog1.ShowColor = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            button1.Font = fontDialog1.Font;
            button1.ForeColor = fontDialog1.Color;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private  void InitializeStatusStrip()
        {
            toolStripStatusLabel1.Text = "Привет, нажми на меня!";
            statusStrip1.Items.Add(toolStripStatusLabel1);
        }

        private void fontDialog1_Apply_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // Установка свойств SplitContainer
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Panel1.BackColor = System.Drawing.Color.Gray;
            splitContainer1.Panel2.BackColor = System.Drawing.Color.Orange;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            // Проверка, заполнены ли оба TextBox'а
            bool textBox1Filled = !string.IsNullOrWhiteSpace(textBox1.Text);
            bool textBox2Filled = !string.IsNullOrWhiteSpace(textBox2.Text);

            // Определение прогресса в зависимости от заполненности TextBox'ов
            int totalTextBoxes = 2;
            int filledTextBoxes = (textBox1Filled ? 1 : 0) + (textBox2Filled ? 1 : 0);
            int progress = (int)((double)filledTextBoxes / totalTextBoxes * 100);

            // Обновление значения прогресса в ProgressBar
            progressBar1.Value = progress;
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Вы большой молодец!";
        }

        private void toolStripStatusLabel1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Пока";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
