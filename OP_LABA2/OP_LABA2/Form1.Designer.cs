namespace OP_LABA2
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
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.labelFlashDrive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 140);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(421, 423);
            this.richTextBox1.TabIndex = 0;
            // 
            // labelFlashDrive
            // 
            this.labelFlashDrive.AutoSize = true;
            this.labelFlashDrive.Location = new System.Drawing.Point(25, 70);
            this.labelFlashDrive.Name = "labelFlashDrive";
            this.labelFlashDrive.Size = new System.Drawing.Size(161, 25);
            this.labelFlashDrive.TabIndex = 1;
            this.labelFlashDrive.Text = "labelFlashDrive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 663);
            this.Controls.Add(this.labelFlashDrive);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Information about disk\'s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.Label labelFlashDrive;
    }
}

