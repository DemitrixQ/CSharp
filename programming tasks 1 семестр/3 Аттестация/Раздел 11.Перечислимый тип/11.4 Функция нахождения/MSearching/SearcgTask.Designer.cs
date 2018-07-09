namespace WindowsFormsSearching
{
    partial class SearchTask
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnFactorA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnFactorB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFactorC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFormRows = new System.Windows.Forms.Button();
            this.labelInputQuantity = new System.Windows.Forms.Label();
            this.textBoxQuanityofNumbers = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelMinimumNumber = new System.Windows.Forms.Label();
            this.buttonFindMinimumNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMathPow = new System.Windows.Forms.TextBox();
            this.buttonFindMaximumNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonFindMaxOrder = new System.Windows.Forms.Button();
            this.textBoxMaximumOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeight = 20;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFactorA,
            this.ColumnFactorB,
            this.ColumnFactorC});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 65;
            this.dataGridView.Size = new System.Drawing.Size(371, 250);
            this.dataGridView.TabIndex = 1;
            // 
            // ColumnFactorA
            // 
            this.ColumnFactorA.HeaderText = "+ / -";
            this.ColumnFactorA.Name = "ColumnFactorA";
            this.ColumnFactorA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFactorA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnFactorB
            // 
            this.ColumnFactorB.HeaderText = "Mantissa";
            this.ColumnFactorB.Name = "ColumnFactorB";
            // 
            // ColumnFactorC
            // 
            this.ColumnFactorC.HeaderText = "Order";
            this.ColumnFactorC.Name = "ColumnFactorC";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(457, 298);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(128, 42);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFormRows
            // 
            this.buttonFormRows.Location = new System.Drawing.Point(389, 54);
            this.buttonFormRows.Name = "buttonFormRows";
            this.buttonFormRows.Size = new System.Drawing.Size(198, 68);
            this.buttonFormRows.TabIndex = 3;
            this.buttonFormRows.Text = "Form Rows";
            this.buttonFormRows.UseVisualStyleBackColor = true;
            this.buttonFormRows.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInputQuantity
            // 
            this.labelInputQuantity.AutoSize = true;
            this.labelInputQuantity.Location = new System.Drawing.Point(389, 12);
            this.labelInputQuantity.Name = "labelInputQuantity";
            this.labelInputQuantity.Size = new System.Drawing.Size(136, 13);
            this.labelInputQuantity.TabIndex = 4;
            this.labelInputQuantity.Text = "Input Quantity of Numbers :";
            // 
            // textBoxQuanityofNumbers
            // 
            this.textBoxQuanityofNumbers.Location = new System.Drawing.Point(387, 28);
            this.textBoxQuanityofNumbers.Name = "textBoxQuanityofNumbers";
            this.textBoxQuanityofNumbers.Size = new System.Drawing.Size(198, 20);
            this.textBoxQuanityofNumbers.TabIndex = 5;
            this.textBoxQuanityofNumbers.Text = "6";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(501, 194);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(86, 20);
            this.textBoxResult.TabIndex = 6;
            // 
            // labelMinimumNumber
            // 
            this.labelMinimumNumber.AutoSize = true;
            this.labelMinimumNumber.Location = new System.Drawing.Point(498, 128);
            this.labelMinimumNumber.Name = "labelMinimumNumber";
            this.labelMinimumNumber.Size = new System.Drawing.Size(94, 13);
            this.labelMinimumNumber.TabIndex = 7;
            this.labelMinimumNumber.Text = "Minimum Number :";
            // 
            // buttonFindMinimumNumber
            // 
            this.buttonFindMinimumNumber.Location = new System.Drawing.Point(389, 178);
            this.buttonFindMinimumNumber.Name = "buttonFindMinimumNumber";
            this.buttonFindMinimumNumber.Size = new System.Drawing.Size(106, 39);
            this.buttonFindMinimumNumber.TabIndex = 8;
            this.buttonFindMinimumNumber.Text = "Find Maximum Number";
            this.buttonFindMinimumNumber.UseVisualStyleBackColor = true;
            this.buttonFindMinimumNumber.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Основание системы счисления";
            // 
            // textBoxMathPow
            // 
            this.textBoxMathPow.Location = new System.Drawing.Point(182, 276);
            this.textBoxMathPow.Name = "textBoxMathPow";
            this.textBoxMathPow.Size = new System.Drawing.Size(46, 20);
            this.textBoxMathPow.TabIndex = 10;
            this.textBoxMathPow.Text = "10";
            // 
            // buttonFindMaximumNumber
            // 
            this.buttonFindMaximumNumber.Location = new System.Drawing.Point(389, 128);
            this.buttonFindMaximumNumber.Name = "buttonFindMaximumNumber";
            this.buttonFindMaximumNumber.Size = new System.Drawing.Size(106, 44);
            this.buttonFindMaximumNumber.TabIndex = 11;
            this.buttonFindMaximumNumber.Text = "Find Minimum Number";
            this.buttonFindMaximumNumber.UseVisualStyleBackColor = true;
            this.buttonFindMaximumNumber.Click += new System.EventHandler(this.buttonFindMaximumNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maximum Number :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(501, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 13;
            // 
            // buttonFindMaxOrder
            // 
            this.buttonFindMaxOrder.Location = new System.Drawing.Point(389, 223);
            this.buttonFindMaxOrder.Name = "buttonFindMaxOrder";
            this.buttonFindMaxOrder.Size = new System.Drawing.Size(106, 39);
            this.buttonFindMaxOrder.TabIndex = 15;
            this.buttonFindMaxOrder.Text = "Find Maximum Order";
            this.buttonFindMaxOrder.UseVisualStyleBackColor = true;
            this.buttonFindMaxOrder.Click += new System.EventHandler(this.buttonFindMaxOrder_Click);
            // 
            // textBoxMaximumOrder
            // 
            this.textBoxMaximumOrder.Location = new System.Drawing.Point(501, 242);
            this.textBoxMaximumOrder.Name = "textBoxMaximumOrder";
            this.textBoxMaximumOrder.ReadOnly = true;
            this.textBoxMaximumOrder.Size = new System.Drawing.Size(86, 20);
            this.textBoxMaximumOrder.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Maximum Order :";
            // 
            // SearchTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(597, 352);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaximumOrder);
            this.Controls.Add(this.buttonFindMaxOrder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFindMaximumNumber);
            this.Controls.Add(this.textBoxMathPow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFindMinimumNumber);
            this.Controls.Add(this.labelMinimumNumber);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxQuanityofNumbers);
            this.Controls.Add(this.labelInputQuantity);
            this.Controls.Add(this.buttonFormRows);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridView);
            this.Name = "SearchTask";
            this.Text = "Search Task";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFormRows;
        private System.Windows.Forms.Label labelInputQuantity;
        private System.Windows.Forms.TextBox textBoxQuanityofNumbers;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelMinimumNumber;
        private System.Windows.Forms.Button buttonFindMinimumNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMathPow;
        private System.Windows.Forms.Button buttonFindMaximumNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnFactorA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFactorB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFactorC;
        private System.Windows.Forms.Button buttonFindMaxOrder;
        private System.Windows.Forms.TextBox textBoxMaximumOrder;
        private System.Windows.Forms.Label label3;
    }
}

