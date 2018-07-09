namespace BinaryCheckerTask
{
    partial class BinaryCheckerTask
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
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.textBoxOutPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCheck.Location = new System.Drawing.Point(174, 10);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(267, 34);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Check numbers";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(301, 176);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(137, 36);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(171, 50);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(267, 41);
            this.buttonClean.TabIndex = 5;
            this.buttonClean.Text = "Clean Result";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // textBoxOutPut
            // 
            this.textBoxOutPut.Location = new System.Drawing.Point(12, 12);
            this.textBoxOutPut.Multiline = true;
            this.textBoxOutPut.Name = "textBoxOutPut";
            this.textBoxOutPut.Size = new System.Drawing.Size(156, 202);
            this.textBoxOutPut.TabIndex = 7;
            // 
            // BinaryCheckerTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(450, 224);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxOutPut);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCheck);
            this.Name = "BinaryCheckerTask";
            this.Text = "Binary Checker Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.TextBox textBoxOutPut;
    }
}

