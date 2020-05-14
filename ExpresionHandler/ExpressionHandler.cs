using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionHandlerLib
{
    public class ExpressionHandler
    {
        public int expressions { get; set; }
        public double a { get; set; }
        public double b { get; set; }
        public char action { get; set; }
        public string expression = "";

        public ExpressionHandler(string exp)
        {
            expression = exp;
            if (ExpressionVerification())
            {
                expressions = 0;
                SetExpressionCount();
            }
            else
            {
                throw new Exception("Wrong expression syntax");
            }
        }

        private int FirstLocation()
        {
            return expression.Split('(').Length;
        }

        public void GetExpression()
        {
            int s = FirstLocation();
            int k = 0;
            string[] b = expression.Split('(');
            List<string[]> buffer = new List<string[]>();

            foreach(string item in b)
            {
                buffer.Add(item.Split(')'));
            }

            foreach(string[] buf in buffer)
            {
                foreach(string item in buf)
                {
                    if(k == s)
                    {
                        Console.Write("First:");
                    }
                    Console.WriteLine(item);
                    k++;
                }
            }
        }



        private void SetExpressionCount()
        {
            foreach (char item in expression)
            {
                if(item == '*' || item == '-' || item == '+' || item == '/')
                {
                    expressions++;
                }
            }
        }

        private bool ExpressionVerification()
        {
            for (int i = 0; i < expression.Length;i++)
            {
                if (expression[i] == '*' || expression[i] == '-' || expression[i] == '+' || expression[i] == '/' || 
                    expression[i] == ',' || expression[i] == '(')
                {
                    try
                    {
                        if (expression[i + 1] == '*' || expression[i + 1] == '-' || expression[i + 1] == '+' || expression[i + 1] == '/' ||
                            expression[i + 1] == ',' || expression[i] == ')')
                        {
                            return false;
                        }
                    }
                    catch
                    {
                        return false;                
                    }
                }
                else if (expression[i] == ')')
                {
                    try
                    {


                        if (expression[i + 1] != '*' && expression[i + 1] != '-' && expression[i + 1] != '+' && expression[i + 1] != '/')
                        {
                            if(expression[i + 1] == ',' || expression[i + 1] == '(')
                            {
                                return false;
                            }
                        }
                    }
                    catch
                    {
                        return true;
                    }
                }
            }
            return true;
        }

    }
}
