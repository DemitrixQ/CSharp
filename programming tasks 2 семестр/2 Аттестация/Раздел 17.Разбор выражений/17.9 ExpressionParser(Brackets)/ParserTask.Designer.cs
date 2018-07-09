namespace ExpressionParser_Brackets_
{
    partial class Parser
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
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonCLose = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labela = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.textBoxa = new System.Windows.Forms.TextBox();
            this.textBoxb = new System.Windows.Forms.TextBox();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(22, 101);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(508, 37);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "Check Expression";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(19, 59);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(91, 13);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Input Expression :";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(22, 75);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(508, 20);
            this.textBoxInput.TabIndex = 2;
            // 
            // buttonCLose
            // 
            this.buttonCLose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCLose.Location = new System.Drawing.Point(377, 205);
            this.buttonCLose.Name = "buttonCLose";
            this.buttonCLose.Size = new System.Drawing.Size(153, 27);
            this.buttonCLose.TabIndex = 4;
            this.buttonCLose.Text = "Close";
            this.buttonCLose.UseVisualStyleBackColor = true;
            this.buttonCLose.Click += new System.EventHandler(this.buttonCLose_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(71, 157);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(459, 20);
            this.textBoxResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Result  :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 401);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(508, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Text Result = ";
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(19, 30);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(22, 13);
            this.labela.TabIndex = 8;
            this.labela.Text = "a =";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Location = new System.Drawing.Point(80, 30);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(25, 13);
            this.labelb.TabIndex = 9;
            this.labelb.Text = "b = ";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Location = new System.Drawing.Point(137, 30);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(25, 13);
            this.labelc.TabIndex = 10;
            this.labelc.Text = "c = ";
            // 
            // textBoxa
            // 
            this.textBoxa.Location = new System.Drawing.Point(47, 27);
            this.textBoxa.MaxLength = 1;
            this.textBoxa.Name = "textBoxa";
            this.textBoxa.Size = new System.Drawing.Size(18, 20);
            this.textBoxa.TabIndex = 11;
            this.textBoxa.Text = "a";
            // 
            // textBoxb
            // 
            this.textBoxb.Location = new System.Drawing.Point(102, 27);
            this.textBoxb.MaxLength = 1;
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(18, 20);
            this.textBoxb.TabIndex = 12;
            this.textBoxb.Text = "b";
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(156, 30);
            this.textBoxc.MaxLength = 1;
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(21, 20);
            this.textBoxc.TabIndex = 13;
            this.textBoxc.Text = "c";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(508, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Elemet Result = ";
            // 
            // Parser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCLose;
            this.ClientSize = new System.Drawing.Size(537, 245);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxc);
            this.Controls.Add(this.textBoxb);
            this.Controls.Add(this.textBoxa);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCLose);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.buttonCheck);
            this.Name = "Parser";
            this.Text = "Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonCLose;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.TextBox textBoxa;
        private System.Windows.Forms.TextBox textBoxb;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.TextBox textBox1;
    }
}

