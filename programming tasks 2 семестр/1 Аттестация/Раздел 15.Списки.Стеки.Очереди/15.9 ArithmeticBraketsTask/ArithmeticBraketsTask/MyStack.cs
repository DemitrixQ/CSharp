using System;

namespace ArithmeticBraketsTask
{
    //15.9. Создать приложение, проверяющее правильность расстановки скобок в арифметическом выражении.
    class Node                     // узел
    {
        public Node nextelement;
        public int information;
        public Node(Node nextelement, int information)          // конструктор для узла
        {
            this.nextelement = nextelement;              
            this.information = information;
        }
    }
    class MyStack
    {
        Node topofstack;
        public void PushIn(int information)  //положить узелок в стек
        {
            topofstack = new Node(topofstack, information);
        }
        public int PopOut()       // взять узелок из из стека  //object
        {
            if (EmptyStack())
            {
                throw new Exception("Stack is empty");
            }
            int result= topofstack.information;
            topofstack = topofstack.nextelement;
            return result;
        }
        public bool EmptyStack()           // проверка стека на пустоту
        {
            return topofstack == null;
        }
        
    }
}
