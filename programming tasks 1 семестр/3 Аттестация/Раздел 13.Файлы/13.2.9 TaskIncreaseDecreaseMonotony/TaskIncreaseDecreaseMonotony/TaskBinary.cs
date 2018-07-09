using System;
using System.Windows.Forms;
using System.IO;

namespace TaskIncreaseDecreaseMonotony
{
    //13.2.9 Дан файл вещественных чисел. Найти количество его участков убывания1|возрастания2|монотонности
    public partial class TaskBinary : Form
    {
        public TaskBinary()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (ofd1.ShowDialog()==DialogResult.OK)
            {
                string f = ofd1.FileName;
                textBoxString.Text = textBoxString.Text + f;
                FileStream UserFile = new FileStream(f, FileMode.Open);
                BinaryReader UserFileText = new BinaryReader(UserFile);
                UserFileText.Close();
                textBoxQuantity.Text = ClassSearcher.Quantity(f).ToString();
                textBoxIncrease.Text = ClassSearcher.Increase(f).ToString();
                textBoxDecrease.Text = ClassSearcher.Decrease(f).ToString();
                textBoxMonotony.Text = (Convert.ToInt32(textBoxIncrease.Text)+Convert.ToInt32(textBoxDecrease.Text)).ToString();
                    //(ClassSearcher.Increase(f)+ ClassSearcher.Decrease(f)).ToString();
            }
        }

        private void textBoxIncrease_TextChanged(object sender, EventArgs e)
        {
            //missclick
        }
    }
}
