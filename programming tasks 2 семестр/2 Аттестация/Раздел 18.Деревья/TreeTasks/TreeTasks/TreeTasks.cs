using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TreeTasks
{
    
    public partial class TaskForm : Form
    {
        MyTree a = new MyTree();
        public TaskForm()
        {
            InitializeComponent();
            panelVisualTree.BackColor = Color.LightBlue;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGetTree_Click(object sender, EventArgs e)
        {
            for (int u = 0; u < textBoxTreeElements.Lines.Count(); u++)
            {
                if (textBoxTreeElements.Lines[u] != "")
                {
                    int key = Convert.ToInt32(textBoxTreeElements.Lines[u]);
                    int count = textBoxTreeElements.Lines.Length;
                    //a.Add(ref a.top, key, 300, 60, 1);
                    a.AddRandom(key, 300, 60);
                }
            }
        }
        
        private void buttonCreate_Click(object sender, EventArgs e)  //рисовка
        {
            a.Obhod(a.top);
            Graphics g = panelVisualTree.CreateGraphics();
            //a.DrawTree(g);
            //a.DrawTree(g, 0, panelVisualTree.Width, 40, 40);
        }

        private void buttonCheckLevel_Click(object sender, EventArgs e)  // максимальный элемент уровня
        {
            try
            {
                textBoxResult1.Text = a.GetMaximumOnLevel(Convert.ToInt32(textBoxLevel.Text)).ToString();

            }
            catch (Exception ex)
            {
                textBoxResult1.Text = "";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)     // минимальный листик
        {
            textBoxResult2.Text = a.GetMinimalLeaf().ToString();
        }

        private void buttonClean_Click(object sender, EventArgs e)  //очистка панели
        {
            textBoxResult1.Text = a.GetNodes().ToString();
            Graphics g = panelVisualTree.CreateGraphics();
           // g.Clear(Color.LightBlue);
        }

        private void button1_Click(object sender, EventArgs e)   // смена цвета панели
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            else
            this.panelVisualTree.BackColor = colorDialog.Color;
        }

        private void panelVisualTree_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panelVisualTree.CreateGraphics();
            //a.DrawTree(g);
            a.DrawTree(g, 0, panelVisualTree.Width, 40, 40);
        }
    }
}

//a.GetLevelMassive(a.top, k);
//textBoxElements.Text += a.LevelElemets;
//textBoxResult1.Text = CheckLevel.Check(a.levelmassive).ToString();

// a.GetLeafsMassive(a.top);
// textBoxLeafs.Text += a.Leafs;
// textBoxResult2.Text = (CheckLeafs.GetMinimalLeaf(a.leafsmassive)).ToString();
// textBoxResult2.Text = a.GetMinimalLeaf().ToString();