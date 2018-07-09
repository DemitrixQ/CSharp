using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionParser_Brackets_
{
    public class InterpretorExpression
    {
        public class Node
        {
            public string str;// значение 
            public Node left;  // ссылка на левое поддерево
            public Node right; // ссылка на правое поддерево
            public bool isElement; //конструктор узелочка
            public Node(Node left, Node right, string str)
            {
                this.str = str;
                this.left = left;
                this.right = right;
            }
        }
        private Node root;
        private char a;
        private char b;
        private char c;
        //private int i = 0;
        public void GetElementLetters(char la, char lb, char lc)
        {
            a = la;
            b = lb;
            c = lc;
        }
        public void Parse(string s)
        {
            int x = 0;
            root = ParseAsText(s, ref x);
        }
        private Node ParseAsText(string s, ref int i)
        {
            Node t = new Node(null, null, "TextNode");
            t.left = ParseAsElement(s, ref i);
            if (i < s.Length)
            {
                //i++;
                t.right=ParseAsText(s, ref i);
            }
            return t;
        }
        private Node ParseAsElement(string s, ref int i)
        {
            Node element = null;
            if ((s[i] == a) || (s[i] == b) || (s[i] == c))
            {
                return new Node(null, null, s[i++].ToString());
            }
            string h = "";
            int y = i;
            int p = 0;
            if (s[y] == '(')
            {
                p++;
                i++;
                while ((i < s.Length) && (s[i]!=')'))
                {
                    if (s[i] == ')')
                    {
                        p--;
                    }
                    h += s[i];
                    i++;
                }
                if (i < s.Length)
                    {
                        i++;
                        int new_i = 0;
                        return ParseAsText(h, ref new_i);
                    }
                else throw new Exception("Передаем пустоту");
            }

            if (element != null)
                return element;
            else throw new Exception("No TEXT on "+(i+1).ToString()+" position");
        }

    }
}






//if (y<s.Length - 1)
//                {
//                    y++;
//                    if (s[y] == ')')
//                    {
//                        if (h != null)
//                        {
//                            int new_i = 0;
//element = new Node(null, null, "()");
//element.left = ParseAsText(h, ref new_i);
//                        }
//                        else throw new Exception("Передаем пустоту");
//                    }
//                    else
//                        h += s[y];
//                }
















//private int sl;
//public void GetStringLength(string ls)
//{
//    sl = ls.Length;
//}
//private int i = 0;
//Node root ;

//switch (s[i])
//           {
//               case '(':
//                   break;
//               case '[':
//                   break;
//               case '{':
//                   break;
//           }



/*if (s[i] == '(')
            {
                if (i < s.Length - 1)
                {
                    i++;
                    if (s[i] == ')')
                    {
                        if (helper != null)
                        {
                            element = new Node(null, null, "()");
                            element.left = ParseAsText(helper);
                        }
                        else throw new Exception("Передаем пустоту");
                    }
                    else helper += s[i];
                }
            }*/


















//public bool GetResult()
//{

//}


//            private void Parse(string s)
//            {
//                root = ParseElement(s);
//            }

//            public bool Compare(string s)
//            {
//            return true;
//                //root.Compare();
//            }


//            private Node ParseElement(string s)
//            {
//                int count = 0;
//                string val = "";
//                for (int i = 0; i < s.Length; i++)
//                {
//                    //val = s.Substring(i, s.Length);

//                }
//                if (count > 0)
//                    return ParseElement(s);
//                Node l = ParseElement(val);
//                Node r = ParseElement(val);
//                Node x = new Node(null, null, "");
//                x.str = val;
//                x.left = l;
//                x.right = r;
//                x.isElement = true;
//                return x;
//            }

//        private void ParseText(string s)
//        {






//        }

//    }
//}










































































//public bool isText
//{
//    get { return (key == 0); }
//}
//public bool isElement
//{
//    get { return (key == 1); }
//}
//public bool isSText()
//{
//    if ((left != null) && (right == null))
//        return true;                         // только левый элемент
//    if ((left != null) && (right != null))
//        return ((left.key == 1) && (right.key == 0));

//    // else
//    return false;
//   // get { return (((left.key==1)&&(right.key == 0))||((left.key==1)&&(right==null))); }
//}
//}//
//private Node TreeTop;






