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
            this.textBoxInputX = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelUPoints = new System.Windows.Forms.Label();
            this.labelSortedPoints = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonIncr = new System.Windows.Forms.RadioButton();
            this.radioButtonDecr = new System.Windows.Forms.RadioButton();
            this.textBoxInputY = new System.Windows.Forms.TextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirstPoints
            // 
            this.textBoxFirstPoints.Location = new System.Drawing.Point(291, 25);
            this.textBoxFirstPoints.Multiline = true;
            this.textBoxFirstPoints.Name = "textBoxFirstPoints";
            this.textBoxFirstPoints.Size = new System.Drawing.Size(205, 401);
            this.textBoxFirstPoints.TabIndex = 0;
            // 
            // textBoxSortedPoints
            // 
            this.textBoxSortedPoints.Location = new System.Drawing.Point(538, 25);
            this.textBoxSortedPoints.Multiline = true;
            this.textBoxSortedPoints.Name = "textBoxSortedPoints";
            this.textBoxSortedPoints.Size = new System.Drawing.Size(230, 401);
            this.textBoxSortedPoints.TabIndex = 1;
            // 
            // textBoxInputX
            // 
            this.textBoxInputX.Location = new System.Drawing.Point(76, 103);
            this.textBoxInputX.Name = "textBoxInputX";
            this.textBoxInputX.Size = new System.Drawing.Size(75, 20);
            this.textBoxInputX.TabIndex = 2;
            this.textBoxInputX.Text = " x =";
            this.textBoxInputX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInput_MouseClick);
            this.textBoxInputX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyUp);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelInput.Location = new System.Drawing.Point(-7, 25);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(254, 51);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "1. Input point name (A,B,C.....)\r\n2. Input point coordinates  X and Y\r\n3. Press E" +
    "nter Key Or Get Point Button";
            // 
            // labelUPoints
            // 
            this.labelUPoints.AutoSize = true;
            this.labelUPoints.Location = new System.Drawing.Point(288, 9);
            this.labelUPoints.Name = "labelUPoints";
            this.labelUPoints.Size = new System.Drawing.Size(88, 13);
            this.labelUPoints.TabIndex = 4;
            this.labelUPoints.Text = "Unsorted Points :";
            // 
            // labelSortedPoints
            // 
            this.labelSortedPoints.AutoSize = true;
            this.labelSortedPoints.Location = new System.Drawing.Point(535, 9);
            this.labelSortedPoints.Name = "labelSortedPoints";
            this.labelSortedPoints.Size = new System.Drawing.Size(76, 13);
            this.labelSortedPoints.TabIndex = 5;
            this.labelSortedPoints.Text = "Sorted Points :";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(4, 275);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(243, 45);
            this.buttonSort.TabIndex = 9;
            this.buttonSort.Text = "Sort Points";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(4, 326);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(243, 39);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonIncr);
            this.groupBox.Controls.Add(this.radioButtonDecr);
            this.groupBox.Location = new System.Drawing.Point(4, 175);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(243, 85);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            // 
            // radioButtonIncr
            // 
            this.radioButtonIncr.AutoSize = true;
            this.radioButtonIncr.Checked = true;
            this.radioButtonIncr.Location = new System.Drawing.Point(20, 26);
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
            // textBoxInputY
            // 
            this.textBoxInputY.Location = new System.Drawing.Point(157, 103);
            this.textBoxInputY.Name = "textBoxInputY";
            this.textBoxInputY.Size = new System.Drawing.Size(90, 20);
            this.textBoxInputY.TabIndex = 12;
            this.textBoxInputY.Text = " y =";
            this.textBoxInputY.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBoxInputY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyUp);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(4, 129);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(243, 40);
            this.buttonGet.TabIndex = 13;
            this.buttonGet.Text = "Get Point";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // textBoxPName
            // 
            this.textBoxPName.Location = new System.Drawing.Point(4, 103);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(66, 20);
            this.textBoxPName.TabIndex = 14;
            this.textBoxPName.Text = "A";
            this.textBoxPName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBoxPName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyUp);
            // 
            // SorterSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 434);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxPName);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.textBoxInputY);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelSortedPoints);
            this.Controls.Add(this.labelUPoints);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInputX);
            this.Controls.Add(this.textBoxSortedPoints);
            this.Controls.Add(this.textBoxFirstPoints);
            this.Name = "SorterSolution";
            this.Text = "Solution";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstPoints;
        private System.Windows.Forms.TextBox textBoxSortedPoints;
        private System.Windows.Forms.TextBox textBoxInputX;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelUPoints;
        private System.Windows.Forms.Label labelSortedPoints;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonIncr;
        private System.Windows.Forms.RadioButton radioButtonDecr;
        private System.Windows.Forms.TextBox textBoxInputY;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.TextBox textBoxPName;
        private System.Windows.Forms.Timer timer1;
    }
}

