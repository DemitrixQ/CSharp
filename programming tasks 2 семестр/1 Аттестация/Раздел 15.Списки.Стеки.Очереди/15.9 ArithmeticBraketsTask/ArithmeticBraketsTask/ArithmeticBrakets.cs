using System;
using System.Windows.Forms;

namespace ArithmeticBraketsTask
{
    public partial class ArithmeticBrakets : Form
    {
        public ArithmeticBrakets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult.Text = MyChecker.Checker(textBoxMathExpression.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBoxResult.Enabled = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