//        public void TextParser(string s,char a,char b,char c)
//            {
//           // NodeResult n = new NodeResult(s, null, null);
//            TreeTop  = new Node(null, null,3); // верховный узел 
//            try
//            {
//                for (int i = 0; i < s.Length; i++)
//                {
//                    if ((s[i]==a)||(s[i]==b)||(s[i]==c))
//                    {
//                        if (TreeTop.left == null)
//                        {
//                            TreeTop.left = new Node(null, null, 1);
//                            break;
//                        }
//                        else
//                        {
//                            if (TreeTop.right == null)
//                            {
//                                TreeTop.right = new Node(null, null, 3);
//                                TreeTop = TreeTop.right;
//                                TreeTop.left = new Node(null, null, 1);
//                                break;
//                            }
//                            else
//                            {
//                                throw new Exception("Problem with right/left");
//                            }
//                        }
//                    }
//                    if (s[i] == '(')
//                    {
//                        if (i==s.Length-1)
//                            throw new Exception("Problem with closing bracket");
//                        while (i != s.Length - 1)
//                        {
//                            i++;
//                            if (s[i] == ')')
//                            {
//                                if (TreeTop.left == null)
//                                {
//                                    TreeTop.left = new Node(null, null,1);
//                                    break;
//                                }
//                                else
//                                {
//                                    if (TreeTop.right == null)
//                                    {
//                                        TreeTop.right = new Node(null, null,3);
//                                        TreeTop = TreeTop.right;
//                                        TreeTop.left = new Node(null, null, 1);
//                                        break;
//                                    }
//                                    else
//                                    {
//                                        throw new Exception("Problem with right/left");
//                                    }
//                                }
//                            }
//                            if ((s[i] == '(') || (s[i] == '[') || (s[i] == ']') || (s[i] == '{') || (s[i] == '}'))
//                            {
//                                throw new Exception("Problem with " + (i + 1) + " position");
//                            }
//                            if ((i == s.Length - 1) && (s[i] != ')'))
//                            {
//                                throw new Exception("Problem with closing bracket");
//                            }
//                        }
//                    }

//                  else
//                    {
//                         if (TreeTop.left == null)
//                            throw new Exception("Just text here");
//                        else
//                        {
//                            TreeTop.right = new Node(null, null,0);
//                            break;
//                        }
//                    }

//                }
//            }
//            catch (Exception i)
//            {
//                throw i;
//            }
//            }

//        public bool GetResult()
//        {
//            return Result(TreeTop);
//        }

//        private bool Result(Node p)
//        {
//            if (p.isSText())
//                return true;
//            bool ans = false;
//            if (p.right != null)
//                ans = Result(p.right);
//            return ans;
//        }
//    }
//}

//if (p.isLeaf)
//    return p.key;
//int l;
//if (p.left != null)
//    l = FindMinimalLeaf(p.left);
//else
//    return FindMinimalLeaf(p.right);
//if (p.right != null)
//{
//    int r = FindMinimalLeaf(p.right);
//    return (l < r) ? l : r;
//}
//else
//    return l;













//if (p.isText)
//    return true;
//return false;



//if ((p.left.key == 1) && (p.right.key == 0))
//return true;



//return false;














//    public bool GetResult(string z)
//    {
//        return true;
//        // return top.Value();
//    }


//    public static ElementNode Elementer(ref string s, ref int pos, char a, char b, char c)
//    {
//        string r = "";
//        ElementNode f = new ElementNode('f', "false");
//        MyStack brackets = new MyStack();
//        for (int i = 0; i < s.Length; i++)
//        {
//            switch (s[i])
//            {
//                case 'a':
//                    {
//                        f = new ElementNode('a', "");      // возвращаем элемент (у скобок передаем первую открывающую в качестве 1 аргумента)
//                        pos++;
//                        return f;
//                    }
//                case 'b':
//                    {
//                        f = new ElementNode('b', "");
//                        pos++;
//                        return f;
//                    }
//                case 'c':
//                    {
//                        f = new ElementNode('c', "");
//                        pos++;
//                        return f;
//                    }


//                case '(':
//                    {
//                        brackets.PushIn(1);
//                        while (i != s.Length - 1)
//                        {
//                            i++;
//                            pos++;
//                            if (s[i] == ')')
//                            {
//                                brackets.PopOut();        // вынимаем из стека сразу при встрече нужной закрывающей скобки
//                                f = new ElementNode('(', r);
//                                pos++;
//                                return f;
//                            }
//                            if ((s[i] != '(') && (s[i] != '[') && (s[i] != ']') && (s[i] != '{') && (s[i] != '}'))
//                            {
//                                r += s[i];                                                    // накапливаем внутренний текст
//                            }
//                            else
//                                return f = new ElementNode('f', (i + 1).ToString());           // вошла не та скобка, возвращаем ошибку + индекс неверной
//                        }
//                    }
//                    break;

