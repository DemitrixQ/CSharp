namespace XYSorter_Solution
{
    partial class SorterSolution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxFirstPoints = new System.Windows.Forms.TextBox();
            this.textBoxSortedPoints = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelUPoints = new System.Windows.Forms.Label();
            this.labelSortedPoints = new System.Windows.Forms.Label();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.textBoxTestResult = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonIncr = new System.Windows.Forms.RadioButton();
            this.radioButtonDecr = new System.Windows.Forms.RadioButton();
            this.buttonGet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxTested = new System.Windows.Forms.TextBox();
            this.textBoxInputed = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelg = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonGetFromFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGetMassive = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGetRows = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstPoints
            // 
            this.textBoxFirstPoints.Location = new System.Drawing.Point(290, 177);
            this.textBoxFirstPoints.Multiline = true;
            this.textBoxFirstPoints.Name = "textBoxFirstPoints";
            this.textBoxFirstPoints.Size = new System.Drawing.Size(85, 290);
            this.textBoxFirstPoints.TabIndex = 0;
            // 
            // textBoxSortedPoints
            // 
            this.textBoxSortedPoints.Location = new System.Drawing.Point(883, 177);
            this.textBoxSortedPoints.Multiline = true;
            this.textBoxSortedPoints.Name = "textBoxSortedPoints";
            this.textBoxSortedPoints.Size = new System.Drawing.Size(83, 290);
            this.textBoxSortedPoints.TabIndex = 1;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelInput.Location = new System.Drawing.Point(12, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(272, 34);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "1. Input name and number.\r\n2. Press Enter Key Or Get Number Button";
            // 
            // labelUPoints
            // 
            this.labelUPoints.AutoSize = true;
            this.labelUPoints.Location = new System.Drawing.Point(287, 160);
            this.labelUPoints.Name = "labelUPoints";
            this.labelUPoints.Size = new System.Drawing.Size(98, 13);
            this.labelUPoints.TabIndex = 4;
            this.labelUPoints.Text = "Unsorted Massive :";
            // 
            // labelSortedPoints
            // 
            this.labelSortedPoints.AutoSize = true;
            this.labelSortedPoints.Location = new System.Drawing.Point(880, 161);
            this.labelSortedPoints.Name = "labelSortedPoints";
            this.labelSortedPoints.Size = new System.Drawing.Size(86, 13);
            this.labelSortedPoints.TabIndex = 5;
            this.labelSortedPoints.Text = "Sorted Massive :";
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(334, 680);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(205, 20);
            this.textBoxTest.TabIndex = 6;
            this.textBoxTest.Text = "Author : Rudin Pavel";
            // 
            // textBoxTestResult
            // 
            this.textBoxTestResult.Location = new System.Drawing.Point(576, 680);
            this.textBoxTestResult.Name = "textBoxTestResult";
            this.textBoxTestResult.Size = new System.Drawing.Size(230, 20);
            this.textBoxTestResult.TabIndex = 7;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(3, 177);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(255, 50);
            this.buttonSort.TabIndex = 9;
            this.buttonSort.Text = "Sort Massive";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(51, 280);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(153, 41);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonIncr);
            this.groupBox.Controls.Add(this.radioButtonDecr);
            this.groupBox.Location = new System.Drawing.Point(105, 548);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(243, 85);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            // 
            // radioButtonIncr
            // 
            this.radioButtonIncr.AutoSize = true;
            this.radioButtonIncr.Checked = true;
            this.radioButtonIncr.Location = new System.Drawing.Point(20, 19);
            this.radioButtonIncr.Name = "radioButtonIncr";
            this.radioButtonIncr.Size = new System.Drawing.Size(102, 17);
            this.radioButtonIncr.TabIndex = 12;
            this.radioButtonIncr.TabStop = true;
            this.radioButtonIncr.Text = "Sort by Increase";
            this.radioButtonIncr.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecr
            // 
            this.radioButtonDecr.AutoSize = true;
            this.radioButtonDecr.Location = new System.Drawing.Point(20, 49);
            this.radioButtonDecr.Name = "radioButtonDecr";
            this.radioButtonDecr.Size = new System.Drawing.Size(107, 17);
            this.radioButtonDecr.TabIndex = 13;
            this.radioButtonDecr.Text = "Sort by Decrease";
            this.radioButtonDecr.UseVisualStyleBackColor = true;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(290, 52);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(243, 29);
            this.buttonGet.TabIndex = 13;
            this.buttonGet.Text = "Get Element";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // textBoxTested
            // 
            this.textBoxTested.Location = new System.Drawing.Point(331, 704);
            this.textBoxTested.Name = "textBoxTested";
            this.textBoxTested.Size = new System.Drawing.Size(100, 20);
            this.textBoxTested.TabIndex = 16;
            // 
            // textBoxInputed
            // 
            this.textBoxInputed.Location = new System.Drawing.Point(363, 12);
            this.textBoxInputed.Name = "textBoxInputed";
            this.textBoxInputed.Size = new System.Drawing.Size(161, 20);
            this.textBoxInputed.TabIndex = 17;
            this.textBoxInputed.Text = "24";
            this.textBoxInputed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInputed_MouseClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(290, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(67, 20);
            this.textBoxName.TabIndex = 18;
            this.textBoxName.Text = "a";
            this.textBoxName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseClick_1);
            // 
            // panelg
            // 
            this.panelg.BackColor = System.Drawing.SystemColors.Window;
            this.panelg.Location = new System.Drawing.Point(415, 177);
            this.panelg.Name = "panelg";
            this.panelg.Size = new System.Drawing.Size(280, 290);
            this.panelg.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(728, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 290);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Compare with auxiliary massive\'s :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sorted Visual Massive :";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(3, 233);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(255, 41);
            this.buttonClean.TabIndex = 25;
            this.buttonClean.Text = "Clean Massive ";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonGetFromFile
            // 
            this.buttonGetFromFile.Location = new System.Drawing.Point(290, 87);
            this.buttonGetFromFile.Name = "buttonGetFromFile";
            this.buttonGetFromFile.Size = new System.Drawing.Size(243, 36);
            this.buttonGetFromFile.TabIndex = 26;
            this.buttonGetFromFile.Text = "Get ELements From File";
            this.buttonGetFromFile.UseVisualStyleBackColor = true;
            this.buttonGetFromFile.Click += new System.EventHandler(this.buttonGetFromFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnChar,
            this.ColumnNumber});
            this.dataGridView1.Location = new System.Drawing.Point(554, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 111);
            this.dataGridView1.TabIndex = 27;
            // 
            // ColumnChar
            // 
            this.ColumnChar.HeaderText = "Char";
            this.ColumnChar.Name = "ColumnChar";
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "Number";
            this.ColumnNumber.Name = "ColumnNumber";
            // 
            // buttonGetMassive
            // 
            this.buttonGetMassive.Location = new System.Drawing.Point(911, 28);
            this.buttonGetMassive.Name = "buttonGetMassive";
            this.buttonGetMassive.Size = new System.Drawing.Size(97, 95);
            this.buttonGetMassive.TabIndex = 28;
            this.buttonGetMassive.Text = "Get Massive From Matrix";
            this.buttonGetMassive.UseVisualStyleBackColor = true;
            this.buttonGetMassive.Click += new System.EventHandler(this.buttonGetMassive_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(809, 87);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(99, 36);
            this.buttonRandom.TabIndex = 29;
            this.buttonRandom.Text = "Randomize";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(809, 28);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(99, 20);
            this.textBoxRows.TabIndex = 30;
            this.textBoxRows.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Set Elements Count :";
            // 
            // buttonGetRows
            // 
            this.buttonGetRows.Location = new System.Drawing.Point(809, 52);
            this.buttonGetRows.Name = "buttonGetRows";
            this.buttonGetRows.Size = new System.Drawing.Size(99, 29);
            this.buttonGetRows.TabIndex = 32;
            this.buttonGetRows.Text = "Set Rows";
            this.buttonGetRows.UseVisualStyleBackColor = true;
            this.buttonGetRows.Click += new System.EventHandler(this.buttonGetRows_Click);
            // 
            // SorterSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(1020, 489);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGetRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRows);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonGetMassive);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGetFromFile);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelg);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxInputed);
            this.Controls.Add(this.textBoxTested);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxTestResult);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.labelSortedPoints);
            this.Controls.Add(this.labelUPoints);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxSortedPoints);
            this.Controls.Add(this.textBoxFirstPoints);
            this.Name = "SorterSolution";
            this.Text = "Solution";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstPoints;
        private System.Windows.Forms.TextBox textBoxSortedPoints;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelUPoints;
        private System.Windows.Forms.Label labelSortedPoints;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.TextBox textBoxTestResult;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonIncr;
        private System.Windows.Forms.RadioButton radioButtonDecr;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxTested;
        private System.Windows.Forms.TextBox textBoxInputed;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panelg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonGetFromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGetMassive;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGetRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
    }
}

