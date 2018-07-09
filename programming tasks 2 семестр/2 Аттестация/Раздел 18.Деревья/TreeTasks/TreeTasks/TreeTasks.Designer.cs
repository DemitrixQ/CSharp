namespace TreeTasks
{
    partial class TaskForm
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
            this.textBoxTask1 = new System.Windows.Forms.TextBox();
            this.textBoxTask2 = new System.Windows.Forms.TextBox();
            this.panelVisualTree = new System.Windows.Forms.Panel();
            this.BackGround = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonCheckLevel = new System.Windows.Forms.Button();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.textBoxResult1 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.textBoxTreeElements = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonGetTree = new System.Windows.Forms.Button();
            this.textBoxLeafs = new System.Windows.Forms.TextBox();
            this.textBoxElements = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelVisualTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTask1
            // 
            this.textBoxTask1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask1.Location = new System.Drawing.Point(12, 7);
            this.textBoxTask1.Multiline = true;
            this.textBoxTask1.Name = "textBoxTask1";
            this.textBoxTask1.ReadOnly = true;
            this.textBoxTask1.Size = new System.Drawing.Size(642, 17);
            this.textBoxTask1.TabIndex = 0;
            this.textBoxTask1.Text = "18.9. Подсчитать максимум из элементов на k-ом уровне заданного двоичного дерева " +
    "(корень считать узлом 1-го уровня).\r\n";
            // 
            // textBoxTask2
            // 
            this.textBoxTask2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask2.Location = new System.Drawing.Point(12, 35);
            this.textBoxTask2.Multiline = true;
            this.textBoxTask2.Name = "textBoxTask2";
            this.textBoxTask2.ReadOnly = true;
            this.textBoxTask2.Size = new System.Drawing.Size(479, 22);
            this.textBoxTask2.TabIndex = 1;
            this.textBoxTask2.Text = "18.24. Подсчитать минимум из чисел содержащихся в листьях заданного двоичного дер" +
    "ева.";
            // 
            // panelVisualTree
            // 
            this.panelVisualTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVisualTree.Controls.Add(this.BackGround);
            this.panelVisualTree.Location = new System.Drawing.Point(12, 63);
            this.panelVisualTree.Name = "panelVisualTree";
            this.panelVisualTree.Size = new System.Drawing.Size(663, 443);
            this.panelVisualTree.TabIndex = 2;
            this.panelVisualTree.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVisualTree_Paint);
            // 
            // BackGround
            // 
            this.BackGround.Location = new System.Drawing.Point(3, 3);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(153, 23);
            this.BackGround.TabIndex = 12;
            this.BackGround.Text = "Background Color";
            this.BackGround.UseVisualStyleBackColor = true;
            this.BackGround.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(681, 221);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(210, 19);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create Tree";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(681, 381);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(210, 43);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Check Leafs";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonCheckLevel
            // 
            this.buttonCheckLevel.Location = new System.Drawing.Point(681, 297);
            this.buttonCheckLevel.Name = "buttonCheckLevel";
            this.buttonCheckLevel.Size = new System.Drawing.Size(210, 26);
            this.buttonCheckLevel.TabIndex = 5;
            this.buttonCheckLevel.Text = "Check Maximum :";
            this.buttonCheckLevel.UseVisualStyleBackColor = true;
            this.buttonCheckLevel.Click += new System.EventHandler(this.buttonCheckLevel_Click);
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Location = new System.Drawing.Point(681, 450);
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.Size = new System.Drawing.Size(210, 20);
            this.textBoxResult2.TabIndex = 6;
            this.textBoxResult2.Text = "Minimal leaf =";
            // 
            // textBoxResult1
            // 
            this.textBoxResult1.Location = new System.Drawing.Point(681, 355);
            this.textBoxResult1.Name = "textBoxResult1";
            this.textBoxResult1.Size = new System.Drawing.Size(210, 20);
            this.textBoxResult1.TabIndex = 7;
            this.textBoxResult1.Text = "Maximal element on k level =";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(791, 476);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(681, 272);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(210, 20);
            this.textBoxLevel.TabIndex = 9;
            this.textBoxLevel.Text = "Input level :";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(683, 246);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(210, 20);
            this.buttonClean.TabIndex = 10;
            this.buttonClean.Text = "Clean Tree";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // textBoxTreeElements
            // 
            this.textBoxTreeElements.Location = new System.Drawing.Point(681, 12);
            this.textBoxTreeElements.Multiline = true;
            this.textBoxTreeElements.Name = "textBoxTreeElements";
            this.textBoxTreeElements.Size = new System.Drawing.Size(210, 173);
            this.textBoxTreeElements.TabIndex = 11;
            this.textBoxTreeElements.Text = "3\r\n2\r\n87\r\n1\r\n76\r\n14\r\n33\r\n8\r\n1\r\n89\r\n0\r\n-4";
            // 
            // buttonGetTree
            // 
            this.buttonGetTree.Location = new System.Drawing.Point(681, 191);
            this.buttonGetTree.Name = "buttonGetTree";
            this.buttonGetTree.Size = new System.Drawing.Size(210, 24);
            this.buttonGetTree.TabIndex = 12;
            this.buttonGetTree.Text = "Get Elements";
            this.buttonGetTree.UseVisualStyleBackColor = true;
            this.buttonGetTree.Click += new System.EventHandler(this.buttonGetTree_Click);
            // 
            // textBoxLeafs
            // 
            this.textBoxLeafs.Location = new System.Drawing.Point(681, 430);
            this.textBoxLeafs.Name = "textBoxLeafs";
            this.textBoxLeafs.Size = new System.Drawing.Size(210, 20);
            this.textBoxLeafs.TabIndex = 13;
            this.textBoxLeafs.Text = "All Leafs :";
            // 
            // textBoxElements
            // 
            this.textBoxElements.Location = new System.Drawing.Point(683, 329);
            this.textBoxElements.Name = "textBoxElements";
            this.textBoxElements.Size = new System.Drawing.Size(210, 20);
            this.textBoxElements.TabIndex = 14;
            this.textBoxElements.Text = "Level Elemets :\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(905, 508);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxElements);
            this.Controls.Add(this.textBoxLeafs);
            this.Controls.Add(this.buttonGetTree);
            this.Controls.Add(this.textBoxTreeElements);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxResult1);
            this.Controls.Add(this.textBoxResult2);
            this.Controls.Add(this.buttonCheckLevel);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.panelVisualTree);
            this.Controls.Add(this.textBoxTask2);
            this.Controls.Add(this.textBoxTask1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TaskForm";
            this.Text = "Tree Task\'s";
            this.panelVisualTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTask1;
        private System.Windows.Forms.TextBox textBoxTask2;
        private System.Windows.Forms.Panel panelVisualTree;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonCheckLevel;
        private System.Windows.Forms.TextBox textBoxResult2;
        private System.Windows.Forms.TextBox textBoxResult1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.TextBox textBoxTreeElements;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button BackGround;
        private System.Windows.Forms.Button buttonGetTree;
        private System.Windows.Forms.TextBox textBoxLeafs;
        private System.Windows.Forms.TextBox textBoxElements;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

