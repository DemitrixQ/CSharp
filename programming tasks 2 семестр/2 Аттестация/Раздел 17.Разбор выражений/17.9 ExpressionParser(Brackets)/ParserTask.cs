using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ExpressionParser_Brackets_
{
    /*
     17.9. Проверить правильность расстановки скобок в строке S. Текст в строке S определяется следующим образом: 
            <текст>  ::= <элемент>  | <элемент><текст> 
            <элемент>  ::= a | b | c | (<текст>) | [<текст>] | {<текст>} 
           Если текст составлен правильно, то вывести 0; в противном случае вывести номер первой ошибочной скобки 
           или -1, если в строке недостаточно закрывающих скобок. 
     */
    public partial class Parser : Form
    {
        public Parser()
        {
            InitializeComponent();
        }

        private void buttonCLose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = null;
            bool answer = true;
            try
            {
                InterpretorExpression p = new InterpretorExpression();
                p.GetElementLetters(Convert.ToChar(textBoxa.Text), Convert.ToChar(textBoxb.Text), Convert.ToChar(textBoxc.Text));
               // p.GetStringLength(textBoxInput.Text);
                p.Parse(textBoxInput.Text);
            }
            catch (Exception i)
            {
                answer = false;
                MessageBox.Show("Error: " + i.Message);
            }
            textBoxResult.Text = answer.ToString();
        }
    }
}




















































































            //p.TextParser(textBoxInput.Text, Convert.ToChar(textBoxa.Text), Convert.ToChar(textBoxb.Text), Convert.ToChar(textBoxc.Text));
            // textBoxResult.Text = p.GetResult().ToString();
            //textBoxResult.Text = "True";
            //char a = Convert.ToChar(textBoxa.Text);
            //char b = Convert.ToChar(textBoxb.Text);
            //char c = Convert.ToChar(textBoxc.Text); ///////////////////////// три символа-элемента    
            //string z = textBoxInput.Text; // исходная строка
            //int o = 0; // передаваемый индекс элементов исходной строки
            //ElementNode result =  Parsek.Elementer(ref z, ref o, a , b, c); // разбираем строку с поиском структуры элемента
            //TextNode result2 = Parsek.Texter(ref z, ref o); // разбираем остаток от строки как текст

            //   try
            // {

            //  }
            //catch(Exception i)
            //{
            //    MessageBox.Show("Error: "+i.Message);
            //}




            //textBoxResult.Text = p.GetResult(textBoxInput.Text).ToString();
            //string resultat = ""; // строка - результат
            //if (result.type != 'f')
            //{
            //    resultat = 0.ToString();  // либо элемент либо элемент+текст
            //}
            //else
            //{
            //    if (result.elementtext == "-1")  // вышло с непустым стеком - не хватило закрывающих
            //    {
            //        resultat = "-1"; 
            //    }
            //    else
            //    {
            //        resultat = "Problems with position number " + result.elementtext;  // вышло с ошибкой и индексом неверной скобки 
            //    }
            //}
            //textBoxResult.Text = resultat;
            //textBox1.Text = result.type.ToString() + " " + result.elementtext;  //  тип элемента или переменная(a,b,c) + внутренний текст(если это скобки)
            //textBox2.Text = result2.text;  // текстовый остаток                        


//textBoxResult.Text = result.type.ToString() + " " + result.elementtext; //Parsek.Elementer(ref z, ref o, Convert.ToChar(textBoxa.Text), Convert.ToChar(textBoxb.Text), Convert.ToChar(textBoxc.Text));
//textBox2.Text = result2.text;



//textBoxResult.Text = 0.ToString();
//textBoxResult.Text = "false";
//textBox2.Text = "false";
//if (textBoxInput.Text != "")
//{
//    answer = false;
//}
// bool answer = Parsek.Elementer(ref z);
//textBoxResult.Text = answer.ToString();
//textBoxResult.Text = (Parsek.Elementer(ref z) ? 0:-1).ToString();
//Parsek.Elementer(ref z);
//if (!Parsek.Elementer(ref z))
//  {
// MessageBox.Show("Not enought " + o + " bracket");
// }