using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easyrecursion
{
    //14.1.Описать рекурсивную функцию для подсчёта количества запятых  в  данном текстовом файле.
    public partial class TrainingTask : Form
    {
        public TrainingTask()
        {
            InitializeComponent();
        }
        private void buttonUseRecursion_Click(object sender, EventArgs e)
        {
            char [] k = textBox1.Text.ToCharArray();
            int f = k.Length;
            textBoxResult.Text = ClassSearch.Recursion(k,f).ToString();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
