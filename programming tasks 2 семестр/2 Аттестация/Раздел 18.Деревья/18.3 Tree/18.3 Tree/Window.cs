using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tree._18._3
{
    public partial class Window : Form
    {
        Tree MyTree ;
        //Graphics g;
        public Window()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_CreateTree_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox_Level.Text) == 2)
                {
                    pictureBox_Tree.Width = 550;
                    pictureBox_Tree.Height = 300;
                }
                if (Convert.ToInt32(textBox_Level.Text) > 4)
                {
                    pictureBox_Tree.Width = 45 * (1 << (Convert.ToInt32(textBox_Level.Text)));
                    pictureBox_Tree.Height = 45 * (Convert.ToInt32(textBox_Level.Text)) + 40;
                }
                MyTree = new Tree(pictureBox_Tree.Width, pictureBox_Tree.Height);
                MyTree.GenerateTree(Convert.ToInt32(textBox_Level.Text));
                MyTree.DrawTree(0, pictureBox_Tree.Width, 20, 40);
                pictureBox_Tree.Image = MyTree.bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox_FilePath.Text = openFileDialog1.FileName;
        }

        private void pictureBox_Tree_Click(object sender, EventArgs e)
        {

        }

        
        private void button_Output_Click(object sender, EventArgs e)
        {
            textBox_Output.Clear();            
            string[] paths = MyTree.Obhod();
            //str = Utilities.Summa(ref res);
            textBox_Output.Text = paths.Aggregate((str, el) => str +"\r\n"+ el);
            if (textBox_FilePath.Text != "")                 
                File.AppendAllText(textBox_FilePath.Text, textBox_Output.Text);
        }
     }
}
