namespace DeleteKString
{
    partial class DeleteKString
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
            this.buttonDeleteKString = new System.Windows.Forms.Button();
            this.labelInputK = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonDeleteKString
            // 
            this.buttonDeleteKString.Location = new System.Drawing.Point(144, 9);
            this.buttonDeleteKString.Name = "buttonDeleteKString";
            this.buttonDeleteKString.Size = new System.Drawing.Size(138, 22);
            this.buttonDeleteKString.TabIndex = 2;
            this.buttonDeleteKString.Text = "Delete K String";
            this.buttonDeleteKString.UseVisualStyleBackColor = true;
            this.buttonDeleteKString.Click += new System.EventHandler(this.buttonDeleteKString_Click);
            // 
            // labelInputK
            // 
            this.labelInputK.AutoSize = true;
            this.labelInputK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelInputK.Location = new System.Drawing.Point(12, 9);
            this.labelInputK.Name = "labelInputK";
            this.labelInputK.Size = new System.Drawing.Size(76, 22);
            this.labelInputK.TabIndex = 4;
            this.labelInputK.Text = "Input K :";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(94, 11);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(41, 20);
            this.textBoxK.TabIndex = 5;
            this.textBoxK.Text = "4";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(195, 62);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 26);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DeleteKString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(287, 93);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.labelInputK);
            this.Controls.Add(this.buttonDeleteKString);
            this.Name = "DeleteKString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete K String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteKString;
        private System.Windows.Forms.Label labelInputK;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

