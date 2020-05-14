using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLib;

namespace ExpresionHandlerLib
{
    public class ExpressionHandler
    {
        static private string GetExpression(string exp)
        {
            string[] b = exp.Split('(');

            return b[b.Length - 1].Split(')')[0];
        }

        static private void config(string exp)
        {
            if (ExpressionVerification(exp))
            {
            }
            else
            {
                throw new Exception("Wrong expression syntax");
            }
        }

        static public string GetResault(string expression)
        {
            config(expression);
            int bracketCount = expression.Split('(').Length;

            for (int l = 0; l < bracketCount+1; l++)
            {
                string exp = GetExpression(expression);
                int k = GetExpressionCount(exp);
                bracketCount = expression.Split('(').Length;

                string aStr = "";
                string bStr = "";
                int i = 0;

                for (int z = 0; z < k; z++)
                {
                    aStr = "";
                    bStr = "";
                    char action = GetFirstAction(exp);
                    if(action == '0')
                        return expression;
                    for (i = 0; i < exp.Length; i++)
                    {
                        if (exp[i] != action)
                        {
                            aStr += exp[i];

                            if (exp[i] == '*' || exp[i] == '-' || exp[i] == '+' || exp[i] == '/')
                            {
                                aStr = "";
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    for (int j = i + 1; j < exp.Length; j++)
                    {
                        if (exp[j] != '*' && exp[j] != '-' && exp[j] != '+' && exp[j] != '/')
                        {
                            bStr += exp[j];
                        }
                        else
                        {
                            break;
                        }
                    }

                    double a = 0;
                    double b = 0;
                    try
                    {
                        a = Convert.ToDouble(aStr);
                        b = Convert.ToDouble(bStr);
                    }
                    catch
                    {
                        return expression;
                    }
                    double ab = 0;

                    switch (action)
                    {
                        case '*':
                            {
                                ab = Calc.Multiplication(a, b);
                                break;
                            }
                        case '/':
                            {
                                ab = Calc.Division(a, b);
                                break;
                            }
                        case '+':
                            {
                                ab = Calc.Sum(a, b);
                                break;
                            }
                        case '-':
                            {
                                ab = Calc.Subtraction(a, b);
                                break;
                            }
                    }

                    string bufExp = expression;
                    expression = expression.Replace('(' + aStr + action + bStr + ')', ab.ToString());
                    if (bufExp == expression)
                    {
                        expression = expression.Replace(aStr + action + bStr, ab.ToString());
                        exp = exp.Replace(aStr + action + bStr, ab.ToString());
                    }
                    expression = Replace(expression);

                }

            }
            return expression;
        }

        static private string Replace(string exp)
        {
            if(exp.Contains("+-"))
                return exp.Replace("+-", "-");
            else if(exp.Contains("--"))
                return exp.Replace("--", "+");
            return exp;
        }

        static private char GetFirstAction(string exp)
        {
            char action = '0';
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '*' || exp[i] == '-' || exp[i] == '+' || exp[i] == '/')
                {
                    action = exp[i];
                    break;
                }
            }
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '*' || exp[i] == '/')
                {
                    action = exp[i];
                    break;
                }
            }
            return action;
        }


        static private int GetExpressionCount(string exp)
        {
            int e = 0;
            foreach (char item in exp)
            {
                if(item == '*' || item == '-' || item == '+' || item == '/')
                {
                    e++;
                }
            }
            return e;
        }

        static private bool ExpressionVerification(string exp)
        {
            for (int i = 0; i < exp.Length;i++)
            {
                if (exp[i] == '*' || exp[i] == '-' || exp[i] == '+' || exp[i] == '/' || 
                    exp[i] == ',' || exp[i] == '(')
                {
                    try
                    {
                        if (exp[i + 1] == '*' || exp[i + 1] == '-' || exp[i + 1] == '+' || exp[i + 1] == '/' ||
                            exp[i + 1] == ',' || exp[i] == ')')
                        {
                            return false;
                        }
                    }
                    catch
                    {
                        return false;                
                    }
                }
                else if (exp[i] == ')')
                {
                    try
                    {


                        if (exp[i + 1] != '*' && exp[i + 1] != '-' && exp[i + 1] != '+' && exp[i + 1] != '/')
                        {
                            if(exp[i + 1] == ',' || exp[i + 1] == '(')
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
