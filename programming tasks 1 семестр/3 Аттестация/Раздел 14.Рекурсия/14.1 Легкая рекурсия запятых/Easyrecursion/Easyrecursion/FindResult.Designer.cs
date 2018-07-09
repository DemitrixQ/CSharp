namespace Easyrecursion
{
    partial class TrainingTask
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
            this.buttonUseRecursion = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelInputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUseRecursion
            // 
            this.buttonUseRecursion.Location = new System.Drawing.Point(371, 87);
            this.buttonUseRecursion.Name = "buttonUseRecursion";
            this.buttonUseRecursion.Size = new System.Drawing.Size(146, 88);
            this.buttonUseRecursion.TabIndex = 0;
            this.buttonUseRecursion.Text = "Use Recursion";
            this.buttonUseRecursion.UseVisualStyleBackColor = true;
            this.buttonUseRecursion.Click += new System.EventHandler(this.buttonUseRecursion_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(398, 282);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 31);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 226);
            this.textBox1.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 32);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(188, 13);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Посчитанное количество запятых : ";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(203, 29);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(314, 20);
            this.textBoxResult.TabIndex = 4;
            // 
            // labelInputText
            // 
            this.labelInputText.AutoSize = true;
            this.labelInputText.Location = new System.Drawing.Point(12, 71);
            this.labelInputText.Name = "labelInputText";
            this.labelInputText.Size = new System.Drawing.Size(61, 13);
            this.labelInputText.TabIndex = 5;
            this.labelInputText.Text = "Input Text :";
            // 
            // TrainingTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(520, 321);
            this.ControlBox = false;
            this.Controls.Add(this.labelInputText);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUseRecursion);
            this.Name = "TrainingTask";
            this.Text = "TrainingTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUseRecursion;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelInputText;
    }
}

