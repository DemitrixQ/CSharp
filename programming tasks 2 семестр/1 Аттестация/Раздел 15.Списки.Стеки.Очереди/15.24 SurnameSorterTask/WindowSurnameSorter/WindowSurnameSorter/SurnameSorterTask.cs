using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowSurnameSorter
{
    public partial class SurnameSorterTask : Form
    {
        public SurnameSorterTask()
        {
            InitializeComponent();
        }

        private void buttonGetSList_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFillList_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MyQueue q = new MyQueue();
                q=Sorter.FormList(ofd.FileName);
                textBoxSL.Lines = q.Printer();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddSurname_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MyQueue q = new MyQueue();
                q = Sorter.FormList(ofd.FileName);
                Sorter.AddSurname(q, textBoxSurname.Text);
                textBoxFSL.Lines = q.Printer();
            }
        }
    }
}
