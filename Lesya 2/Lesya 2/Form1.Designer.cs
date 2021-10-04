namespace Lesya_2
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
            this.File_pth = new System.Windows.Forms.RichTextBox();
            this.File_path_label = new System.Windows.Forms.Label();
            this.Task_button = new System.Windows.Forms.Button();
            this.File_text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // File_pth
            // 
            this.File_pth.Location = new System.Drawing.Point(147, 80);
            this.File_pth.Name = "File_pth";
            this.File_pth.Size = new System.Drawing.Size(487, 26);
            this.File_pth.TabIndex = 0;
            this.File_pth.Text = "";
            // 
            // File_path_label
            // 
            this.File_path_label.AutoSize = true;
            this.File_path_label.Location = new System.Drawing.Point(79, 83);
            this.File_path_label.Name = "File_path_label";
            this.File_path_label.Size = new System.Drawing.Size(62, 17);
            this.File_path_label.TabIndex = 1;
            this.File_path_label.Text = "File path";
            // 
            // Task_button
            // 
            this.Task_button.Location = new System.Drawing.Point(66, 126);
            this.Task_button.Name = "Task_button";
            this.Task_button.Size = new System.Drawing.Size(75, 23);
            this.Task_button.TabIndex = 2;
            this.Task_button.Text = "Click";
            this.Task_button.UseVisualStyleBackColor = true;
            this.Task_button.Click += new System.EventHandler(this.Task_button_Click);
            // 
            // File_text
            // 
            this.File_text.Location = new System.Drawing.Point(147, 126);
            this.File_text.Name = "File_text";
            this.File_text.Size = new System.Drawing.Size(487, 96);
            this.File_text.TabIndex = 3;
            this.File_text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.File_text);
            this.Controls.Add(this.Task_button);
            this.Controls.Add(this.File_path_label);
            this.Controls.Add(this.File_pth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox File_pth;
        private System.Windows.Forms.Label File_path_label;
        private System.Windows.Forms.Button Task_button;
        private System.Windows.Forms.RichTextBox File_text;
    }
}

