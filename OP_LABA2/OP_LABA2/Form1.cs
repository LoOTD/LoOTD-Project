using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OP_LABA2
{
    public partial class Form1 : Form
    {
        Timer timer;

        public Form1()
        {
            InitializeComponent();

            // Создаем таймер
            timer = new Timer();
            timer.Interval = 2000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Очищаем предыдущую информацию
            richTextBox1.Clear();

            // Получаем информацию о всех дисках
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            // Выводим информацию о каждом диске
            foreach (DriveInfo drive in allDrives)
            {
                richTextBox1.AppendText($"Диск: {drive.Name}" + Environment.NewLine);
                richTextBox1.AppendText($"Тип: {drive.DriveType}" + Environment.NewLine);
                if (drive.IsReady)
                {
                    richTextBox1.AppendText($"Файловая система: {drive.DriveFormat}" + Environment.NewLine);
                    richTextBox1.AppendText($"Объем диска: {drive.TotalSize / (1024 * 1024 * 1024)} GB" + Environment.NewLine);
                    richTextBox1.AppendText($"Свободное место: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB" + Environment.NewLine);
                }
                richTextBox1.AppendText(Environment.NewLine);
            }

            // Проверяем, вставлена ли флешка
            bool flashDriveInserted = DriveInfo.GetDrives()[DriveInfo.GetDrives().Length - 1].DriveType == DriveType.Removable;
            if (flashDriveInserted)
            {
                labelFlashDrive.Text = "Флешка вставлена";
            }
            else
            {
                labelFlashDrive.Text = "Флешка не вставлена";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
