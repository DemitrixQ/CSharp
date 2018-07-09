namespace ArithmeticBraketsTask
{
    //15.9. Создать приложение, проверяющее правильность расстановки скобок в арифметическом выражении.
    class MyChecker
    {
        public static bool Checker(string expression)
        {
            bool answer = true;
            MyStack brackets = new MyStack();
            for (int i = 0; i < expression.Length; i++)
            { 
                switch(expression[i])
                {
                    case '(':
                        {
                            brackets.PushIn(1);
                        }
                        break;
                    case ')':
                        {
                            //if (brackets.EmptyStack())
                            //{
                            //    return false;
                            //}
                            //else
                            {
                                if (brackets.PopOut()!= 1)
                                {
                                    return false;
                                }
                            }
                        }
                        break;
                    case '[':
                        {
                            brackets.PushIn(2);
                        }
                        break;
                    case ']':
                        {
                            /*if (brackets.EmptyStack())
                            {
                                return false;
                            }
                            else 
                            {*/
                            try
                            {
                                if (brackets.PopOut() != 2)
                                {
                                    return false;
                                }
                            }
                            catch
                            {
                                return false; //throw new Exception("  ");
                            }
                            //}
                        }
                        break;
                    case '{':
                        {
                            brackets.PushIn(3);
                        }
                        break;
                    case '}':
                        {
                            if (brackets.EmptyStack())
                            {
                                return false;
                            }
                            else
                            {
                                if (brackets.PopOut()!= 3)
                                {
                                    return false;
                                }
                            }
                        }
                        break;
                }
            }
            if (!brackets.EmptyStack())      //(!answer) || //((expression[i]=='[') || (expression[i]==']') || (expression[i]=='(')||(expression[i]==')')||(expression[i]=='{')||(expression[i]=='}'))
            {
                answer = false;
            }
            return answer;
        }
    }
}
