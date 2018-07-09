using System;
using System.Windows.Forms;

namespace StringsTask
{
    /*9. Пусть даны две строки str1 и str2. Необходимо выяснить, 
         можно ли из str1 путём перестановки литер получить строку str2. 
         Напишите подпрограмму, которая решала бы указанную задачу.*/
    public partial class ProjectStrings : Form
    {
        public ProjectStrings()
        {
            InitializeComponent();
        }

        private void ProjectStrings_Load(object sender, EventArgs e)
        {

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
          
            /*bool answer;
            answer = StringUtils.Check(textBoxFirstString.Text, textBoxSecondString.Text);
            textBoxResult.Text = Convert.ToString(answer);*/
            //textBoxResult.Text = StringUtils.Check(textBoxFirstString.Text, textBoxSecondString.Text).ToString();
            if (StringUtils.Check2(textBoxFirstString.Text, textBoxSecondString.Text))
                textBoxResult.Text = "All OK =)";
                //MessageBox.Show("All OK =)");
            else
                //MessageBox.Show("All Bad =)");
                textBoxResult.Text = "='(";
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
