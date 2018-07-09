namespace RowsAndCountsWIth_Elements
{
    partial class TaskMainDiagonal
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
            this.buttonGetMatrixOrder = new System.Windows.Forms.Button();
            this.labelOrder = new System.Windows.Forms.Label();
            this.textBoxInputOrder = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonFillMassive = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxMinElement = new System.Windows.Forms.TextBox();
            this.textBoxMaxElement = new System.Windows.Forms.TextBox();
            this.labelMinElement = new System.Windows.Forms.Label();
            this.labelMaxElement = new System.Windows.Forms.Label();
            this.buttonReplaceElements = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.radioLRDiagonal = new System.Windows.Forms.RadioButton();
            this.radioRLDiagonal = new System.Windows.Forms.RadioButton();
            this.labelDiagonalType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetMatrixOrder
            // 
            this.buttonGetMatrixOrder.Location = new System.Drawing.Point(460, 58);
            this.buttonGetMatrixOrder.Name = "buttonGetMatrixOrder";
            this.buttonGetMatrixOrder.Size = new System.Drawing.Size(302, 37);
            this.buttonGetMatrixOrder.TabIndex = 0;
            this.buttonGetMatrixOrder.Text = "Get Matrix Order";
            this.buttonGetMatrixOrder.UseVisualStyleBackColor = true;
            this.buttonGetMatrixOrder.Click += new System.EventHandler(this.buttonGetRowsAndCollums_Click);
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOrder.Location = new System.Drawing.Point(467, 12);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(286, 17);
            this.labelOrder.TabIndex = 2;
            this.labelOrder.Text = "Input Matrix Order  = Matrix Diagonal Length";
            // 
            // textBoxInputOrder
            // 
            this.textBoxInputOrder.Location = new System.Drawing.Point(460, 32);
            this.textBoxInputOrder.Name = "textBoxInputOrder";
            this.textBoxInputOrder.Size = new System.Drawing.Size(304, 20);
            this.textBoxInputOrder.TabIndex = 4;
            this.textBoxInputOrder.Text = "8";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(428, 292);
            this.dataGridView.TabIndex = 6;
            // 
            // buttonFillMassive
            // 
            this.buttonFillMassive.Location = new System.Drawing.Point(460, 140);
            this.buttonFillMassive.Name = "buttonFillMassive";
            this.buttonFillMassive.Size = new System.Drawing.Size(302, 38);
            this.buttonFillMassive.TabIndex = 7;
            this.buttonFillMassive.Text = "Fill Massive";
            this.buttonFillMassive.UseVisualStyleBackColor = true;
            this.buttonFillMassive.Click += new System.EventHandler(this.buttonFillMassive_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(614, 366);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(148, 28);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMinElement
            // 
            this.textBoxMinElement.Location = new System.Drawing.Point(460, 114);
            this.textBoxMinElement.Name = "textBoxMinElement";
            this.textBoxMinElement.Size = new System.Drawing.Size(149, 20);
            this.textBoxMinElement.TabIndex = 10;
            this.textBoxMinElement.Text = "45";
            // 
            // textBoxMaxElement
            // 
            this.textBoxMaxElement.Location = new System.Drawing.Point(620, 114);
            this.textBoxMaxElement.Name = "textBoxMaxElement";
            this.textBoxMaxElement.Size = new System.Drawing.Size(146, 20);
            this.textBoxMaxElement.TabIndex = 11;
            this.textBoxMaxElement.Text = "46";
            // 
            // labelMinElement
            // 
            this.labelMinElement.AutoSize = true;
            this.labelMinElement.Location = new System.Drawing.Point(467, 98);
            this.labelMinElement.Name = "labelMinElement";
            this.labelMinElement.Size = new System.Drawing.Size(123, 13);
            this.labelMinElement.TabIndex = 12;
            this.labelMinElement.Text = "Input Matrix Min Element";
            // 
            // labelMaxElement
            // 
            this.labelMaxElement.AutoSize = true;
            this.labelMaxElement.Location = new System.Drawing.Point(627, 98);
            this.labelMaxElement.Name = "labelMaxElement";
            this.labelMaxElement.Size = new System.Drawing.Size(126, 13);
            this.labelMaxElement.TabIndex = 13;
            this.labelMaxElement.Text = "Input Matrix Max Element";
            // 
            // buttonReplaceElements
            // 
            this.buttonReplaceElements.Location = new System.Drawing.Point(12, 358);
            this.buttonReplaceElements.Name = "buttonReplaceElements";
            this.buttonReplaceElements.Size = new System.Drawing.Size(428, 36);
            this.buttonReplaceElements.TabIndex = 20;
            this.buttonReplaceElements.Text = "Replace Elements On Diagonal And Upstairs";
            this.buttonReplaceElements.UseVisualStyleBackColor = true;
            this.buttonReplaceElements.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(458, 184);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(304, 43);
            this.buttonClean.TabIndex = 22;
            this.buttonClean.Text = "Clean Massive";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // radioLRDiagonal
            // 
            this.radioLRDiagonal.AutoSize = true;
            this.radioLRDiagonal.Checked = true;
            this.radioLRDiagonal.Location = new System.Drawing.Point(223, 312);
            this.radioLRDiagonal.Name = "radioLRDiagonal";
            this.radioLRDiagonal.Size = new System.Drawing.Size(113, 17);
            this.radioLRDiagonal.TabIndex = 23;
            this.radioLRDiagonal.TabStop = true;
            this.radioLRDiagonal.Text = "From Left To Right";
            this.radioLRDiagonal.UseVisualStyleBackColor = true;
            // 
            // radioRLDiagonal
            // 
            this.radioRLDiagonal.AutoSize = true;
            this.radioRLDiagonal.Location = new System.Drawing.Point(223, 335);
            this.radioRLDiagonal.Name = "radioRLDiagonal";
            this.radioRLDiagonal.Size = new System.Drawing.Size(113, 17);
            this.radioRLDiagonal.TabIndex = 24;
            this.radioRLDiagonal.TabStop = true;
            this.radioRLDiagonal.Text = "From Right To Left";
            this.radioRLDiagonal.UseVisualStyleBackColor = true;
            // 
            // labelDiagonalType
            // 
            this.labelDiagonalType.AutoSize = true;
            this.labelDiagonalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelDiagonalType.Location = new System.Drawing.Point(12, 307);
            this.labelDiagonalType.Name = "labelDiagonalType";
            this.labelDiagonalType.Size = new System.Drawing.Size(194, 22);
            this.labelDiagonalType.TabIndex = 26;
            this.labelDiagonalType.Text = "Choose Diagonal Type";
            // 
            // TaskMainDiagonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(776, 402);
            this.ControlBox = false;
            this.Controls.Add(this.labelDiagonalType);
            this.Controls.Add(this.radioRLDiagonal);
            this.Controls.Add(this.radioLRDiagonal);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonReplaceElements);
            this.Controls.Add(this.labelMaxElement);
            this.Controls.Add(this.labelMinElement);
            this.Controls.Add(this.textBoxMaxElement);
            this.Controls.Add(this.textBoxMinElement);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonFillMassive);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxInputOrder);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.buttonGetMatrixOrder);
            this.Name = "TaskMainDiagonal";
            this.Text = "Task Main Diagonal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetMatrixOrder;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.TextBox textBoxInputOrder;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonFillMassive;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxMinElement;
        private System.Windows.Forms.TextBox textBoxMaxElement;
        private System.Windows.Forms.Label labelMinElement;
        private System.Windows.Forms.Label labelMaxElement;
        private System.Windows.Forms.Button buttonReplaceElements;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.RadioButton radioLRDiagonal;
        private System.Windows.Forms.RadioButton radioRLDiagonal;
        private System.Windows.Forms.Label labelDiagonalType;
    }
}

