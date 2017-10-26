using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//регить
        {
            string[] buttons = new string[3] { "метод трапеций", "метод прямоугольников", "метод порабол" };
            string l = "";
            double chislo4 = 0;
            
            string p;
            try
            {

                int formas = Int32.Parse(textBox3.Text);
                int j = 0;
            again:// первое расположение goto
                float y = 0;

                string k = textBox1.Text;
                string k1 = highpredel.Text;
                string k2 = lowpredel.Text;
                int counter = 0;
                double chislo = 0;
                curs s1 = new curs(ref k1);
                curs s2 = new curs(ref k2);
                curs s;
                float chislo1 = -1;//нижний предел функции 
                float chislo2 = 5;//верхний предел
                float high = Single.Parse(k1);
                float low = Single.Parse(k2);

                if (low > high)
                {
                    float promesh = high;
                    high = low;
                    low = promesh;
                    counter++;
                    k2 = Convert.ToString(low);
                    k1 = Convert.ToString(high);
                }
                double zam = Convert.ToSingle(k2);
                string r = "";
                if (trap.Checked)
                {
                    r = trap.Text;
                }
                if (primoug.Checked)
                {
                    r = primoug.Text;
                }
                if (parabol.Checked)
                {
                    r = parabol.Text;
                }
                int h = 0;


                for (int i = 0; i < 3; i++)
                {
                    if (r == buttons[i])
                    {
                        h = i;
                    }
                }
                y = (high - low) / formas;
                switch (h)
                {
                    case 0:
                        formas++;
                        break;
                    case 1:
                        formas += 2;
                        break;
                    case 2:
                        formas++;
                        break;
                }
                float[] mas = new float[formas];
                switch (h)
                {
                    case 0:
                        for (int i = 0; i < formas; i++)
                        {
                            p = Convert.ToString(zam);
                            if (zam < 0)
                            {
                                ubrmin(ref p);
                            }
                            k = k.Replace("x", p);

                            s = new curs(ref k);
                            mas[i] = Convert.ToSingle(k);
                            if (mas[i] < chislo1)
                            {
                                chislo1 = mas[i];
                            }
                            if (mas[i] > chislo2)
                            {
                                chislo2 = mas[i];
                            }
                            if (i == 0 || i == formas - 1)
                            {
                                chislo += mas[i] / 2;
                            }
                            else
                            {
                                chislo += mas[i];
                            }
                            zam += y;

                            k = textBox1.Text;
                        }
                        chislo = chislo * y;
                        if (counter != 0)
                        {
                            chislo = -chislo;
                        }
                        break;
                    case 1:
                        if (zam < 0)
                        {
                            ubrmin(ref k2);
                        }
                        k = k.Replace("x", k2);
                        zam += y / 2;
                        s = new curs(ref k);
                        mas[0] = Convert.ToSingle(k);
                        if (mas[0] < chislo1)
                        {
                            chislo1 = mas[0];
                        }
                        if (mas[0] > chislo2)
                        {
                            chislo2 = mas[0];
                        }
                        k = textBox1.Text;
                        for (int i = 1; i < formas - 1; i++)
                        {
                            p = Convert.ToString(zam);
                            if (zam < 0)
                            {
                                ubrmin(ref p);
                            }
                            k = k.Replace("x", p);
                            s = new curs(ref k);
                            mas[i] = Convert.ToSingle(k);
                            if (mas[i] < chislo1)
                            {
                                chislo1 = mas[i];
                            }
                            if (mas[i] > chislo2)
                            {
                                chislo2 = mas[i];
                            }
                            chislo += mas[i];

                            zam += y;

                            k = textBox1.Text;
                        }
                        float s7 = Single.Parse(k1);
                        if (s7 < 0)
                        {
                            ubrmin(ref k1);
                        }
                        k = k.Replace("x", k1);
                        s = new curs(ref k);
                        mas[formas - 1] = Convert.ToSingle(k);
                        if (mas[formas-1] < chislo1)
                        {
                            chislo1 = mas[formas-1];
                        }
                        if (mas[formas-1] > chislo2)
                        {
                            chislo2 = mas[formas-1];
                        }
                        chislo = chislo * y;
                        k = textBox1.Text;
                        if (counter != 0)
                        {
                            chislo = -chislo;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < formas; i++)
                        {
                            p = Convert.ToString(zam);
                            if (zam < 0)
                            {
                                ubrmin(ref p);
                            }
                            k = k.Replace("x", p);
                            s = new curs(ref k);
                            mas[i] = Convert.ToSingle(k);

                            if (mas[i] < chislo1)
                            {
                                chislo1 = mas[i];
                            }
                            if (mas[i] > chislo2)
                            {
                                chislo2 = mas[i];
                            }
                            if (i == 0 || i == formas - 1)
                            {
                                chislo += mas[i];
                            }
                            else if (i % 2 == 1)
                            {
                                chislo += 4 * mas[i];
                            }
                            else
                            {
                                chislo += 2 * mas[i];
                            }
                            zam += y;
                            k = textBox1.Text;
                        }
                        chislo = chislo * (y / 3);
                        if (counter != 0)
                        {
                            chislo = -chislo;
                        }
                        break;
                }
                k = Convert.ToString(chislo);
                if (j == 0)
                {
                    textBox2.Clear();
                    textBox2.Text = k;
                    для_вывода_графика graf = new для_вывода_графика(mas, chislo1, chislo2, y, high, low);
                    graf.Show();
                    
                    formas *= 2;
                    chislo4 = chislo;
                    j++;
                    goto again;
                }
                chislo4 = Math.Abs(chislo4 - chislo);
                l = Convert.ToString(chislo4);
                сообщение_о_точности g = new сообщение_о_точности(l);
                g.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Пожайлуста, проверьте формулу!");
            }
            }
        private static void ubrmin(ref string s)
        {
            s = s.Remove(0, 1);
            s = "_" + s;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(!Char.IsDigit(number) && number!=8 && number!=120 && number!=94 && !(number>=40 && number<=47) && number!='a' && number != 'c' && number != 'e' && number != 'i' && number != 'o' && number != 'l' && number != 'n' && number != 'g' && number != 's' && number != 't' && number!='r' && number!='|' && number!= ',' && number != 'p')
            {
                e.Handled = true;
            }
        }
        private void спарвкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new курсовая1.Form2();
            s.Show();
        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lowpredel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 120 && number != 94 && !(number >= 40 && number <= 47) && number != 'a' && number != 'c' && number != 'e' && number != 'i' && number != 'o' && number != 'l' && number != 'n' && number != 'g' && number != 's' && number != 't' && number != 'r' && number!=',' && number!='p')
            {
                e.Handled = true;
            }
        }
        private void highpredel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 120 && number != 94 && !(number >= 40 && number <= 47) && number != 'a' && number != 'c' && number != 'e' && number != 'i' && number != 'o' && number != 'l' && number != 'n' && number != 'g' && number != 's' && number != 't' && number != 'r' && number!= ',' && number != 'p')
            {
                e.Handled = true;
            }
        }
    }
}
