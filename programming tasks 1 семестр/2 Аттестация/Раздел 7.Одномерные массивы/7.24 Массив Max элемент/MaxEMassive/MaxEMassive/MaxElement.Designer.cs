namespace MaxEMassive
{
    partial class MaxElement
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
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxMaxElement = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.buttonRunApplication = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelInputRow = new System.Windows.Forms.Label();
            this.labelMaxElement = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.dataGridViewMassive = new System.Windows.Forms.DataGridView();
            this.buttonSetRowsCollums = new System.Windows.Forms.Button();
            this.labelInputColums = new System.Windows.Forms.Label();
            this.textBoxCollums = new System.Windows.Forms.TextBox();
            this.buttonFillMassive = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMassive)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(118, 19);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxRows.TabIndex = 0;
            this.textBoxRows.Text = "9";
            // 
            // textBoxMaxElement
            // 
            this.textBoxMaxElement.Location = new System.Drawing.Point(12, 237);
            this.textBoxMaxElement.Name = "textBoxMaxElement";
            this.textBoxMaxElement.ReadOnly = true;
            this.textBoxMaxElement.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxElement.TabIndex = 1;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(118, 237);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition.TabIndex = 2;
            // 
            // buttonRunApplication
            // 
            this.buttonRunApplication.Location = new System.Drawing.Point(12, 177);
            this.buttonRunApplication.Name = "buttonRunApplication";
            this.buttonRunApplication.Size = new System.Drawing.Size(100, 23);
            this.buttonRunApplication.TabIndex = 3;
            this.buttonRunApplication.Text = "Search [MAX]";
            this.buttonRunApplication.UseVisualStyleBackColor = true;
            this.buttonRunApplication.Click += new System.EventHandler(this.buttonRunApplication_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(593, 267);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelInputRow
            // 
            this.labelInputRow.AutoSize = true;
            this.labelInputRow.Location = new System.Drawing.Point(9, 22);
            this.labelInputRow.Name = "labelInputRow";
            this.labelInputRow.Size = new System.Drawing.Size(93, 13);
            this.labelInputRow.TabIndex = 5;
            this.labelInputRow.Text = "Input Table Row\'s";
            // 
            // labelMaxElement
            // 
            this.labelMaxElement.AutoSize = true;
            this.labelMaxElement.Location = new System.Drawing.Point(24, 221);
            this.labelMaxElement.Name = "labelMaxElement";
            this.labelMaxElement.Size = new System.Drawing.Size(71, 13);
            this.labelMaxElement.TabIndex = 6;
            this.labelMaxElement.Text = "Max. Element";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(149, 221);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(44, 13);
            this.labelCounter.TabIndex = 7;
            this.labelCounter.Text = "Position";
            // 
            // dataGridViewMassive
            // 
            this.dataGridViewMassive.AllowUserToAddRows = false;
            this.dataGridViewMassive.AllowUserToDeleteRows = false;
            this.dataGridViewMassive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMassive.Location = new System.Drawing.Point(246, 22);
            this.dataGridViewMassive.Name = "dataGridViewMassive";
            this.dataGridViewMassive.Size = new System.Drawing.Size(447, 235);
            this.dataGridViewMassive.TabIndex = 8;
            // 
            // buttonSetRowsCollums
            // 
            this.buttonSetRowsCollums.Location = new System.Drawing.Point(12, 86);
            this.buttonSetRowsCollums.Name = "buttonSetRowsCollums";
            this.buttonSetRowsCollums.Size = new System.Drawing.Size(206, 23);
            this.buttonSetRowsCollums.TabIndex = 9;
            this.buttonSetRowsCollums.Text = "Set Rows and Collums";
            this.buttonSetRowsCollums.UseVisualStyleBackColor = true;
            this.buttonSetRowsCollums.Click += new System.EventHandler(this.buttonSetRows_Click);
            // 
            // labelInputColums
            // 
            this.labelInputColums.AutoSize = true;
            this.labelInputColums.Location = new System.Drawing.Point(9, 51);
            this.labelInputColums.Name = "labelInputColums";
            this.labelInputColums.Size = new System.Drawing.Size(102, 13);
            this.labelInputColums.TabIndex = 10;
            this.labelInputColums.Text = "Input Table Collum\'s";
            // 
            // textBoxCollums
            // 
            this.textBoxCollums.Location = new System.Drawing.Point(118, 51);
            this.textBoxCollums.Name = "textBoxCollums";
            this.textBoxCollums.Size = new System.Drawing.Size(100, 20);
            this.textBoxCollums.TabIndex = 11;
            this.textBoxCollums.Text = "1";
            // 
            // buttonFillMassive
            // 
            this.buttonFillMassive.Location = new System.Drawing.Point(12, 115);
            this.buttonFillMassive.Name = "buttonFillMassive";
            this.buttonFillMassive.Size = new System.Drawing.Size(206, 44);
            this.buttonFillMassive.TabIndex = 12;
            this.buttonFillMassive.Text = "Fill Massive";
            this.buttonFillMassive.UseVisualStyleBackColor = true;
            this.buttonFillMassive.Click += new System.EventHandler(this.buttonFillMassive_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(118, 177);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(100, 23);
            this.buttonClean.TabIndex = 13;
            this.buttonClean.Text = "Clean Table";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // MaxElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(694, 294);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonFillMassive);
            this.Controls.Add(this.textBoxCollums);
            this.Controls.Add(this.labelInputColums);
            this.Controls.Add(this.buttonSetRowsCollums);
            this.Controls.Add(this.dataGridViewMassive);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.labelMaxElement);
            this.Controls.Add(this.labelInputRow);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRunApplication);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxMaxElement);
            this.Controls.Add(this.textBoxRows);
            this.Name = "MaxElement";
            this.Text = "Maximum Element";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMassive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxMaxElement;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Button buttonRunApplication;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelInputRow;
        private System.Windows.Forms.Label labelMaxElement;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.DataGridView dataGridViewMassive;
        private System.Windows.Forms.Button buttonSetRowsCollums;
        private System.Windows.Forms.Label labelInputColums;
        private System.Windows.Forms.TextBox textBoxCollums;
        private System.Windows.Forms.Button buttonFillMassive;
        private System.Windows.Forms.Button buttonClean;
    }
}

