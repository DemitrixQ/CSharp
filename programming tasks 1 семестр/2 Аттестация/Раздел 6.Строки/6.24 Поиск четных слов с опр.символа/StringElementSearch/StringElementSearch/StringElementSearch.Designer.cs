namespace StringElementSearch
{
    partial class StringElementSearch
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
            this.buttonSearchResult = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelWordString = new System.Windows.Forms.Label();
            this.textBoxWordsString = new System.Windows.Forms.TextBox();
            this.labelElementString = new System.Windows.Forms.Label();
            this.labelBoxResult = new System.Windows.Forms.Label();
            this.textBoxElementString = new System.Windows.Forms.TextBox();
            this.textBoxSearchResult = new System.Windows.Forms.TextBox();
            this.labelCounterEven = new System.Windows.Forms.Label();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.textBoxBag = new System.Windows.Forms.TextBox();
            this.labelCounterEvenChecked = new System.Windows.Forms.Label();
            this.textBoxCounterEvenSearch = new System.Windows.Forms.TextBox();
            this.textBoxCounterFoundElements = new System.Windows.Forms.TextBox();
            this.labelCounterWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearchResult
            // 
            this.buttonSearchResult.Location = new System.Drawing.Point(12, 134);
            this.buttonSearchResult.Name = "buttonSearchResult";
            this.buttonSearchResult.Size = new System.Drawing.Size(139, 33);
            this.buttonSearchResult.TabIndex = 0;
            this.buttonSearchResult.Text = "Search ";
            this.buttonSearchResult.UseVisualStyleBackColor = true;
            this.buttonSearchResult.Click += new System.EventHandler(this.buttonSearchResult_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(251, 404);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(126, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelWordString
            // 
            this.labelWordString.AutoSize = true;
            this.labelWordString.Location = new System.Drawing.Point(12, 24);
            this.labelWordString.Name = "labelWordString";
            this.labelWordString.Size = new System.Drawing.Size(68, 13);
            this.labelWordString.TabIndex = 2;
            this.labelWordString.Text = "Words String";
            // 
            // textBoxWordsString
            // 
            this.textBoxWordsString.Location = new System.Drawing.Point(12, 50);
            this.textBoxWordsString.Name = "textBoxWordsString";
            this.textBoxWordsString.Size = new System.Drawing.Size(369, 20);
            this.textBoxWordsString.TabIndex = 3;
            this.textBoxWordsString.Text = "Павел  парам  барабан   банан крот рота    взвод Platoon(1986)    ударник";
            // 
            // labelElementString
            // 
            this.labelElementString.AutoSize = true;
            this.labelElementString.Location = new System.Drawing.Point(12, 83);
            this.labelElementString.Name = "labelElementString";
            this.labelElementString.Size = new System.Drawing.Size(45, 13);
            this.labelElementString.TabIndex = 4;
            this.labelElementString.Text = "Element";
            // 
            // labelBoxResult
            // 
            this.labelBoxResult.AutoSize = true;
            this.labelBoxResult.Location = new System.Drawing.Point(12, 222);
            this.labelBoxResult.Name = "labelBoxResult";
            this.labelBoxResult.Size = new System.Drawing.Size(80, 13);
            this.labelBoxResult.TabIndex = 5;
            this.labelBoxResult.Text = "Search Result :";
            // 
            // textBoxElementString
            // 
            this.textBoxElementString.Location = new System.Drawing.Point(12, 108);
            this.textBoxElementString.Name = "textBoxElementString";
            this.textBoxElementString.Size = new System.Drawing.Size(45, 20);
            this.textBoxElementString.TabIndex = 6;
            this.textBoxElementString.Text = "P";
            // 
            // textBoxSearchResult
            // 
            this.textBoxSearchResult.Location = new System.Drawing.Point(12, 247);
            this.textBoxSearchResult.Multiline = true;
            this.textBoxSearchResult.Name = "textBoxSearchResult";
            this.textBoxSearchResult.ReadOnly = true;
            this.textBoxSearchResult.Size = new System.Drawing.Size(367, 82);
            this.textBoxSearchResult.TabIndex = 7;
            // 
            // labelCounterEven
            // 
            this.labelCounterEven.AutoSize = true;
            this.labelCounterEven.Location = new System.Drawing.Point(9, 345);
            this.labelCounterEven.Name = "labelCounterEven";
            this.labelCounterEven.Size = new System.Drawing.Size(104, 13);
            this.labelCounterEven.TabIndex = 8;
            this.labelCounterEven.Text = "Counter All Elements";
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Location = new System.Drawing.Point(12, 370);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.ReadOnly = true;
            this.textBoxCounter.Size = new System.Drawing.Size(100, 20);
            this.textBoxCounter.TabIndex = 9;
            // 
            // textBoxBag
            // 
            this.textBoxBag.Location = new System.Drawing.Point(12, 185);
            this.textBoxBag.Name = "textBoxBag";
            this.textBoxBag.ReadOnly = true;
            this.textBoxBag.Size = new System.Drawing.Size(367, 20);
            this.textBoxBag.TabIndex = 10;
            this.textBoxBag.Text = "Program Status : All Correct";
            // 
            // labelCounterEvenChecked
            // 
            this.labelCounterEvenChecked.AutoSize = true;
            this.labelCounterEvenChecked.Location = new System.Drawing.Point(125, 345);
            this.labelCounterEvenChecked.Name = "labelCounterEvenChecked";
            this.labelCounterEvenChecked.Size = new System.Drawing.Size(127, 13);
            this.labelCounterEvenChecked.TabIndex = 11;
            this.labelCounterEvenChecked.Text = "Counter Elements Search";
            // 
            // textBoxCounterEvenSearch
            // 
            this.textBoxCounterEvenSearch.Location = new System.Drawing.Point(118, 370);
            this.textBoxCounterEvenSearch.Name = "textBoxCounterEvenSearch";
            this.textBoxCounterEvenSearch.ReadOnly = true;
            this.textBoxCounterEvenSearch.Size = new System.Drawing.Size(134, 20);
            this.textBoxCounterEvenSearch.TabIndex = 12;
            // 
            // textBoxCounterFoundElements
            // 
            this.textBoxCounterFoundElements.Location = new System.Drawing.Point(258, 370);
            this.textBoxCounterFoundElements.Name = "textBoxCounterFoundElements";
            this.textBoxCounterFoundElements.ReadOnly = true;
            this.textBoxCounterFoundElements.Size = new System.Drawing.Size(121, 20);
            this.textBoxCounterFoundElements.TabIndex = 13;
            // 
            // labelCounterWords
            // 
            this.labelCounterWords.AutoSize = true;
            this.labelCounterWords.Location = new System.Drawing.Point(258, 345);
            this.labelCounterWords.Name = "labelCounterWords";
            this.labelCounterWords.Size = new System.Drawing.Size(123, 13);
            this.labelCounterWords.TabIndex = 14;
            this.labelCounterWords.Text = "Counter Found Elements";
            // 
            // StringElementSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(389, 439);
            this.ControlBox = false;
            this.Controls.Add(this.labelCounterWords);
            this.Controls.Add(this.textBoxCounterFoundElements);
            this.Controls.Add(this.textBoxCounterEvenSearch);
            this.Controls.Add(this.labelCounterEvenChecked);
            this.Controls.Add(this.textBoxBag);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.labelCounterEven);
            this.Controls.Add(this.textBoxSearchResult);
            this.Controls.Add(this.textBoxElementString);
            this.Controls.Add(this.labelBoxResult);
            this.Controls.Add(this.labelElementString);
            this.Controls.Add(this.textBoxWordsString);
            this.Controls.Add(this.labelWordString);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSearchResult);
            this.Name = "StringElementSearch";
            this.Text = "Element Search Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchResult;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelWordString;
        private System.Windows.Forms.TextBox textBoxWordsString;
        private System.Windows.Forms.Label labelElementString;
        private System.Windows.Forms.Label labelBoxResult;
        private System.Windows.Forms.TextBox textBoxElementString;
        private System.Windows.Forms.TextBox textBoxSearchResult;
        private System.Windows.Forms.Label labelCounterEven;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.TextBox textBoxBag;
        private System.Windows.Forms.Label labelCounterEvenChecked;
        private System.Windows.Forms.TextBox textBoxCounterEvenSearch;
        private System.Windows.Forms.TextBox textBoxCounterFoundElements;
        private System.Windows.Forms.Label labelCounterWords;
    }
}

