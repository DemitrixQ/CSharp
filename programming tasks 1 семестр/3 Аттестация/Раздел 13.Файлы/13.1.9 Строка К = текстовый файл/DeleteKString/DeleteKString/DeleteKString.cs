using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DeleteKString
{
    /*
     * 13.1.9 Дано число k и текстовый файл.
           Удалить из файла строку с номером k (строки нумеруются от 0). 
           Если строки с таким номером нет, то оставить файл без изменений
     */
    public partial class DeleteKString : Form
    {
        public DeleteKString()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonForm_Click(object sender, EventArgs e)
        {
            //StreamWriter WriteText = new 
            //textBoxStrings.Text = 
        }
        private void buttonDeleteKString_Click(object sender, EventArgs e)
        {
            //StreamWriter WriteText = new StreamWriter("D:\\firsttextfile.txt");
            //WriteText.WriteLine(textBoxStrings.Text);
            //WriteText.Close();
            //FileStream file = new FileStream("D:\\firsttextfile.txt", FileMode.Open);
            //StreamReader ReadText = new StreamReader("D:\\firsttextfile.txt");
            //StreamWriter WriteText = new StreamWriter(textBoxStrings.Text);
            //WriteText.WriteLine("D:\\firsttextfile.txt");
            //WriteText.Close();
            
            int k = Convert.ToInt32(textBoxK.Text);
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ClassDelete.DeleteK(ofd.FileName, k);
            }
        }
    }
}
