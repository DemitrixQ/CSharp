namespace LotTask
{
    partial class LotTask
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
            this.textBoxFirstLot = new System.Windows.Forms.TextBox();
            this.textBoxSecondLot = new System.Windows.Forms.TextBox();
            this.textBoxThirdLot = new System.Windows.Forms.TextBox();
            this.labelFirstLot = new System.Windows.Forms.Label();
            this.labelSecondLot = new System.Windows.Forms.Label();
            this.labelThirdLot = new System.Windows.Forms.Label();
            this.groupBoxLots = new System.Windows.Forms.GroupBox();
            this.buttonFillX2Lot = new System.Windows.Forms.Button();
            this.buttonFillX3Lot = new System.Windows.Forms.Button();
            this.buttonFillX1Lot = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelOddNumbersLot = new System.Windows.Forms.Label();
            this.labelNewLotY = new System.Windows.Forms.Label();
            this.textBoxYLot = new System.Windows.Forms.TextBox();
            this.textBoxOddNumbersLot = new System.Windows.Forms.TextBox();
            this.buttonFormLot = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFormOddNumbersLot = new System.Windows.Forms.Button();
            this.groupBoxLots.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirstLot
            // 
            this.textBoxFirstLot.Location = new System.Drawing.Point(6, 36);
            this.textBoxFirstLot.Name = "textBoxFirstLot";
            this.textBoxFirstLot.Size = new System.Drawing.Size(418, 20);
            this.textBoxFirstLot.TabIndex = 0;
            // 
            // textBoxSecondLot
            // 
            this.textBoxSecondLot.Location = new System.Drawing.Point(6, 101);
            this.textBoxSecondLot.Name = "textBoxSecondLot";
            this.textBoxSecondLot.Size = new System.Drawing.Size(418, 20);
            this.textBoxSecondLot.TabIndex = 1;
            // 
            // textBoxThirdLot
            // 
            this.textBoxThirdLot.Location = new System.Drawing.Point(6, 161);
            this.textBoxThirdLot.Name = "textBoxThirdLot";
            this.textBoxThirdLot.Size = new System.Drawing.Size(418, 20);
            this.textBoxThirdLot.TabIndex = 2;
            // 
            // labelFirstLot
            // 
            this.labelFirstLot.AutoSize = true;
            this.labelFirstLot.Location = new System.Drawing.Point(6, 16);
            this.labelFirstLot.Name = "labelFirstLot";
            this.labelFirstLot.Size = new System.Drawing.Size(77, 13);
            this.labelFirstLot.TabIndex = 3;
            this.labelFirstLot.Text = "Input Lot Х(1) :";
            // 
            // labelSecondLot
            // 
            this.labelSecondLot.AutoSize = true;
            this.labelSecondLot.Location = new System.Drawing.Point(3, 73);
            this.labelSecondLot.Name = "labelSecondLot";
            this.labelSecondLot.Size = new System.Drawing.Size(77, 13);
            this.labelSecondLot.TabIndex = 4;
            this.labelSecondLot.Text = "Input Lot Х(2) :";
            // 
            // labelThirdLot
            // 
            this.labelThirdLot.AutoSize = true;
            this.labelThirdLot.Location = new System.Drawing.Point(6, 135);
            this.labelThirdLot.Name = "labelThirdLot";
            this.labelThirdLot.Size = new System.Drawing.Size(77, 13);
            this.labelThirdLot.TabIndex = 5;
            this.labelThirdLot.Text = "Input Lot Х(3) :";
            // 
            // groupBoxLots
            // 
            this.groupBoxLots.Controls.Add(this.buttonFillX2Lot);
            this.groupBoxLots.Controls.Add(this.buttonFillX3Lot);
            this.groupBoxLots.Controls.Add(this.buttonFillX1Lot);
            this.groupBoxLots.Controls.Add(this.textBoxThirdLot);
            this.groupBoxLots.Controls.Add(this.labelFirstLot);
            this.groupBoxLots.Controls.Add(this.labelSecondLot);
            this.groupBoxLots.Controls.Add(this.textBoxFirstLot);
            this.groupBoxLots.Controls.Add(this.labelThirdLot);
            this.groupBoxLots.Controls.Add(this.textBoxSecondLot);
            this.groupBoxLots.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLots.Name = "groupBoxLots";
            this.groupBoxLots.Size = new System.Drawing.Size(580, 201);
            this.groupBoxLots.TabIndex = 6;
            this.groupBoxLots.TabStop = false;
            // 
            // buttonFillX2Lot
            // 
            this.buttonFillX2Lot.Location = new System.Drawing.Point(430, 101);
            this.buttonFillX2Lot.Name = "buttonFillX2Lot";
            this.buttonFillX2Lot.Size = new System.Drawing.Size(132, 23);
            this.buttonFillX2Lot.TabIndex = 8;
            this.buttonFillX2Lot.Text = "Fill Second Lot";
            this.buttonFillX2Lot.UseVisualStyleBackColor = true;
            this.buttonFillX2Lot.Click += new System.EventHandler(this.buttonFillX2Lot_Click);
            // 
            // buttonFillX3Lot
            // 
            this.buttonFillX3Lot.Location = new System.Drawing.Point(430, 159);
            this.buttonFillX3Lot.Name = "buttonFillX3Lot";
            this.buttonFillX3Lot.Size = new System.Drawing.Size(132, 23);
            this.buttonFillX3Lot.TabIndex = 7;
            this.buttonFillX3Lot.Text = "Fill Third Lot";
            this.buttonFillX3Lot.UseVisualStyleBackColor = true;
            this.buttonFillX3Lot.Click += new System.EventHandler(this.buttonFillX3Lot_Click);
            // 
            // buttonFillX1Lot
            // 
            this.buttonFillX1Lot.Location = new System.Drawing.Point(430, 36);
            this.buttonFillX1Lot.Name = "buttonFillX1Lot";
            this.buttonFillX1Lot.Size = new System.Drawing.Size(132, 23);
            this.buttonFillX1Lot.TabIndex = 6;
            this.buttonFillX1Lot.Text = "Fill First Lot";
            this.buttonFillX1Lot.UseVisualStyleBackColor = true;
            this.buttonFillX1Lot.Click += new System.EventHandler(this.buttonFillX1Lot_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelOddNumbersLot);
            this.groupBoxResult.Controls.Add(this.labelNewLotY);
            this.groupBoxResult.Controls.Add(this.textBoxYLot);
            this.groupBoxResult.Controls.Add(this.textBoxOddNumbersLot);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 219);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(580, 130);
            this.groupBoxResult.TabIndex = 7;
            this.groupBoxResult.TabStop = false;
            // 
            // labelOddNumbersLot
            // 
            this.labelOddNumbersLot.AutoSize = true;
            this.labelOddNumbersLot.Location = new System.Drawing.Point(6, 67);
            this.labelOddNumbersLot.Name = "labelOddNumbersLot";
            this.labelOddNumbersLot.Size = new System.Drawing.Size(96, 13);
            this.labelOddNumbersLot.TabIndex = 12;
            this.labelOddNumbersLot.Text = "Odd Numbers Lot :";
            // 
            // labelNewLotY
            // 
            this.labelNewLotY.AutoSize = true;
            this.labelNewLotY.Location = new System.Drawing.Point(6, 19);
            this.labelNewLotY.Name = "labelNewLotY";
            this.labelNewLotY.Size = new System.Drawing.Size(63, 13);
            this.labelNewLotY.TabIndex = 11;
            this.labelNewLotY.Text = "New Lot Y :";
            // 
            // textBoxYLot
            // 
            this.textBoxYLot.Location = new System.Drawing.Point(9, 35);
            this.textBoxYLot.Name = "textBoxYLot";
            this.textBoxYLot.ReadOnly = true;
            this.textBoxYLot.Size = new System.Drawing.Size(553, 20);
            this.textBoxYLot.TabIndex = 9;
            // 
            // textBoxOddNumbersLot
            // 
            this.textBoxOddNumbersLot.Location = new System.Drawing.Point(9, 93);
            this.textBoxOddNumbersLot.Name = "textBoxOddNumbersLot";
            this.textBoxOddNumbersLot.ReadOnly = true;
            this.textBoxOddNumbersLot.Size = new System.Drawing.Size(553, 20);
            this.textBoxOddNumbersLot.TabIndex = 10;
            // 
            // buttonFormLot
            // 
            this.buttonFormLot.Location = new System.Drawing.Point(12, 355);
            this.buttonFormLot.Name = "buttonFormLot";
            this.buttonFormLot.Size = new System.Drawing.Size(287, 40);
            this.buttonFormLot.TabIndex = 0;
            this.buttonFormLot.Text = "Form New Lot Y";
            this.buttonFormLot.UseVisualStyleBackColor = true;
            this.buttonFormLot.Click += new System.EventHandler(this.buttonFormLot_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(472, 401);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 32);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFormOddNumbersLot
            // 
            this.buttonFormOddNumbersLot.Location = new System.Drawing.Point(337, 355);
            this.buttonFormOddNumbersLot.Name = "buttonFormOddNumbersLot";
            this.buttonFormOddNumbersLot.Size = new System.Drawing.Size(255, 40);
            this.buttonFormOddNumbersLot.TabIndex = 8;
            this.buttonFormOddNumbersLot.Text = "Form Odd Numbers Lot";
            this.buttonFormOddNumbersLot.UseVisualStyleBackColor = true;
            this.buttonFormOddNumbersLot.Click += new System.EventHandler(this.buttonFormOddNumbersLot_Click);
            // 
            // LotTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(598, 434);
            this.ControlBox = false;
            this.Controls.Add(this.buttonFormOddNumbersLot);
            this.Controls.Add(this.buttonFormLot);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxLots);
            this.Name = "LotTask";
            this.Text = "LotTask";
            this.groupBoxLots.ResumeLayout(false);
            this.groupBoxLots.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstLot;
        private System.Windows.Forms.TextBox textBoxSecondLot;
        private System.Windows.Forms.TextBox textBoxThirdLot;
        private System.Windows.Forms.Label labelFirstLot;
        private System.Windows.Forms.Label labelSecondLot;
        private System.Windows.Forms.Label labelThirdLot;
        private System.Windows.Forms.GroupBox groupBoxLots;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelOddNumbersLot;
        private System.Windows.Forms.Label labelNewLotY;
        private System.Windows.Forms.TextBox textBoxYLot;
        private System.Windows.Forms.TextBox textBoxOddNumbersLot;
        private System.Windows.Forms.Button buttonFormLot;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFormOddNumbersLot;
        private System.Windows.Forms.Button buttonFillX2Lot;
        private System.Windows.Forms.Button buttonFillX3Lot;
        private System.Windows.Forms.Button buttonFillX1Lot;
    }
}

