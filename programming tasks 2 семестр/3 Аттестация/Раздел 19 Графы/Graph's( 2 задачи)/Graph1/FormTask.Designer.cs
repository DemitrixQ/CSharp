namespace Graph1
{
    partial class FormGraph
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findWayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMinCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.периферияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFormAddNode = new System.Windows.Forms.Button();
            this.buttonFormAddEdge = new System.Windows.Forms.Button();
            this.textBoxNodeName = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.labelNodes = new System.Windows.Forms.Label();
            this.labelEdges = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.textBoxNodeInformation = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.buttonDeleteGraph = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.informationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGraphToolStripMenuItem,
            this.openGraphToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.toolStripMenuItem1.Text = "Action with File";
            // 
            // saveGraphToolStripMenuItem
            // 
            this.saveGraphToolStripMenuItem.Name = "saveGraphToolStripMenuItem";
            this.saveGraphToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveGraphToolStripMenuItem.Text = "Save graph";
            this.saveGraphToolStripMenuItem.Click += new System.EventHandler(this.saveGraphToolStripMenuItem_Click);
            // 
            // openGraphToolStripMenuItem
            // 
            this.openGraphToolStripMenuItem.Name = "openGraphToolStripMenuItem";
            this.openGraphToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openGraphToolStripMenuItem.Text = "Open graph";
            this.openGraphToolStripMenuItem.Click += new System.EventHandler(this.openGraphToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkGraphToolStripMenuItem,
            this.findWayToolStripMenuItem,
            this.findMinCycleToolStripMenuItem,
            this.периферияToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "Check";
            // 
            // checkGraphToolStripMenuItem
            // 
            this.checkGraphToolStripMenuItem.Name = "checkGraphToolStripMenuItem";
            this.checkGraphToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.checkGraphToolStripMenuItem.Text = "Check Graph";
            this.checkGraphToolStripMenuItem.Click += new System.EventHandler(this.checkGraphToolStripMenuItem_Click);
            // 
            // findWayToolStripMenuItem
            // 
            this.findWayToolStripMenuItem.Name = "findWayToolStripMenuItem";
            this.findWayToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.findWayToolStripMenuItem.Text = "Find Way";
            this.findWayToolStripMenuItem.Click += new System.EventHandler(this.findWayToolStripMenuItem_Click);
            // 
            // findMinCycleToolStripMenuItem
            // 
            this.findMinCycleToolStripMenuItem.Name = "findMinCycleToolStripMenuItem";
            this.findMinCycleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.findMinCycleToolStripMenuItem.Text = "Find Min Cycle";
            this.findMinCycleToolStripMenuItem.Click += new System.EventHandler(this.findMinCycleToolStripMenuItem_Click);
            // 
            // периферияToolStripMenuItem
            // 
            this.периферияToolStripMenuItem.Name = "периферияToolStripMenuItem";
            this.периферияToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.периферияToolStripMenuItem.Text = "Периферия";
            this.периферияToolStripMenuItem.Click += new System.EventHandler(this.периферияToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.informationToolStripMenuItem.Text = "Creator";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(10, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(899, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "19.3. Определить, является ли связанным заданный граф. Указание: использовать рек" +
    "урсивную процедуру проверки доступности одной вершины из другой.\r\n";
            // 
            // buttonFormAddNode
            // 
            this.buttonFormAddNode.Location = new System.Drawing.Point(9, 134);
            this.buttonFormAddNode.Name = "buttonFormAddNode";
            this.buttonFormAddNode.Size = new System.Drawing.Size(125, 23);
            this.buttonFormAddNode.TabIndex = 2;
            this.buttonFormAddNode.Text = "Add Node";
            this.buttonFormAddNode.UseVisualStyleBackColor = true;
            this.buttonFormAddNode.Click += new System.EventHandler(this.buttonFormAddNode_Click);
            // 
            // buttonFormAddEdge
            // 
            this.buttonFormAddEdge.Location = new System.Drawing.Point(140, 134);
            this.buttonFormAddEdge.Name = "buttonFormAddEdge";
            this.buttonFormAddEdge.Size = new System.Drawing.Size(132, 23);
            this.buttonFormAddEdge.TabIndex = 3;
            this.buttonFormAddEdge.Text = "Add Edge";
            this.buttonFormAddEdge.UseVisualStyleBackColor = true;
            this.buttonFormAddEdge.Click += new System.EventHandler(this.buttonFormAddEdge_Click);
            // 
            // textBoxNodeName
            // 
            this.textBoxNodeName.Location = new System.Drawing.Point(12, 108);
            this.textBoxNodeName.Name = "textBoxNodeName";
            this.textBoxNodeName.Size = new System.Drawing.Size(66, 20);
            this.textBoxNodeName.TabIndex = 5;
            this.textBoxNodeName.Text = "1";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(140, 108);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(49, 20);
            this.textBoxFrom.TabIndex = 6;
            this.textBoxFrom.Text = "1";
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(194, 108);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(42, 20);
            this.textBoxIn.TabIndex = 8;
            this.textBoxIn.Text = "2";
            // 
            // labelNodes
            // 
            this.labelNodes.AutoSize = true;
            this.labelNodes.Location = new System.Drawing.Point(286, 92);
            this.labelNodes.Name = "labelNodes";
            this.labelNodes.Size = new System.Drawing.Size(50, 13);
            this.labelNodes.TabIndex = 9;
            this.labelNodes.Text = "Nodes = ";
            // 
            // labelEdges
            // 
            this.labelEdges.AutoSize = true;
            this.labelEdges.Location = new System.Drawing.Point(286, 110);
            this.labelEdges.Name = "labelEdges";
            this.labelEdges.Size = new System.Drawing.Size(49, 13);
            this.labelEdges.TabIndex = 10;
            this.labelEdges.Text = "Edges = ";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(80, 92);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(65, 13);
            this.labelInformation.TabIndex = 11;
            this.labelInformation.Text = "Information :\r\n";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(151, 92);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(36, 13);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "From :";
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(193, 91);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(22, 13);
            this.labelIn.TabIndex = 13;
            this.labelIn.Text = "In :";
            // 
            // textBoxNodeInformation
            // 
            this.textBoxNodeInformation.Location = new System.Drawing.Point(82, 107);
            this.textBoxNodeInformation.Name = "textBoxNodeInformation";
            this.textBoxNodeInformation.Size = new System.Drawing.Size(50, 20);
            this.textBoxNodeInformation.TabIndex = 14;
            this.textBoxNodeInformation.Text = "value";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 92);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(10, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 669);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton9);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Location = new System.Drawing.Point(2, -1);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(158, 34);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(4, 12);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(79, 17);
            this.radioButton9.TabIndex = 20;
            this.radioButton9.Text = "Rectangles";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(84, 12);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(60, 17);
            this.radioButton10.TabIndex = 20;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Ellipses";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(530, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(544, 32);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(452, 11);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(84, 17);
            this.radioButton6.TabIndex = 20;
            this.radioButton6.Text = "Delete Edge";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(366, 11);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.Text = "Delete Node";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(238, 11);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(128, 17);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.Text = "Exchange Information";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(158, 11);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Move Node";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 11);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Add Edge";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 11);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add Node";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(241, 108);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(32, 20);
            this.textBoxWeight.TabIndex = 17;
            this.textBoxWeight.Text = "2";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(236, 91);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(47, 13);
            this.labelWeight.TabIndex = 18;
            this.labelWeight.Text = "Weight :";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Location = new System.Drawing.Point(289, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(237, 30);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(17, 11);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(105, 17);
            this.radioButton8.TabIndex = 20;
            this.radioButton8.Text = "Undirected Edge";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(126, 11);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(90, 17);
            this.radioButton7.TabIndex = 20;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Directer Edge";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteGraph
            // 
            this.buttonDeleteGraph.Location = new System.Drawing.Point(1172, 132);
            this.buttonDeleteGraph.Name = "buttonDeleteGraph";
            this.buttonDeleteGraph.Size = new System.Drawing.Size(184, 25);
            this.buttonDeleteGraph.TabIndex = 20;
            this.buttonDeleteGraph.Text = "Delete Graph";
            this.buttonDeleteGraph.UseVisualStyleBackColor = true;
            this.buttonDeleteGraph.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(9, 56);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(636, 13);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "19.9. Задана система двусторонних дорог. Найти замкнутый путь, проходящий через к" +
    "аждую вершину и длиной не более N км.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "N =";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(666, 53);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(57, 20);
            this.textBoxN.TabIndex = 23;
            this.textBoxN.Text = "20";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(1071, 131);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(97, 27);
            this.buttonClean.TabIndex = 24;
            this.buttonClean.Text = "Clean Selected";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(1172, 164);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(184, 654);
            this.listBoxResult.TabIndex = 25;
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeleteGraph);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxNodeInformation);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.labelEdges);
            this.Controls.Add(this.labelNodes);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxNodeName);
            this.Controls.Add(this.buttonFormAddEdge);
            this.Controls.Add(this.buttonFormAddNode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1438, 858);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "FormGraph";
            this.Text = "Task Graph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem checkGraphToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFormAddNode;
        private System.Windows.Forms.Button buttonFormAddEdge;
        private System.Windows.Forms.TextBox textBoxNodeName;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label labelNodes;
        private System.Windows.Forms.Label labelEdges;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.TextBox textBoxNodeInformation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem saveGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGraphToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button buttonDeleteGraph;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.ToolStripMenuItem findWayToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.ToolStripMenuItem findMinCycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem периферияToolStripMenuItem;
    }
}

