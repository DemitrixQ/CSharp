namespace TaskIncreaseDecreaseMonotony
{
    partial class TaskBinary
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
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxDecrease = new System.Windows.Forms.TextBox();
            this.textBoxIncrease = new System.Windows.Forms.TextBox();
            this.textBoxMonotony = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(182, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(252, 35);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search ";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxDecrease
            // 
            this.textBoxDecrease.Location = new System.Drawing.Point(159, 101);
            this.textBoxDecrease.Name = "textBoxDecrease";
            this.textBoxDecrease.ReadOnly = true;
            this.textBoxDecrease.Size = new System.Drawing.Size(123, 20);
            this.textBoxDecrease.TabIndex = 1;
            // 
            // textBoxIncrease
            // 
            this.textBoxIncrease.Location = new System.Drawing.Point(15, 101);
            this.textBoxIncrease.Name = "textBoxIncrease";
            this.textBoxIncrease.ReadOnly = true;
            this.textBoxIncrease.Size = new System.Drawing.Size(112, 20);
            this.textBoxIncrease.TabIndex = 2;
            this.textBoxIncrease.TextChanged += new System.EventHandler(this.textBoxIncrease_TextChanged);
            // 
            // textBoxMonotony
            // 
            this.textBoxMonotony.Location = new System.Drawing.Point(322, 101);
            this.textBoxMonotony.Name = "textBoxMonotony";
            this.textBoxMonotony.ReadOnly = true;
            this.textBoxMonotony.Size = new System.Drawing.Size(112, 20);
            this.textBoxMonotony.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result Increase :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result Decrease :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result Monotony :";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(455, 150);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(146, 29);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(12, 12);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.ReadOnly = true;
            this.textBoxString.Size = new System.Drawing.Size(589, 20);
            this.textBoxString.TabIndex = 9;
            this.textBoxString.Text = "\r\nUser trying to check this file ::  ";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(474, 101);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.ReadOnly = true;
            this.textBoxQuantity.Size = new System.Drawing.Size(127, 20);
            this.textBoxQuantity.TabIndex = 10;
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.Location = new System.Drawing.Point(471, 85);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(104, 13);
            this.labelAll.TabIndex = 11;
            this.labelAll.Text = "Amount of numbers :";
            // 
            // TaskBinary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(609, 187);
            this.ControlBox = false;
            this.Controls.Add(this.labelAll);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMonotony);
            this.Controls.Add(this.textBoxIncrease);
            this.Controls.Add(this.textBoxDecrease);
            this.Controls.Add(this.buttonSearch);
            this.Name = "TaskBinary";
            this.Text = "TaskMonotony";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxDecrease;
        private System.Windows.Forms.TextBox textBoxIncrease;
        private System.Windows.Forms.TextBox textBoxMonotony;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelAll;
    }
}

