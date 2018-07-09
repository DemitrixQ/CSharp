using System;
using System.Windows.Forms;

namespace RowsAndCountsWIth_Elements
{
    /*8.9.Дана матрица размера n * m. 
         Вывести номер ее первой1|последней2 строки3|столбца4, 
         содержащего только положительные элементы. Если таких строк3|столбцов4 нет, то вывести 0.
    */
    public partial class TaskRowsandCollums : Form
    {
        public TaskRowsandCollums()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGetRowsAndCollums_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBoxInputRows.Text);
            int c = Convert.ToInt32(textBoxInputCollums.Text);
            dataGridView.RowCount = r;
            dataGridView.ColumnCount = c;
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

        private void buttonFillMassive_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBoxInputRows.Text);
            int c = Convert.ToInt32(textBoxInputCollums.Text);
            dataGridView.RowCount = r;
            dataGridView.ColumnCount = c;
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
                textBoxResult.Text = "Введите корректный диапазон";
            }
        }

        private void buttonGetRange_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(textBoxMinElement.Text);
            int max = Convert.ToInt32(textBoxMaxElement.Text);
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int[,] a = InputMatrix(dataGridView);
            if (radioButtonFirst.Checked)
            { 
                if (radioButtonRow.Checked)
                {
                     textBoxResult.Text = ClassCheck.FindFirstRow(a).ToString();
                }
                else //(radioButtonColumn.Checked) 
                {
                    textBoxResult.Text = ClassCheck.FindFirstColumn(a).ToString();
                }
            }

            else  // (radioButtonLast.Checked)
            {
                if (radioButtonRow.Checked)
                {
                    textBoxResult.Text = ClassCheck.FindLastRow(a).ToString();
                }
                else //(radioButtonColumn.Checked) 
                {
                    textBoxResult.Text = ClassCheck.FindLastColumn(a).ToString();
                }
            }
        }

        private void button1_CleanWind(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
        }
    }
}
