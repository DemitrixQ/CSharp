using System;
using System.Windows.Forms;

namespace BinaryCheckerTask
{
    /*
     15.39. Создать очередь, информационные поля которой содержат вещественные числа из текстового файла. 
            Для каждого элемента списка определить число отрицательных элементов, следующих за ним.
            Результаты записать в текстовый файл в виде: элемент списка - число последующих отрицательных элементов.
     */
    public partial class BinaryCheckerTask : Form
    {
        public BinaryCheckerTask()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MyList q = ClassListFilling.Fill(ofd.FileName);
                int [] negatives = q.GetNeg();
                textBoxOutPut.Lines = q.SuperPrinter(negatives);
            }
        }
        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxOutPut.Text = null;
        }
    }
}
