﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionParser_Brackets_
{
    class MyNode                     // узел
    {
        public MyNode nextelement;
        public int information;
        public MyNode(MyNode nextelement, int information)          // конструктор для узла
        {
            this.nextelement = nextelement;
            this.information = information;
        }
    }
    class MyStack
    {
        MyNode topofstack;
        public void PushIn(int information)  //положить узелок в стек
        {
            topofstack = new MyNode(topofstack, information);
        }
        public int PopOut()       // взять узелок из из стека  //object
        {
            if (EmptyStack())
            {
                throw new Exception("Stack is empty");
            }
            int result = topofstack.information;
            topofstack = topofstack.nextelement;
            return result;
        }
        public bool EmptyStack()           // проверка стека на пустоту
        {
            return topofstack == null;
        }
    }
}
