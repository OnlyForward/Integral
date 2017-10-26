using System;
using System.Collections.Generic;//произвел другую замену в методах деления и умножения, возможно придется производить замену вот эту и для + и -
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
//использовать indexof для поиска необхдимого действия

namespace курсовая1
{

    
    class curs
    {
        const double e = Math.E;
        const double pi = Math.PI;
        public curs(ref string stroka)
        {
            stroka = stroka.Replace("pi", Convert.ToString(pi));
            stroka = stroka.Replace("e", Convert.ToString(e));


            action1(ref stroka);

        }

        public static void action1(ref string stroka)
        {
            int i = 0;
            int j = 0;
            int prov = stroka.Length;
            string[] a = { "log", "ln", "arccos", "arcsin", "arctan", "arccatan", "cos", "sin", "catan", "tan", "(", "|", "^", "/", "*", "+", "-" };
            if (stroka != "")
            {
                while (i < 17 && stroka.Length > 1)
                {
                    if (i == 13 || i == 16)
                    {
                        stroka = stroka.Replace("_", "-");
                        stroka = stroka.Replace("--", "+");
                        stroka = stroka.Replace("+-", "-");
                        stroka = stroka.Replace("-+", "-");
                        if (stroka[0] == '+')
                        {
                            stroka = stroka.Remove(0, 1);
                        }
                    }
                    j = 0;
                    j = stroka.IndexOf(a[i], j);

                    if (j >= 0)
                    {
                        switch (i)
                        {
                            case 0:
                                log(ref stroka, ref j);
                                break;
                            case 1:
                                ln(ref stroka, ref j);
                                break;
                            case 2:
                                arccos(ref stroka, ref j);
                                break;
                            case 3:
                                arcsin(ref stroka, ref j);
                                break;
                            case 4:
                                arctan(ref stroka, ref j);
                                break;
                            case 5:
                                arccatan(ref stroka, ref j);
                                break;
                            case 6:
                                cos(ref stroka, ref j);
                                break;
                            case 7:
                                sin(ref stroka, ref j);
                                break;
                            case 8:
                                catan(ref stroka, ref j);
                                break;
                            case 9:
                                tan(ref stroka, ref j);
                                break;
                            case 10:
                                scobcki(ref stroka, ref j);
                                break;
                            case 11:
                                modul(ref stroka, ref j);
                                break;
                            case 12:
                                stepen(ref stroka, ref j);
                                break;
                            case 13:
                                del(ref stroka, ref j);
                                break;
                            case 14:
                                umnosh(ref stroka, ref j);
                                break;
                            case 15:
                                plus(ref stroka);
                                break;
                            case 16:
                                if (stroka.IndexOf('-', 1) < 0)
                                {
                                    i++;
                                    break;
                                }
                                plus(ref stroka);
                                break;
                        }
                    }
                    else
                    {
                        j = 0;
                        i++;
                    }
                }
            }
        }
        public static void log(ref string stroka, ref int element)
        {

            int identify = 0;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            element += 3;
            int nach = element;
            string chislo = "";
            while (stroka[element] != '(')
            {
                chislo += stroka[element];
                element++;
            }
            double chisloreal = Double.Parse(chislo);
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 3) + 1 - length1];
            stroka.CopyTo(nach - 3, s, 0, secondscobka - (nach - 3) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res =checked (Math.Log(c, chisloreal));
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }




