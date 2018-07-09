using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace XYSorter_Solution
{
    /*
     16.24. Написатть программу, которая иллюстрирует сортировку массива распределяющим подсчетом. 
            Элементом массива является запись следующего типа:
            record
            ch  : char;
            key : integer
            end;
            Указание. Ключом сортировки является поле целого типа.

     */
    public partial class SorterSolution : Form
    {
        int i = 0;
        Number[] a = new Number[0];
        public SorterSolution()
        {
            InitializeComponent();
        }
        private void buttonGet_Click(object sender, EventArgs e)
        {
            if ((textBoxInputed.Text != "") && (textBoxName.Text != ""))
            {
                Array.Resize(ref a, ++i);
                a[i - 1] = new Number();
                a[i - 1].ch = Convert.ToChar(textBoxName.Text);
                a[i - 1].key = Convert.ToInt32(textBoxInputed.Text);
                textBoxFirstPoints.Text += textBoxName.Text + "." + textBoxInputed.Text + "\r\n";
            }
            else
                MessageBox.Show("One field is empty!");
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (i != 1)
            {
                Graphics cm = panelg.CreateGraphics();
               // Graphics ms = panel1.CreateGraphics();
                Graphics pr = panel2.CreateGraphics();
                pr.Clear(Color.White); // очищает
                Number[] b = Sorter.SpecialSort(a);
                VisualSorter.Compare(cm, a);  //сравнение
                textBoxSortedPoints.Lines = NodePrinter.Print(b);  // не работает вовремя! Thread.Sleep(5000);
                VisualSorter.VisualPrinter(pr, b); //печать
            }
            else
                MessageBox.Show("Less 2 elements in massive!");
        }

        private void buttonGetFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Encoding enc = Encoding.GetEncoding(1251);
                FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader ReadText = new StreamReader(file, enc);
                string z;
                while (!ReadText.EndOfStream)
                {
                    z = ReadText.ReadLine();
                    Array.Resize(ref a, ++i);
                    a[i - 1] = new Number();
                    a[i - 1].key = Convert.ToInt32(z);
                    a[i - 1].ch = ' ';
                    textBoxFirstPoints.Text += a[i-1].ch + "." + a[i - 1].key.ToString() + "\r\n";
                }
                ReadText.Close();
                file.Close();
            }
        }

        private void buttonGetRows_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxRows.Text);
            dataGridView1.RowCount = a;
        }
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxRows.Text);
            Number[] arr = LineUtill.Generate(a);
            OutputLines(arr, dataGridView1);
        }
        private void buttonGetMassive_Click(object sender, EventArgs e)
        {
            for (int j = 0; i < dataGridView1.RowCount; j++)
            {
                Array.Resize(ref a, ++i);
                a[i - 1] = new Number();
                a[i - 1].key = Convert.ToInt32(dataGridView1[1, j].Value);
                a[i - 1].ch = Convert.ToChar(dataGridView1[0, j].Value);
                textBoxFirstPoints.Text += a[i - 1].ch + "." + a[i - 1].key.ToString() + "\r\n";
            }
        }

        private void OutputLines(Number[] massive, DataGridView dgv)
        {
            dgv.RowCount = massive.Length;
            for (int i = 0; i < massive.Length; i++)
            {
                dgv[0, i].Value = massive[i].ch;
                dgv[1, i].Value = massive[i].key;
            }
        }

        private Number[] InputLines(DataGridView dgv)
        {
            Number[] a = new Number[dgv.RowCount];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Number();
                a[i].ch = Convert.ToChar(dgv[0, i].Value);
                a[i].key = Convert.ToInt32(dgv[1, i].Value);
            }
            return a;
        }
        private void buttonClean_Click(object sender, EventArgs e)
        {
            i = 0;
            a = null;
            textBoxFirstPoints.Text = null;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBoxInputed_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInputed.Text = "";
        }
        private void textBoxName_MouseClick_1(object sender, MouseEventArgs e)
        {
            textBoxName.Text = "";
        }

    }
}
