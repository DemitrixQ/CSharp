namespace Tree._18._3
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.button_Close = new System.Windows.Forms.Button();
            this.button_CreateTree = new System.Windows.Forms.Button();
            this.textBox_Level = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Tree = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.button_ChooseFile = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Output = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tree)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Close.Location = new System.Drawing.Point(684, 458);
            this.button_Close.Margin = new System.Windows.Forms.Padding(2);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(102, 28);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_CreateTree
            // 
            this.button_CreateTree.Location = new System.Drawing.Point(127, 86);
            this.button_CreateTree.Margin = new System.Windows.Forms.Padding(2);
            this.button_CreateTree.Name = "button_CreateTree";
            this.button_CreateTree.Size = new System.Drawing.Size(94, 34);
            this.button_CreateTree.TabIndex = 2;
            this.button_CreateTree.Text = "Create Tree";
            this.button_CreateTree.UseVisualStyleBackColor = true;
            this.button_CreateTree.Click += new System.EventHandler(this.button_CreateTree_Click);
            // 
            // textBox_Level
            // 
            this.textBox_Level.Location = new System.Drawing.Point(11, 100);
            this.textBox_Level.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Level.Name = "textBox_Level";
            this.textBox_Level.Size = new System.Drawing.Size(95, 20);
            this.textBox_Level.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите N";
            // 
            // pictureBox_Tree
            // 
            this.pictureBox_Tree.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Tree.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Tree.Name = "pictureBox_Tree";
            this.pictureBox_Tree.Size = new System.Drawing.Size(566, 340);
            this.pictureBox_Tree.TabIndex = 5;
            this.pictureBox_Tree.TabStop = false;
            this.pictureBox_Tree.Click += new System.EventHandler(this.pictureBox_Tree_Click);
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(600, 194);
            this.textBox_Output.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Output.Size = new System.Drawing.Size(186, 234);
            this.textBox_Output.TabIndex = 6;
            // 
            // button_ChooseFile
            // 
            this.button_ChooseFile.Location = new System.Drawing.Point(379, 86);
            this.button_ChooseFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_ChooseFile.Name = "button_ChooseFile";
            this.button_ChooseFile.Size = new System.Drawing.Size(185, 34);
            this.button_ChooseFile.TabIndex = 7;
            this.button_ChooseFile.Text = "Choose file";
            this.button_ChooseFile.UseVisualStyleBackColor = true;
            this.button_ChooseFile.Click += new System.EventHandler(this.button_ChooseFile_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(601, 100);
            this.textBox_FilePath.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(186, 20);
            this.textBox_FilePath.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Path";
            // 
            // button_Output
            // 
            this.button_Output.Location = new System.Drawing.Point(601, 143);
            this.button_Output.Margin = new System.Windows.Forms.Padding(2);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(185, 36);
            this.button_Output.TabIndex = 10;
            this.button_Output.Text = "Вывод путей";
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox_Tree);
            this.panel1.Location = new System.Drawing.Point(9, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 323);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 72);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Close;
            this.ClientSize = new System.Drawing.Size(810, 497);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_FilePath);
            this.Controls.Add(this.button_ChooseFile);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Level);
            this.Controls.Add(this.button_CreateTree);
            this.Controls.Add(this.button_Close);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Window";
            this.Text = "Tree";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tree)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_CreateTree;
        private System.Windows.Forms.TextBox textBox_Level;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Tree;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Button button_ChooseFile;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Output;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
    }
}