        public static void ln(ref string stroka, ref int element)
        {
            int secondscobka = -1;
            string stroka1 = "";
            int identify = 0;
            int counter = 0;
            element += 2;
            int nach = element;
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 2) + 1 - length1];
            stroka.CopyTo(nach - 2, s, 0, secondscobka - (nach - 2) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res = Math.Log(c, e);
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }
        public static void cos(ref string stroka, ref int element)
        {
            int identify = 0;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            element += 3;
            int nach = element;
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 3) + 1 - length1];
            stroka.CopyTo(nach - 3, s, 0, secondscobka - (nach - 3) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res = Math.Cos(c);
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }
        public static void sin(ref string stroka, ref int element)
        {
            int identify = 0;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            element += 3;
            int nach = element;
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 3) + 1 - length1];
            stroka.CopyTo(nach - 3, s, 0, secondscobka - (nach - 3) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res = Math.Sin(c);
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }
        public static void tan(ref string stroka, ref int element)
        {
            int identify = 0;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            element += 3;
            int nach = element;
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 3) + 1 - length1];
            stroka.CopyTo(nach - 3, s, 0, secondscobka - (nach - 3) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res = Math.Tan(c);
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }
        public static void catan(ref string stroka, ref int element)
        {
            int identify = 0;
            int firstscobka = -1;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            element += 5;
            int nach = element;
            firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 5) + 1 - length1];
            stroka.CopyTo(nach - 5, s, 0, secondscobka - (nach - 5) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res = Math.Cos(c) / Math.Sin(c);
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }
        public static void arccos(ref string stroka, ref int element)
        {
            int identify = 0;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            element += 6;
            int nach = element;
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 6) + 1 - length1];
            stroka.CopyTo(nach - 6, s, 0, secondscobka - (nach - 6) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res = Math.Acos(c);
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }
        public static void arcsin(ref string stroka, ref int element)
        {
            int identify = 0;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            element += 6;
            int nach = element;
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 6) + 1 - length1];
            stroka.CopyTo(nach - 6, s, 0, secondscobka - (nach - 6) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res = Math.Asin(c);
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }
        public static void arctan(ref string stroka, ref int element)
        {
            int identify = 0;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            element += 6;
            int nach = element;
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 6) + 1 - length1];
            stroka.CopyTo(nach - 6, s, 0, secondscobka - (nach - 6) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res = Math.Atan(c);
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }
        public static void arccatan(ref string stroka, ref int element)
        {
            int identify = 0;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            element += 8;
            int nach = element;
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(q);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;
            stroka = stroka.Replace(stroka3, stroka1);
            char[] s = new char[secondscobka - (nach - 8) + 1 - length1];
            stroka.CopyTo(nach - 8, s, 0, secondscobka - (nach - 8) + 1 - length1);
            string strokazam = new string(s);
            double c = Convert.ToDouble(stroka1);
            double res = Math.Atan(-c) + pi / 2;
            string res1 = Convert.ToString(res);
            if (identify > 0 && res1[0] == '-')
            {
                res1 = res1.Replace('-', '_');
            }
            stroka = stroka.Replace(strokazam, res1);
        }
        public static void stepen(ref string stroka, ref int element)
        {
            int firstumnosh = -1;
          
            string stroka1 = "";
            int counter = 0;
            string chislo = "";
            int nach = element;

            firstumnosh = element;
            element--;
            while (element >= 0 && (char.IsDigit(stroka[element]) || stroka[element] == ',' || stroka[element] == '_'))
            {
                chislo += stroka[element];
                element--;
            }
            char[] s0 = chislo.ToCharArray();
            Array.Reverse(s0);
            chislo = new string(s0);
            string chislo1 = chislo;
            chislo = chislo.Replace('_', '-');
            double chisloreal1 = Double.Parse(chislo);
            int element1 = element + 1;
            element = nach + 1;
            chislo = "";
            if (stroka[element] == '-')
            {
                if (stroka[element + 1] == '_')
                {
                    stroka = stroka.Remove(element, 2);
                }
            }
            while (element < stroka.Length && ((char.IsDigit(stroka[element]) || stroka[element] == ',' || ((stroka[element] == '-' || stroka[element] == '_') && counter == 0))))
            {
                if (char.IsDigit(stroka[element])) {
                    counter++;
                }
                if (stroka[element] == '-')
                {
                    counter++;
                }
                chislo += stroka[element];
                element++;
            }
            int kol = element - element1;
            chislo1 += "^" + chislo;
            chislo = chislo.Replace('_', '-');
            double chisloreal2 = Double.Parse(chislo);
           
               double res = Math.Pow(chisloreal1, chisloreal2);
          
            string result = Convert.ToString(res);
            stroka = stroka.Remove(element1, kol);
            stroka = stroka.Insert(element1, result);
            action1(ref stroka1);
        }
        public static void del(ref string stroka, ref int element)
        {
            int firstumnosh = -1;
            string stroka1 = "";
            int counter = 0;
            string chislo = "";
            int nach = element;

            firstumnosh = element;
            element--;
            while (element >= 0 && (char.IsDigit(stroka[element]) || stroka[element] == ','))
            {
                chislo += stroka[element];
                element--;
            }
            char[] s0 = chislo.ToCharArray();
            Array.Reverse(s0);
            chislo = new string(s0);
            string chislo1 = chislo;
            double chisloreal1 = Double.Parse(chislo);
            int element1 = element + 1;
            element = nach + 1;
            chislo = "";
            while (element < stroka.Length && ((char.IsDigit(stroka[element]) || stroka[element] == ',' || (stroka[element] == '-' && counter == 0))))
            {
                if (char.IsDigit(stroka[element]))
                {
                    counter++;
                }
                if (stroka[element] == '-')
                {
                    counter++;
                }
                chislo += stroka[element];
                element++;
            }
            int kol = element - element1;
            chislo1 += "/" + chislo;
            double chisloreal2 = Double.Parse(chislo);
            double res = chisloreal1 / chisloreal2;
            string result = Convert.ToString(res);
            stroka = stroka.Remove(element1, kol);
            stroka = stroka.Insert(element1, result);
            action1(ref stroka1);
        }
        public static void umnosh(ref string stroka, ref int element)
        {
            string stroka1 = "";
            int counter = 0;
            string chislo = "";
            int nach = element;
            int firstumnosh = element;
            element--;
            while (element >= 0 && (char.IsDigit(stroka[element]) || stroka[element] == ',')) {
                chislo += stroka[element];
                element--;
            }
            char[] s0 = chislo.ToCharArray();
            Array.Reverse(s0);
            chislo = new string(s0);
            string chislo1 = chislo;
            double chisloreal1 = Double.Parse(chislo);
            int element1 = element + 1;
            element = nach + 1;
            chislo = "";
            while (element < stroka.Length && ((char.IsDigit(stroka[element]) || stroka[element] == ',' || (stroka[element] == '-' && counter == 0))))
            {
                if (char.IsDigit(stroka[element]))
                {
                    counter++;
                }
                if (stroka[element] == '-')
                {
                    counter++;
                }
                chislo += stroka[element];
                element++;
            }
            int kol = element - element1;
            chislo1 += "*" + chislo;
            double chisloreal2 = Double.Parse(chislo);
            double res = chisloreal1 * chisloreal2;
            string result = Convert.ToString(res);
            stroka = stroka.Remove(element1, kol);
            stroka = stroka.Insert(element1, result);
            action1(ref stroka1);
        }
        public static void plus(ref string stroka)
        {
            int i = 0;
            string chislo = "";
            double chislo1 = 0;
            int counter = 0;
            double chislores = 0;
        start:
            while (i < stroka.Length && (Char.IsDigit(stroka[i]) || stroka[i] == ',' || stroka[i] == '-') && counter == 0)
            {
                if (i < stroka.Length - 1 && stroka[i + 1] == '-')
                {
                    counter++;
                }
                chislo += stroka[i];
                i++;
            }
            if (i < stroka.Length)
            {
                chislo1 = Double.Parse(chislo);
                chislores += chislo1;
                chislo = "";
                if (stroka[i] == '-')
                {
                    chislo = "-";
                }
                counter = 0;
                i++;
                goto start;
            }
            char[] q = new char[i];
            string stroka3;
            chislores += Convert.ToDouble(chislo);
            stroka.CopyTo(0, q, 0, i);
            stroka3 = new string(q);
            stroka = stroka.Replace(stroka3, Convert.ToString(chislores));
            action1(ref stroka);
        }
        public static void scobcki(ref string stroka, ref int element)
        {
            int identify = 0;
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            int nach = element;
            int firstscobka = element;
            element++;
            while (stroka[element] != ')' || counter != 0)
            {
                if (stroka[element] == '(')
                {
                    counter++;
                }
                if (stroka[element] == ')')
                {
                    counter--;
                }
                element++;
            }
            secondscobka = element;
            if (secondscobka < stroka.Length - 1 && stroka[element + 1] == '^')
            {
                identify++;
            }
            char[] q = new char[secondscobka - firstscobka - 1];
            char[] s = new char[secondscobka - firstscobka + 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka.CopyTo(firstscobka, s, 0, secondscobka - firstscobka + 1);

            stroka1 = new string(q);
            int length1 = stroka1.Length;
            string stroka3 = new string(s);
            action1(ref stroka1);
            length1 = length1 - stroka1.Length;

            if (identify > 0 && stroka1[0] == '-')
            {
                stroka1 = stroka1.Replace('-', '_');
            }
            stroka = stroka.Replace(stroka3, stroka1);

        }
        public static void modul(ref string stroka, ref int element)
        {
            int secondscobka = -1;
            string stroka1 = "";
            int counter = 0;
            int nach = element;
            int firstscobka = element;
            int identify = firstscobka + 1;
            element++;
            while (element < stroka.Length)
            {
                if (stroka[element] == '|')
                {
                    identify = element;
                    counter++;
                }
                element++;
            }
            secondscobka = identify;
            char[] q = new char[secondscobka - firstscobka - 1];
            char[] s = new char[secondscobka - firstscobka + 1];
            stroka.CopyTo(firstscobka + 1, q, 0, secondscobka - firstscobka - 1);
            stroka.CopyTo(firstscobka, s, 0, secondscobka - firstscobka + 1);
            stroka1 = new string(q);
            string stroka3 = new string(s);
            action1(ref stroka1);
            if (stroka1[0] == '-' || stroka1[0] == '_')
            {
                stroka1 = stroka1.Remove(0, 1);
            }
            stroka = stroka.Replace(stroka3, stroka1);
        }

    }

    }


