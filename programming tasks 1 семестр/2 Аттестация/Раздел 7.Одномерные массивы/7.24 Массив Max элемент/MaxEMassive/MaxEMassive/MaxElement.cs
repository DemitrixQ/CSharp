using System;
using System.Windows.Forms;

namespace MaxEMassive
{
    //24.Найти максимальный элемент в массиве. Найти индекс максимального элемента.

    public partial class MaxElement : Form
    {
        public MaxElement()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int[] InputArray(DataGridView dgv)
        {
            int[] a = new int[dgv.RowCount];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(dgv[0, i].Value.ToString());
            }
            return a;
        }

        private void buttonRunApplication_Click(object sender, EventArgs e)
        {
            // Вывести максимальный элемент массива и его индекс.
            int[] x = InputArray(dataGridViewMassive);
            textBoxMaxElement.Text = Convert.ToString(Utils.SearchElementMassive(x));
            textBoxPosition.Text = Convert.ToString(Utils.SearchElementPosition(x)+1);
        }

        private void buttonSetRows_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBoxRows.Text);
            int c = Convert.ToInt32(textBoxCollums.Text);
            dataGridViewMassive.RowCount = r;
            dataGridViewMassive.ColumnCount = c;
        }

        public void buttonFillMassive_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBoxRows.Text);
            int c = Convert.ToInt32(textBoxCollums.Text);
            dataGridViewMassive.RowCount = r;
            dataGridViewMassive.ColumnCount = c;
            Random rnd = new Random();
            for (int i = 0; i < dataGridViewMassive.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMassive.ColumnCount; j++)
                {
                    dataGridViewMassive[j, i].Value = rnd.Next(100);
                }
            }

            for (int i = 0; i < dataGridViewMassive.ColumnCount; i++)
            {
                dataGridViewMassive.Columns[i].Width = 40;
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            dataGridViewMassive.Columns.Clear();
        }
    }
}
