using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    /* 9.Прямая на плоскости может быть задана уравнением ax + by = c, где a, b одновременно не равны нулю, a, b, c — целые. 
     Пусть даны коэффициенты нескольких прямых a1, b1, c1, a2, b2, c2, ..., an, bn, cn. 
     Определить, имеются ли среди этих прямых совпадающие или параллельные.
     */
    public partial class ParallelStraights : Form
    {
        public ParallelStraights()
        {
            InitializeComponent();
        }

        private void OutputLines(Line[] massive, DataGridView dgv)
        {
            dgv.RowCount = massive.Length;
            for (int i = 0; i < massive.Length; i++)
            {
                dgv[0, i].Value = massive[i].a;
                dgv[1, i].Value = massive[i].b;
                dgv[2, i].Value = massive[i].c;
            }
        }

        private Line[] InputLines(DataGridView dgv)
        {
            Line[] a = new Line[dgv.RowCount];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Line();
                a[i].a = Convert.ToDouble(dgv[0,i].Value.ToString());
                a[i].b = Convert.ToDouble(dgv[1,i].Value.ToString());
                a[i].c = Convert.ToDouble(dgv[2,i].Value.ToString());
            }
            return a;
        }

        private void buttonGetLines_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxLinesNumber.Text);
            Line[] arr = LineUtil.Generate(a);
            OutputLines(arr, dataGridViewLines);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Line[] arr;
            arr = InputLines(dataGridViewLines);
            bool r = LineUtil.ParallelCheck(arr);
            textBoxResult.Text = Convert.ToString(r);
        }
    }
}
