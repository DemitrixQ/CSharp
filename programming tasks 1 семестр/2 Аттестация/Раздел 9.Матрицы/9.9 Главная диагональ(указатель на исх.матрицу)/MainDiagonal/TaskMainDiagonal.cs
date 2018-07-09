using System;
using System.Windows.Forms;

namespace RowsAndCountsWIth_Elements
{
    /* 9.9.Дана вещественная квадратная матрица порядка N. 
           Заменить нулями все ее элементы, расположенные на главной диагонали и выше нее.
     */
    public partial class TaskMainDiagonal : Form
    {
        public TaskMainDiagonal()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGetRowsAndCollums_Click(object sender, EventArgs e)
        {
            int rc = Convert.ToInt32(textBoxInputOrder.Text);
            if (rc > 1)
            {
                dataGridView.RowCount = rc;
                dataGridView.ColumnCount = rc;
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        dataGridView.Columns[j].HeaderCell.Value = (j + 1).ToString();
                    }
                    dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    dataGridView.Columns[i].Width = 30;
                }
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    dataGridView.Rows[j].Height = 30;
                }
            }
            else
            {
                MessageBox.Show("You cant find diagonal in 1x1 matrix. Change order.");
            }
        }

        private void buttonFillMassive_Click(object sender, EventArgs e)
        {
            int rc = Convert.ToInt32(textBoxInputOrder.Text);
            if (rc > 1)
            {
            dataGridView.RowCount = rc;
            dataGridView.ColumnCount = rc;
            Random rnd = new Random();
            int min = Convert.ToInt32(textBoxMinElement.Text);
            int max = Convert.ToInt32(textBoxMaxElement.Text);
            if ((min < max) && (min != max))
            {
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        dataGridView[j, i].Value = rnd.Next(min, max);
                        dataGridView.Columns[j].HeaderCell.Value = (j + 1).ToString();
                        dataGridView.Columns[j].Width = 30;
                    }
                    dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    dataGridView.Rows[i].Height = 30;
                }
                
            }
            else
            {
                MessageBox.Show("Input correct range");
            }
            }
            else
            {
                MessageBox.Show("You cant find diagonal in 1x1 matrix. Change order.");
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView[j, i].Value = "";
                }
            }
        }

        private int[,] InputMatrix(DataGridView dgv)
        {
            int[,] m = new int[dgv.RowCount, dgv.ColumnCount];
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    m[i, j] = int.Parse(dgv[j, i].Value.ToString());
                }
            }

            return m;
        }
        
        private void OutputMatrix(int[,] m, DataGridView dgv)
        {
            dgv.RowCount = m.GetLength(0);
            dgv.ColumnCount = m.GetLength(1);
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    dgv[j, i].Value = m[i, j].ToString();
                }
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int[,] a = InputMatrix(dataGridView);
            int[,] x;
            //if (radioLRDiagonal.Checked)
            //{
                x=ClassFill.FillLRDiagonal(a);
                //textBox1.Text=.ToString();
            //}
            //else //radioRLDiagonal.Checked
            //{
                x= ClassFill.FillRLDiagonal(a);
                //textBox1.Text=ClassFill.FillRLDiagonal(a).ToString();
            //}
            OutputMatrix(x, dataGridView);
        }
    }
}
