using System;
using System.Windows.Forms;

namespace XYSorter_Solution
{
    /*
     16.9. Дано множество A из N точек с целочисленными координатами. 
           Порядок определяется следующим образом:  (x1, y1) < (x2, y2), если либо x1 < x2, либо x1 = x2 и y1 < y2. 
           Расположить точки данного множества по возрастанию или убыванию в соответствии с указанным порядком
     */
    public partial class SorterSolution : Form
    {
        int i = 0;
        PointNode[] a = new PointNode[0];
        public SorterSolution()
        {
            InitializeComponent();
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPName.Text = "";
        }
        private void textBoxInput_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInputX.Text = "";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInputY.Text = "";
        }
        private void textBoxInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((textBoxPName.Text!="") && (textBoxInputX.Text !="") && (textBoxInputY.Text != ""))
                {   Array.Resize(ref a, ++i);
                    a[i - 1] = new PointNode();
                    a[i - 1].name = textBoxPName.Text;
                    a[i - 1].x = Convert.ToInt32(textBoxInputX.Text);
                    a[i - 1].y = Convert.ToInt32(textBoxInputY.Text);
                    textBoxFirstPoints.Text += textBoxPName.Text + "(" + textBoxInputX.Text + " : " + textBoxInputY.Text + ")" + "\r\n";
                }
                else
                { MessageBox.Show("One of fields is empty."); }
            }
        }
        private void buttonGet_Click(object sender, EventArgs e)
        {
            if ((textBoxPName.Text != "") && (textBoxInputX.Text != "") && (textBoxInputY.Text != ""))
            {
                Array.Resize(ref a, ++i);
                a[i - 1] = new PointNode();
                a[i - 1].name = textBoxPName.Text;
                a[i - 1].x = Convert.ToInt32(textBoxInputX.Text);
                a[i - 1].y = Convert.ToInt32(textBoxInputY.Text);
                textBoxFirstPoints.Text += textBoxPName.Text + "(" + textBoxInputX.Text + " : " + textBoxInputY.Text + ")" + "\r\n";
            }
            else
            { MessageBox.Show("One of fields is empty."); }
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (i <= 1)
            {
                MessageBox.Show("Add at leaset 2 Points or more for checking!");
            }
            else
            {
                PointNode[] b = new PointNode[i];
                b = Sorter.IncreaseSort(a, radioButtonIncr.Checked);
                textBoxSortedPoints.Lines = Printer.Print(b);
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
