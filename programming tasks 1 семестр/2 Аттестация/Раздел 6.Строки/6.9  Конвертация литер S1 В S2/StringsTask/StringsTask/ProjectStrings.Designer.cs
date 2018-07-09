namespace StringsTask
{
    partial class ProjectStrings
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFirstString = new System.Windows.Forms.TextBox();
            this.textBoxSecondString = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.FirstString = new System.Windows.Forms.Label();
            this.SecondString = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.StringsResult = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstString
            // 
            this.textBoxFirstString.Location = new System.Drawing.Point(10, 47);
            this.textBoxFirstString.Name = "textBoxFirstString";
            this.textBoxFirstString.Size = new System.Drawing.Size(426, 20);
            this.textBoxFirstString.TabIndex = 0;
            this.textBoxFirstString.Text = "ab";
            // 
            // textBoxSecondString
            // 
            this.textBoxSecondString.Location = new System.Drawing.Point(10, 101);
            this.textBoxSecondString.Name = "textBoxSecondString";
            this.textBoxSecondString.Size = new System.Drawing.Size(426, 20);
            this.textBoxSecondString.TabIndex = 1;
            this.textBoxSecondString.Text = "aabb";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(10, 127);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(426, 38);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Check Strings";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // FirstString
            // 
            this.FirstString.AutoSize = true;
            this.FirstString.Location = new System.Drawing.Point(7, 31);
            this.FirstString.Name = "FirstString";
            this.FirstString.Size = new System.Drawing.Size(56, 13);
            this.FirstString.TabIndex = 3;
            this.FirstString.Text = "First String";
            // 
            // SecondString
            // 
            this.SecondString.AutoSize = true;
            this.SecondString.Location = new System.Drawing.Point(7, 85);
            this.SecondString.Name = "SecondString";
            this.SecondString.Size = new System.Drawing.Size(74, 13);
            this.SecondString.TabIndex = 4;
            this.SecondString.Text = "Second String";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(10, 202);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(426, 20);
            this.textBoxResult.TabIndex = 5;
            // 
            // StringsResult
            // 
            this.StringsResult.AutoSize = true;
            this.StringsResult.Location = new System.Drawing.Point(12, 186);
            this.StringsResult.Name = "StringsResult";
            this.StringsResult.Size = new System.Drawing.Size(37, 13);
            this.StringsResult.TabIndex = 6;
            this.StringsResult.Text = "Result";
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(304, 251);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(132, 28);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProjectStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(443, 291);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StringsResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.SecondString);
            this.Controls.Add(this.FirstString);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.textBoxSecondString);
            this.Controls.Add(this.textBoxFirstString);
            this.Name = "ProjectStrings";
            this.Text = "Program \"Strings\"";
            this.Load += new System.EventHandler(this.ProjectStrings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstString;
        private System.Windows.Forms.TextBox textBoxSecondString;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label FirstString;
        private System.Windows.Forms.Label SecondString;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label StringsResult;
        private System.Windows.Forms.Button CloseButton;
    }
}

