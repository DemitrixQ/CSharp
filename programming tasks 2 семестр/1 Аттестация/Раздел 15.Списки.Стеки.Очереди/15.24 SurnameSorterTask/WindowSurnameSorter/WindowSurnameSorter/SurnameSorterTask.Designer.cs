namespace WindowSurnameSorter
{
    partial class SurnameSorterTask
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
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.textBoxFSL = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonAddSurname = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFillList = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelFileList = new System.Windows.Forms.Label();
            this.labelFormedList = new System.Windows.Forms.Label();
            this.labelInputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // textBoxSL
            // 
            this.textBoxSL.Location = new System.Drawing.Point(323, 28);
            this.textBoxSL.Multiline = true;
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(203, 293);
            this.textBoxSL.TabIndex = 1;
            this.textBoxSL.Text = "\r\n";
            // 
            // textBoxFSL
            // 
            this.textBoxFSL.Location = new System.Drawing.Point(579, 28);
            this.textBoxFSL.Multiline = true;
            this.textBoxFSL.Name = "textBoxFSL";
            this.textBoxFSL.Size = new System.Drawing.Size(198, 293);
            this.textBoxFSL.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 28);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(266, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // buttonAddSurname
            // 
            this.buttonAddSurname.Location = new System.Drawing.Point(12, 59);
            this.buttonAddSurname.Name = "buttonAddSurname";
            this.buttonAddSurname.Size = new System.Drawing.Size(266, 29);
            this.buttonAddSurname.TabIndex = 4;
            this.buttonAddSurname.Text = "Add Surname to Surname List";
            this.buttonAddSurname.UseVisualStyleBackColor = true;
            this.buttonAddSurname.Click += new System.EventHandler(this.buttonAddSurname_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 283);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(144, 38);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFillList
            // 
            this.buttonFillList.Location = new System.Drawing.Point(12, 94);
            this.buttonFillList.Name = "buttonFillList";
            this.buttonFillList.Size = new System.Drawing.Size(266, 26);
            this.buttonFillList.TabIndex = 6;
            this.buttonFillList.Text = "Fill Surname List";
            this.buttonFillList.UseVisualStyleBackColor = true;
            this.buttonFillList.Click += new System.EventHandler(this.buttonFillList_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(12, 131);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(266, 110);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "15.24. \r\nСоздать очередь, информационные поля которой содержат строки  из файла \r" +
    "\n(список фамилий учащихся, упорядоченный по алфавиту). \r\nВставить в этот список " +
    "новую фамилию с сохранением порядка. \r\n";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFileList
            // 
            this.labelFileList.AutoSize = true;
            this.labelFileList.Location = new System.Drawing.Point(320, 12);
            this.labelFileList.Name = "labelFileList";
            this.labelFileList.Size = new System.Drawing.Size(74, 13);
            this.labelFileList.TabIndex = 8;
            this.labelFileList.Text = "Surname List :";
            // 
            // labelFormedList
            // 
            this.labelFormedList.AutoSize = true;
            this.labelFormedList.Location = new System.Drawing.Point(576, 12);
            this.labelFormedList.Name = "labelFormedList";
            this.labelFormedList.Size = new System.Drawing.Size(112, 13);
            this.labelFormedList.TabIndex = 9;
            this.labelFormedList.Text = "Formed Surname List :";
            // 
            // labelInputText
            // 
            this.labelInputText.AutoSize = true;
            this.labelInputText.Location = new System.Drawing.Point(9, 9);
            this.labelInputText.Name = "labelInputText";
            this.labelInputText.Size = new System.Drawing.Size(82, 13);
            this.labelInputText.TabIndex = 10;
            this.labelInputText.Text = "Input Surname :";
            // 
            // SurnameSorterTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(832, 327);
            this.ControlBox = false;
            this.Controls.Add(this.labelInputText);
            this.Controls.Add(this.labelFormedList);
            this.Controls.Add(this.labelFileList);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonFillList);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAddSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxFSL);
            this.Controls.Add(this.textBoxSL);
            this.Name = "SurnameSorterTask";
            this.Text = "Surname Sorter Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox textBoxSL;
        private System.Windows.Forms.TextBox textBoxFSL;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button buttonAddSurname;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFillList;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelFileList;
        private System.Windows.Forms.Label labelFormedList;
        private System.Windows.Forms.Label labelInputText;
    }
}