//                case '[':
//                    {
//                        brackets.PushIn(2);
//                        while (i != s.Length - 1)
//                        {
//                            i++;
//                            pos++;
//                            if (s[i] == ']')
//                            {
//                                brackets.PopOut();
//                                f = new ElementNode('[', r);
//                                pos++;
//                                return f;
//                            }
//                            if ((s[i] != '[') && (s[i] != '(') && (s[i] != ')') && (s[i] != '{') && (s[i] != '}'))
//                            {
//                                r += s[i];
//                            }
//                            else
//                                return f = new ElementNode('f', (i + 1).ToString());
//                        }
//                    }
//                    break;

//                case '{':
//                    {
//                        brackets.PushIn(3);
//                        while (i != s.Length - 1)
//                        {
//                            i++;
//                            pos++;
//                            if (s[i] == '}')
//                            {
//                                brackets.PopOut();
//                                f = new ElementNode('{', r);
//                                pos++;
//                                return f;
//                            }
//                            if ((s[i] != '{') && (s[i] != '[') && (s[i] != ']') && (s[i] != '(') && (s[i] != ')'))
//                            {
//                                r += s[i];
//                            }
//                            else
//                                return f = new ElementNode('f', (i + 1).ToString());
//                        }
//                    }
//                    break;
//            }
//        }
//        if (!brackets.EmptyStack())               // не хватает закрывающих
//        {
//            f = new ElementNode('f', "-1");
//        }
//        return f;
//    }

//}
//public class ElementNode
//{
//    public char type;
//    public string elementtext;

//    public ElementNode(char type, string elementtext)
//    {
//        this.type = type;
//        this.elementtext = elementtext;
//    }

//}




//public class TextNode
//{
//    public string text;
//    public TextNode(string text)
//    {
//        this.text = text;
//    }
//}




//public static TextNode Texter(ref string s, ref int pos)  //приняли оставшуюся строку и индекс, просто накапливаем
//{
//    string z = "";
//    for (int i = pos; i < s.Length; i++)
//    {
//        z += s[i];
//    }
//    TextNode q = new TextNode(z);
//    return q;
//}



//r+" "+(pos+1).ToString();
// r = "False";


//case 'a':
//    {
//        f = new ElementNode('a', "");
//        //while (i != s.Length - 1)
//        //{
//        //    i++;
//        //    pos++;
//        //    r += s[i];

//        //}
//        pos++;
//    }
//    break;









//case 'b':
//    {
//        ElementNode f = new ElementNode('b', "");
//        while (i != s.Length - 1)
//        {
//            i++;
//            pos++;
//            r += s[i];
//        }
//    }
//    break;
//case 'c':
//    {
//        ElementNode f = new ElementNode('c', "");
//        while (i != s.Length - 1)
//        {
//            i++;
//            pos++;
//            r += s[i];
//        }
//    }
//    break;

//case '(':
//    {
//        brackets.PushIn(1);
//        while (i != s.Length - 1)
//        {
//            i++;
//            pos++;
//            if (s[i] == ')')
//            {
//                brackets.PopOut();
//                f = new ElementNode('(', r);
//                pos++;
//                break;
//            }
//            if ((s[i] != '(') && (s[i] != '[') && (s[i] != ']') && (s[i] != '{') && (s[i] != '}'))
//            {
//                r += s[i];
//            }
//            else
//                return f = new ElementNode('f', "false");
//               // return f;
//                    //r = "False";
//        }
//    }
//    break;

//case '[':
//    {
//        brackets.PushIn(2);
//        while (i != s.Length - 1)
//        {
//            i++;
//            pos++;
//            if (s[i] == ']')
//            {
//                brackets.PopOut();
//                ElementNode f = new ElementNode('[', r);
//                break;
//            }
//            if ((s[i] != '[') && (s[i] != '(') && (s[i] != ')') && (s[i] != '{') && (s[i] != '}'))
//            {
//                r += s[i];
//            }
//            else
//                return r = "False";
//        }
//    }
//    break;
//case '{':
//    {
//        brackets.PushIn(3);
//        while (i != s.Length - 1)
//        {
//            i++;
//            pos++;
//            if (s[i] == '}')
//            {
//                brackets.PopOut();
//                ElementNode f = new ElementNode('{', r);
//                break;
//            }
//            if ((s[i] != '{') && (s[i] != '(') && (s[i] != ')') && (s[i] != '[') && (s[i] != ']'))
//            {
//                r += s[i];
//            }
//            else
//                return r = "False";
//        }
//    }
//    break;
// }

// }
