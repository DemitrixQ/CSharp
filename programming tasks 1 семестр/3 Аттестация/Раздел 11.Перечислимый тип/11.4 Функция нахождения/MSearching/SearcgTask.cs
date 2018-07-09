using System;
using System.Windows.Forms;

namespace WindowsFormsSearching
{
    /*
    4.	Дано
   const
       MaxN = 30;
   type
        ВещТип = record
            знак : boolean;
            мантисса, порядок : real;
        end;
   список = array[1..MaxN] of ВещТип;

   Описать:
   4.1 функцию MaxNeg(C) для нахождения минимального отрицательного числа из списка чисел С;
   4.2 функцию MaxDi(C) для нахождения максимального порядка числа из списка вещественных чисел С;

    */
    public partial class SearchTask : Form
    {
        public SearchTask()
        {
            InitializeComponent();
        }

        private RealNumber[] InputLines(DataGridView dgv)
        {
            RealNumber[] a = new RealNumber[dgv.RowCount-1];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new RealNumber();
                a[i].a = (bool)dgv[0, i].Value;//.ToString() == "-";
                /*if (dgv[0, i].Value.ToString() == "-")
                    a[i].a = true;
                else
                    a[i].a = false;*/
                a[i].mantissa = Convert.ToDouble(dgv[1, i].Value.ToString());
                a[i].order = Convert.ToInt32(dgv[2, i].Value.ToString());
            }
            return a;
        }
        private void OutputLines(RealNumber[] massive, DataGridView dgv)
        {
            dgv.RowCount = massive.Length+1;
            for (int i = 0; i < massive.Length; i++)
            {
                dgv[0, i].Value = massive[i].a;
                dgv[1, i].Value = massive[i].mantissa;
                dgv[2, i].Value = massive[i].order;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxQuanityofNumbers.Text);
            RealNumber[] arr = ClassSearch.Generate(a);
            OutputLines(arr, dataGridView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RealNumber[] arr;
            arr = InputLines(dataGridView);
            int k = Convert.ToInt32(textBoxMathPow.Text);
            //textBoxResult.Text = (-1*ClassSearch.Search(arr, k)).ToString();
            RealNumber answer = ClassSearch.SearchMax(arr);
            if (answer != null)
            {
                textBoxResult.Text = "" + answer/*.ConvertToString()*/;
                //listBox1.Items.Add(answer);
            }
            else
                textBoxResult.Text = "Not found";
        }

        private void buttonFindMaximumNumber_Click(object sender, EventArgs e)
        {
            RealNumber[] arr;
            arr = InputLines(dataGridView);
            int k = Convert.ToInt32(textBoxMathPow.Text);
            textBox2.Text = ClassSearch.SearchMin(arr).ToString();
        }

        private void buttonFindMaxOrder_Click(object sender, EventArgs e)
        {
            RealNumber[] arr;
            arr = InputLines(dataGridView);
            textBoxMaximumOrder.Text = ClassSearch.SearchMaximumOrder(arr).ToString();
        }
    }
}
