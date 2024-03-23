namespace LABA4_addition
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.WMP2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "10:00";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(193, 4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(113, 47);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click_1);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(312, 3);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(113, 49);
            this.Start.TabIndex = 5;
            this.Start.Text = "Продолжить";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // WMP2
            // 
            this.WMP2.Enabled = true;
            this.WMP2.Location = new System.Drawing.Point(308, 12);
            this.WMP2.Name = "WMP2";
            this.WMP2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP2.OcxState")));
            this.WMP2.Size = new System.Drawing.Size(247, 229);
            this.WMP2.TabIndex = 7;
            // 
            // WMP1
            // 
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(8, 12);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(247, 229);
            this.WMP1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 57);
            this.panel1.TabIndex = 8;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(431, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(113, 47);
            this.Update.TabIndex = 6;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(561, 319);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WMP2);
            this.Controls.Add(this.WMP1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private AxWMPLib.AxWindowsMediaPlayer WMP1;
        private AxWMPLib.AxWindowsMediaPlayer WMP2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Update;
    }
}

