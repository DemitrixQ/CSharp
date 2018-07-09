using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LotTask
{
    /*
     10.1 Даны три множества Х1, Х2, Х3, содержащие целые числа из диапазона 1..100. Известно, что мощность каждого из этих множеств равна 10. 
          Сформировать новое множество Y=(Х1 U Х2) (Х2\ Х3), из которого выделить подмножество нечетных чисел.
          На экран вывести исходные и полученное множества. 
          Значения элементов исходных множеств ввести с клавиатуры.
     */
    public partial class LotTask : Form
    {
        HashSet<int> X1 = new HashSet<int>();
        HashSet<int> X2 = new HashSet<int>();
        HashSet<int> X3 = new HashSet<int>();
        HashSet<int> Y = new HashSet<int>();
        HashSet<int> OddNumbers = new HashSet<int>();
        public LotTask()
        {
            InitializeComponent();
        }

        private void buttonFillX1Lot_Click(object sender, EventArgs e)
        {
            X1 = ClassFormer.FillRandom();
            textBoxFirstLot.Text = ClassFormer.Print(X1);
        }

        private void buttonFillX2Lot_Click(object sender, EventArgs e)
        {
            X2 = ClassFormer.FillRandom();
            textBoxSecondLot.Text = ClassFormer.Print(X2);
        }

        private void buttonFillX3Lot_Click(object sender, EventArgs e)
        {
            X3 = ClassFormer.FillRandom();
            textBoxThirdLot.Text = ClassFormer.Print(X3);
        }

        private void buttonFormLot_Click(object sender, EventArgs e)
        {
            X1 = ClassFormer.Get(textBoxFirstLot.Text);
            X2 = ClassFormer.Get(textBoxSecondLot.Text);
            X3 = ClassFormer.Get(textBoxThirdLot.Text);
            Y = ClassFormer.FormLot(X1, X2, X3);
            textBoxYLot.Text = ClassFormer.Print(Y);
        }

        private void buttonFormOddNumbersLot_Click(object sender, EventArgs e)
        {
            //ClassFormer.FormOddNumbersLot(Y); должен обработать Y из предыдущего шага - неверный шаг, создать новый
            HashSet<int> Y1 = ClassFormer.FormOddNumbersLot(Y);
            textBoxOddNumbersLot.Text =ClassFormer.Print(Y1);
            //textBoxOddNumbersLot.Text = ClassFormer.Print(Y); // должен получить обработанное значение и напечатать - неверно
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
