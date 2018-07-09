using System;
using System.Windows.Forms;

namespace StringElementSearch
{
    //24.Дана строка. Найти слова, которые имеют четную длину и начинаются с заданного символа
    public partial class StringElementSearch : Form
    {
        public StringElementSearch()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearchResult_Click(object sender, EventArgs e)
        {
           
            string s = textBoxWordsString.Text;
            int i= 0;
            int k = 0;
            string w ="";

            int j = 0;
            while (j < s.Length && s[j] == ' ')
                j++;

                for (i = j; i < s.Length; i++)
                {
                    if (s[i]!=' ')
                        {
                        w +=s[i];
                        }
                    if ((s[i]==' ') && (s[i-1]!=' '))
                    {
                        w += " ";
                    }
                }
            
            string target = textBoxElementString.Text;
            Utils.Search(w,target,k);
            textBoxSearchResult.Text = Utils.Search(w, target, k);
            textBoxCounter.Text = Convert.ToString(i);
            textBoxCounterEvenSearch.Text = Convert.ToString(w.Length);
            //textBoxCounterFoundElements.Text = Utils.Search(Convert.ToString(k));
        }
    }
}
