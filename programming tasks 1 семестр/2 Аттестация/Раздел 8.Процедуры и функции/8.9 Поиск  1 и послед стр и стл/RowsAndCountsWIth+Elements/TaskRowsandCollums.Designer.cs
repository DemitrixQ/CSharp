namespace RowsAndCountsWIth_Elements
{
    partial class TaskRowsandCollums
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
            this.buttonGetRowsAndCollums = new System.Windows.Forms.Button();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelInputCollums = new System.Windows.Forms.Label();
            this.textBoxInputRows = new System.Windows.Forms.TextBox();
            this.textBoxInputCollums = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonFillMassive = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxMinElement = new System.Windows.Forms.TextBox();
            this.textBoxMaxElement = new System.Windows.Forms.TextBox();
            this.labelMinElement = new System.Windows.Forms.Label();
            this.labelMaxElement = new System.Windows.Forms.Label();
            this.buttonGetRange = new System.Windows.Forms.Button();
            this.radioButtonFirst = new System.Windows.Forms.RadioButton();
            this.radioButtonLast = new System.Windows.Forms.RadioButton();
            this.radioButtonRow = new System.Windows.Forms.RadioButton();
            this.radioButtonColumn = new System.Windows.Forms.RadioButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.groupBoxGridElement = new System.Windows.Forms.GroupBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxPosition.SuspendLayout();
            this.groupBoxGridElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetRowsAndCollums
            // 
            this.buttonGetRowsAndCollums.Location = new System.Drawing.Point(460, 58);
            this.buttonGetRowsAndCollums.Name = "buttonGetRowsAndCollums";
            this.buttonGetRowsAndCollums.Size = new System.Drawing.Size(303, 54);
            this.buttonGetRowsAndCollums.TabIndex = 0;
            this.buttonGetRowsAndCollums.Text = "Get Rows and Collums";
            this.buttonGetRowsAndCollums.UseVisualStyleBackColor = true;
            this.buttonGetRowsAndCollums.Click += new System.EventHandler(this.buttonGetRowsAndCollums_Click);
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRows.Location = new System.Drawing.Point(459, 9);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(113, 20);
            this.labelRows.TabIndex = 2;
            this.labelRows.Text = "Input Rows (n)";
            // 
            // labelInputCollums
            // 
            this.labelInputCollums.AutoSize = true;
            this.labelInputCollums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInputCollums.Location = new System.Drawing.Point(630, 9);
            this.labelInputCollums.Name = "labelInputCollums";
            this.labelInputCollums.Size = new System.Drawing.Size(133, 20);
            this.labelInputCollums.TabIndex = 3;
            this.labelInputCollums.Text = "Input Collums (m)";
            // 
            // textBoxInputRows
            // 
            this.textBoxInputRows.Location = new System.Drawing.Point(460, 32);
            this.textBoxInputRows.Name = "textBoxInputRows";
            this.textBoxInputRows.Size = new System.Drawing.Size(149, 20);
            this.textBoxInputRows.TabIndex = 4;
            this.textBoxInputRows.Text = "5";
            // 
            // textBoxInputCollums
            // 
            this.textBoxInputCollums.Location = new System.Drawing.Point(618, 32);
            this.textBoxInputCollums.Name = "textBoxInputCollums";
            this.textBoxInputCollums.Size = new System.Drawing.Size(145, 20);
            this.textBoxInputCollums.TabIndex = 5;
            this.textBoxInputCollums.Text = "5";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, -3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(442, 325);
            this.dataGridView.TabIndex = 6;
            // 
            // buttonFillMassive
            // 
            this.buttonFillMassive.Location = new System.Drawing.Point(459, 220);
            this.buttonFillMassive.Name = "buttonFillMassive";
            this.buttonFillMassive.Size = new System.Drawing.Size(304, 46);
            this.buttonFillMassive.TabIndex = 7;
            this.buttonFillMassive.Text = "Fill Massive";
            this.buttonFillMassive.UseVisualStyleBackColor = true;
            this.buttonFillMassive.Click += new System.EventHandler(this.buttonFillMassive_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(617, 482);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(146, 33);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMinElement
            // 
            this.textBoxMinElement.Location = new System.Drawing.Point(460, 143);
            this.textBoxMinElement.Name = "textBoxMinElement";
            this.textBoxMinElement.Size = new System.Drawing.Size(149, 20);
            this.textBoxMinElement.TabIndex = 10;
            this.textBoxMinElement.Text = "-3";
            // 
            // textBoxMaxElement
            // 
            this.textBoxMaxElement.Location = new System.Drawing.Point(618, 143);
            this.textBoxMaxElement.Name = "textBoxMaxElement";
            this.textBoxMaxElement.Size = new System.Drawing.Size(145, 20);
            this.textBoxMaxElement.TabIndex = 11;
            this.textBoxMaxElement.Text = "11";
            // 
            // labelMinElement
            // 
            this.labelMinElement.AutoSize = true;
            this.labelMinElement.Location = new System.Drawing.Point(460, 127);
            this.labelMinElement.Name = "labelMinElement";
            this.labelMinElement.Size = new System.Drawing.Size(127, 13);
            this.labelMinElement.TabIndex = 12;
            this.labelMinElement.Text = "Input Range Min Element";
            // 
            // labelMaxElement
            // 
            this.labelMaxElement.AutoSize = true;
            this.labelMaxElement.Location = new System.Drawing.Point(615, 127);
            this.labelMaxElement.Name = "labelMaxElement";
            this.labelMaxElement.Size = new System.Drawing.Size(130, 13);
            this.labelMaxElement.TabIndex = 13;
            this.labelMaxElement.Text = "Input Range Max Element";
            // 
            // buttonGetRange
            // 
            this.buttonGetRange.Location = new System.Drawing.Point(459, 169);
            this.buttonGetRange.Name = "buttonGetRange";
            this.buttonGetRange.Size = new System.Drawing.Size(304, 45);
            this.buttonGetRange.TabIndex = 14;
            this.buttonGetRange.Text = "Get Range for Random";
            this.buttonGetRange.UseVisualStyleBackColor = true;
            this.buttonGetRange.Click += new System.EventHandler(this.buttonGetRange_Click);
            // 
            // radioButtonFirst
            // 
            this.radioButtonFirst.AutoSize = true;
            this.radioButtonFirst.Checked = true;
            this.radioButtonFirst.Location = new System.Drawing.Point(19, 29);
            this.radioButtonFirst.Name = "radioButtonFirst";
            this.radioButtonFirst.Size = new System.Drawing.Size(44, 17);
            this.radioButtonFirst.TabIndex = 15;
            this.radioButtonFirst.TabStop = true;
            this.radioButtonFirst.Text = "First";
            this.radioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // radioButtonLast
            // 
            this.radioButtonLast.AutoSize = true;
            this.radioButtonLast.Location = new System.Drawing.Point(19, 52);
            this.radioButtonLast.Name = "radioButtonLast";
            this.radioButtonLast.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLast.TabIndex = 16;
            this.radioButtonLast.Text = "Last";
            this.radioButtonLast.UseVisualStyleBackColor = true;
            // 
            // radioButtonRow
            // 
            this.radioButtonRow.AutoSize = true;
            this.radioButtonRow.Checked = true;
            this.radioButtonRow.Location = new System.Drawing.Point(7, 29);
            this.radioButtonRow.Name = "radioButtonRow";
            this.radioButtonRow.Size = new System.Drawing.Size(157, 17);
            this.radioButtonRow.TabIndex = 17;
            this.radioButtonRow.TabStop = true;
            this.radioButtonRow.Text = "Row With Positive Numbers";
            this.radioButtonRow.UseVisualStyleBackColor = true;
            // 
            // radioButtonColumn
            // 
            this.radioButtonColumn.AutoSize = true;
            this.radioButtonColumn.Location = new System.Drawing.Point(7, 57);
            this.radioButtonColumn.Name = "radioButtonColumn";
            this.radioButtonColumn.Size = new System.Drawing.Size(170, 17);
            this.radioButtonColumn.TabIndex = 18;
            this.radioButtonColumn.Text = "Column With Positive Numbers";
            this.radioButtonColumn.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 418);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(329, 44);
            this.textBoxResult.TabIndex = 19;
            this.textBoxResult.Text = "Result Of Search :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(347, 334);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 78);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Search Target Element";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.radioButtonFirst);
            this.groupBoxPosition.Controls.Add(this.radioButtonLast);
            this.groupBoxPosition.Location = new System.Drawing.Point(12, 328);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(88, 84);
            this.groupBoxPosition.TabIndex = 21;
            this.groupBoxPosition.TabStop = false;
            // 
            // groupBoxGridElement
            // 
            this.groupBoxGridElement.Controls.Add(this.radioButtonRow);
            this.groupBoxGridElement.Controls.Add(this.radioButtonColumn);
            this.groupBoxGridElement.Location = new System.Drawing.Point(106, 328);
            this.groupBoxGridElement.Name = "groupBoxGridElement";
            this.groupBoxGridElement.Size = new System.Drawing.Size(235, 84);
            this.groupBoxGridElement.TabIndex = 17;
            this.groupBoxGridElement.TabStop = false;
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(459, 272);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(304, 50);
            this.buttonClean.TabIndex = 22;
            this.buttonClean.Text = "Clean Massive";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clean Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_CleanWind);
            // 
            // TaskRowsandCollums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(776, 523);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.groupBoxGridElement);
            this.Controls.Add(this.groupBoxPosition);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonGetRange);
            this.Controls.Add(this.labelMaxElement);
            this.Controls.Add(this.labelMinElement);
            this.Controls.Add(this.textBoxMaxElement);
            this.Controls.Add(this.textBoxMinElement);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonFillMassive);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxInputCollums);
            this.Controls.Add(this.textBoxInputRows);
            this.Controls.Add(this.labelInputCollums);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.buttonGetRowsAndCollums);
            this.Name = "TaskRowsandCollums";
            this.Text = "Task Rows and Collums";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxPosition.PerformLayout();
            this.groupBoxGridElement.ResumeLayout(false);
            this.groupBoxGridElement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetRowsAndCollums;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelInputCollums;
        private System.Windows.Forms.TextBox textBoxInputRows;
        private System.Windows.Forms.TextBox textBoxInputCollums;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonFillMassive;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxMinElement;
        private System.Windows.Forms.TextBox textBoxMaxElement;
        private System.Windows.Forms.Label labelMinElement;
        private System.Windows.Forms.Label labelMaxElement;
        private System.Windows.Forms.Button buttonGetRange;
        private System.Windows.Forms.RadioButton radioButtonFirst;
        private System.Windows.Forms.RadioButton radioButtonLast;
        private System.Windows.Forms.RadioButton radioButtonRow;
        private System.Windows.Forms.RadioButton radioButtonColumn;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.GroupBox groupBoxGridElement;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button button1;
    }
}

