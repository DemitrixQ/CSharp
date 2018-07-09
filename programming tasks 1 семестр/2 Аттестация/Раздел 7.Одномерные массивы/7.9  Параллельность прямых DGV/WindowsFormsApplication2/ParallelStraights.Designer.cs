namespace WindowsFormsApplication2
{
    partial class ParallelStraights
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelForms = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.dataGridViewLines = new System.Windows.Forms.DataGridView();
            this.FactorA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxLinesNumber = new System.Windows.Forms.TextBox();
            this.buttonGetLines = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLines)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(264, 93);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(126, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Find Parallel Straights";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(435, 280);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(264, 144);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(240, 124);
            this.textBoxResult.TabIndex = 2;
            // 
            // labelForms
            // 
            this.labelForms.AutoSize = true;
            this.labelForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelForms.Location = new System.Drawing.Point(126, 9);
            this.labelForms.Name = "labelForms";
            this.labelForms.Size = new System.Drawing.Size(238, 20);
            this.labelForms.TabIndex = 3;
            this.labelForms.Text = "Straights Factors :   a*x+b*y=c";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(261, 128);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(43, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Result :";
            // 
            // dataGridViewLines
            // 
            this.dataGridViewLines.AllowUserToAddRows = false;
            this.dataGridViewLines.AllowUserToDeleteRows = false;
            this.dataGridViewLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FactorA,
            this.FactorB,
            this.FactorC});
            this.dataGridViewLines.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewLines.Name = "dataGridViewLines";
            this.dataGridViewLines.Size = new System.Drawing.Size(229, 253);
            this.dataGridViewLines.TabIndex = 11;
            // 
            // FactorA
            // 
            this.FactorA.HeaderText = "Factor A";
            this.FactorA.Name = "FactorA";
            this.FactorA.Width = 50;
            // 
            // FactorB
            // 
            this.FactorB.HeaderText = "Factor B";
            this.FactorB.Name = "FactorB";
            this.FactorB.Width = 50;
            // 
            // FactorC
            // 
            this.FactorC.HeaderText = "Factor C";
            this.FactorC.Name = "FactorC";
            this.FactorC.Width = 50;
            // 
            // textBoxLinesNumber
            // 
            this.textBoxLinesNumber.Location = new System.Drawing.Point(264, 38);
            this.textBoxLinesNumber.Name = "textBoxLinesNumber";
            this.textBoxLinesNumber.Size = new System.Drawing.Size(231, 20);
            this.textBoxLinesNumber.TabIndex = 12;
            this.textBoxLinesNumber.Text = "5";
            // 
            // buttonGetLines
            // 
            this.buttonGetLines.Location = new System.Drawing.Point(264, 64);
            this.buttonGetLines.Name = "buttonGetLines";
            this.buttonGetLines.Size = new System.Drawing.Size(231, 23);
            this.buttonGetLines.TabIndex = 13;
            this.buttonGetLines.Text = "Get Lines Number";
            this.buttonGetLines.UseVisualStyleBackColor = true;
            this.buttonGetLines.Click += new System.EventHandler(this.buttonGetLines_Click);
            // 
            // ParallelStraights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(522, 315);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGetLines);
            this.Controls.Add(this.textBoxLinesNumber);
            this.Controls.Add(this.dataGridViewLines);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelForms);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRun);
            this.Name = "ParallelStraights";
            this.Text = "Parallel Straights";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelForms;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.DataGridView dataGridViewLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorB;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorC;
        private System.Windows.Forms.TextBox textBoxLinesNumber;
        private System.Windows.Forms.Button buttonGetLines;
    }
}

