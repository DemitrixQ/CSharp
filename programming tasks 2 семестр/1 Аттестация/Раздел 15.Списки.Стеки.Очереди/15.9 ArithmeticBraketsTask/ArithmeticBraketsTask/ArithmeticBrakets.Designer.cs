namespace ArithmeticBraketsTask
{
    partial class ArithmeticBrakets
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
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMathExpression = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCheck.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCheck.Location = new System.Drawing.Point(12, 89);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(575, 36);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "Check Correct Placement of Brakets";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Math Expression \r\n\r\n";
            // 
            // textBoxMathExpression
            // 
            this.textBoxMathExpression.AccessibleDescription = "";
            this.textBoxMathExpression.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxMathExpression.Location = new System.Drawing.Point(13, 53);
            this.textBoxMathExpression.Name = "textBoxMathExpression";
            this.textBoxMathExpression.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMathExpression.Size = new System.Drawing.Size(575, 21);
            this.textBoxMathExpression.TabIndex = 5;
            this.textBoxMathExpression.Text = "( )  { } [ ] ( { [ ] } )";
            this.textBoxMathExpression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxResult.Enabled = false;
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxResult.Location = new System.Drawing.Point(12, 142);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(575, 55);
            this.textBoxResult.TabIndex = 7;
            this.textBoxResult.Text = "Result of Research";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(393, 222);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(197, 36);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ArithmeticBrakets
            // 
            this.AcceptButton = this.buttonCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(599, 270);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxMathExpression);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheck);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.MaximumSize = new System.Drawing.Size(936, 421);
            this.Name = "ArithmeticBrakets";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arithmetic Brakets Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMathExpression;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonClose;
    }
}

