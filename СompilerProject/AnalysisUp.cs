using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace СompilerProject
{
    class AnalysisUp
    {
        public string str = "";
        public struct MyRule
        {
            public int p, l;
            public int[] m;
        }
        public int indarr, indR;
        public Grammatics[] arr = new Grammatics[1000];
        public Grammatics[] arrS = new Grammatics[1000];
        public Grammatics myElemwt = new Grammatics();
        public MyRule[] Rule = new MyRule[16];
        public List<Grammatics> arrWords = new List<Grammatics>();
        public int[] Rules = new int[1000];
        public int[,] arrZ;
        public void Initalize()
        {
            MyRule myElem = new MyRule();
            int[] b = { 1, 5, 6, 2, 3, 3, 0 };
            myElem.p = 1;
            myElem.l = 6;
            myElem.m = b;
            Rule[0] = myElem;
            myElem.p = 1;
            myElem.l = 7;
            int[] c = { 1, 5, 6, 2, 3, 3, 0 };
            myElem.m = c;
            Rule[1] = myElem;
            myElem.p = 2;
            myElem.l = 2;
            int[] d = { 7, 16, 0, 0, 0, 0 };
            myElem.m = d;
            Rule[2] = myElem;
            myElem.p = 2;
            myElem.l = 5;
            int[] q = { 7, 16, 8, 2, 9, 0 };
            myElem.m = q;
            Rule[3] = myElem;
            myElem.p = 3;
            myElem.l = 1;
            int[] w = { 5, 0, 0, 0, 0, 0 };
            myElem.m = w;
            Rule[4] = myElem;
            myElem.p = 4;
            myElem.l = 2;
            int[] e = { 1, 5, 0, 0, 0, 0 };
            myElem.m = e;
            Rule[5] = myElem;
            myElem.p = 6;
            myElem.l = 1;
            int[] a = { 16, 0, 0, 0, 0, 0 };
            myElem.m = a;
            Rule[6] = myElem;
            myElem.p = 6;
            myElem.l = 1;
            int[] a1 = { 17, 0, 0, 0, 0, 0 };
            myElem.m = a1;
            Rule[7] = myElem;
            myElem.p = 6;
            myElem.l = 4;
            int[] a2 = { 16, 8, 2, 9, 0, 0 };
            myElem.m = a2;
            Rule[8] = myElem;
            myElem.p = 6;
            myElem.l = 2;
            int[] a3 = { 11, 5, 0, 0, 0 };
            myElem.m = a3;
            Rule[9] = myElem;
            myElem.p = 6;
            myElem.l = 2;
            int[] a4 = { 10, 5, 0, 0, 0, 0 };
            myElem.m = a4;
            Rule[10] = myElem;
            myElem.p = 6;
            myElem.l = 2;
            int[] a5 = { 4, 5, 0, 0, 0, 0 };
            myElem.m = a5;
            Rule[11] = myElem;
            myElem.p = 5;
            myElem.l = 2;
            int[] a6 = { 14, 5, 0, 0, 0, 0 };
            myElem.m = a6;
            Rule[12] = myElem;
            myElem.p = 5;
            myElem.l = 2;
            int[] a7 = { 15, 5, 0, 0, 0, 0 };
            myElem.m = a7;
            Rule[13] = myElem;
            myElem.p = 5;
            myElem.l = 2;
            int[] a8 = { 12, 5, 0, 0, 0, 0 };
            myElem.m = a8;
            Rule[14] = myElem;
            myElem.p = 5;
            myElem.l = 2;
            int[] a9 = { 13, 5, 0, 0, 0, 0 };
            myElem.m = a9;
            Rule[15] = myElem;
        }
        //Мето выввода результата
        public void StartUP(RichTextBox richTextAnalysisUp, TextBox textCompiler, string text_start)
        {
            ReadGrammatics read_grammatics = new ReadGrammatics();
            arrZ = read_grammatics.Read_ControlTable("TableUP.txt");
            read_grammatics.Read_RegulationsNN();
            arrWords = read_grammatics.ListGrammaticsNN;
            Initalize();
            ClearArray();
            Up(text_start, richTextAnalysisUp, textCompiler);
        }
        public void ClearArray()
        {
            Array.Clear(arrS, 0, arrS.Length);
            Array.Clear(arr, 0, arr.Length);
            Array.Clear(Rules, 0, Rules.Length);
            str = "";
        }
        public void Print(int yy, int zz, int xx, RichTextBox richTextAnalysisUp, TextBox textCompiler)
        {
            int i2 = yy;
            string s1 ="", s2, s3;
            while (i2 <= indarr)
            {
                s1 = s1 + arrWords[arr[i2].number].m_name + " ";
                i2 = i2 + 1;
            }
             richTextAnalysisUp.Text += "Строка:" + s1 + '\n';
            s2 = ""; i2 = 0;
            while (i2 <= zz)
            {
                s2 = s2 + arrWords[arrS[i2].number].m_name + " ";
                i2 = i2 + 1;
            }
             richTextAnalysisUp.Text += "Магазин:" + s2 + '\n';
            s3 = ""; i2 = 1;
            while (i2 <= xx)
            {
                s3 = s3 + (Rules[i2] + 1).ToString() + " ";
                i2 = i2 + 1;
            }
             richTextAnalysisUp.Text += "Правила:" + s3 + '\n';
             richTextAnalysisUp.Text += "      " + '\n';
        }
        public void MyCompil(int pp, int ts1)
        {
            pp = pp + 1;
            if (pp == 1)
                arrS[ts1 - 5].m_temp = "for ( " + arrS[ts1 - 5].m_temp + arrS[ts1 - 4].m_temp + "; " + arrS[ts1 - 2].m_temp + "; " + arrS[ts1 - 1].m_temp + " ) {" + arrS[ts1].m_temp + "} ;";
            if (pp == 2)
                arrS[ts1 - 6].m_temp = "for ( " + arrS[ts1 - 6].m_temp + arrS[ts1 - 5].m_temp + "; " + arrS[ts1 - 3].m_temp + "; " + arrS[ts1 - 2].m_temp + " ) {" + arrS[ts1 - 1].m_temp + "} ;" + Environment.NewLine + arrS[ts1].m_temp;
            if (pp == 4)
                arrS[ts1 - 4].m_temp = arrS[ts1 - 3].m_name + "[ " + arrS[ts1 - 1].m_temp + " ] = ";
            if (pp == 3)
                arrS[ts1 - 1].m_temp = arrS[ts1].m_name + " = ";
            if (pp == 6)
                arrS[ts1 - 1].m_temp = arrS[ts1 - 1].m_temp + " " + arrS[ts1].m_temp;
            if (pp == 8)
                arrS[ts1].m_temp = arrS[ts1].m_name;
            if (pp == 7)
                arrS[ts1].m_temp = arrS[ts1].m_name;
            if (pp == 11)
                arrS[ts1 - 1].m_temp = "! ( " + arrS[ts1].m_temp + " )";
            if (pp == 10)
                arrS[ts1 - 1].m_temp = "sqrt ( " + arrS[ts1].m_temp + " )";
            if (pp == 12)
                arrS[ts1 - 1].m_temp = arrS[ts1 - 1].m_temp + " " + arrS[ts1].m_temp;
            if (pp == 9)
                arrS[ts1 - 3].m_temp = arrS[ts1 - 3].m_name + "[ " + arrS[ts1 - 1].m_temp + " ] ";
            if (pp == 15)
                arrS[ts1 - 1].m_temp = arrS[ts1].m_temp + " != ";
            if (pp == 16)
                arrS[ts1 - 1].m_temp = arrS[ts1].m_temp + " ^ ";
            if (pp == 13)
                arrS[ts1 - 1].m_temp = arrS[ts1].m_temp + " * ";
            if (pp == 14)
                arrS[ts1 - 1].m_temp = arrS[ts1].m_temp + " / ";
        }
        public void algorithm(RichTextBox richTextAnalysisUp, TextBox textCompiler)
        {
            int Tm, Ts, koli, p10, pr11, pr12;
            Tm = 0; Ts = 0; indR = 0; int go = 0;
            arrS[0].number = 18;
            arrS[0].m_name = "$";
            Print(Tm, Ts, indR, richTextAnalysisUp, textCompiler);
            while (Tm <= indarr)
            {
                if (arr[Tm].number == 18)
                {
                    if (Ts == 1)
                    {
                        if ((arrS[Ts].number == 0) && (arrS[Ts - 1].number == 18))
                        {
                            go = 4;
                        }
                    }
                }
                if (((arrZ[arrS[Ts].number, arr[Tm].number] == 1) && go != 4) || ((arrZ[arrS[Ts].number, arr[Tm].number] == 2) && go != 4))
                {
                    Ts = Ts + 1;
                    arrS[Ts].number = arr[Tm].number;
                    arrS[Ts].m_name = arr[Tm].m_name;
                    Tm = Tm + 1;
                    Print(Tm, Ts, indR, richTextAnalysisUp, textCompiler);
                    go = 2;
                }
                if ((arrZ[arrS[Ts].number, arr[Tm].number] == 3) && go != 2 && go != 4)
                {
                    koli = 0;
                    while (arrZ[arrS[Ts - koli].number, arrS[Ts - koli + 1].number] != 1)
                    {
                        koli = koli + 1;
                    }
                    for (p10 = 0; p10 < 16; p10++)
                    {
                        if (Rule[p10].l == koli && go != 2)
                        {
                            pr11 = 0;
                            for (pr12 = 0; pr12 < koli; pr12++)
                            {
                                if (Rule[p10].m[pr12] == arrS[Ts - koli + 1 + pr12].number)
                                {
                                    pr11 = pr11 + 1;
                                }
                            }
                            if (pr11 == koli)
                            {
                                MyCompil(p10, Ts);
                                Ts = Ts - koli + 1;
                                arrS[Ts].number = Rule[p10].p - 1;
                                arrS[Ts].m_name = arrWords[(arrS[Ts].number)].m_name;
                                indR = indR + 1;
                                Rules[indR] = p10;
                                Print(Tm, Ts, indR, richTextAnalysisUp, textCompiler);
                                go = 2;
                            }
                        }
                    }
                }
                if (go != 2 && go != 4)
                {
                    richTextAnalysisUp.Text = "Ошибка при выполнении восходящего разбора!";
                    textCompiler.Text = "";
                    go = 3;
                    Tm = 10000;
                    ClearArray();
                }
                if (go != 3)
                {
                    textCompiler.Text = arrS[1].m_temp;
                }
                if (go == 4)
                {
                    Tm = 10000;
                    ClearArray();
                }
                go = 0;
            }
        }
        public bool IsNumber(string str2, string dopstr, int k)
        {
            int pr2 = 0;
            for (int i = 0; i < dopstr.Length; i++)
            {
                if (str2[k + 1] == dopstr[i]) pr2++;
            }
            return (pr2 == 0) ? false : true;
        }

        public int IsThisNumber(string str1, int nach1, int kon1)
        {
            int jjj, pr3;
            if (str1.Substring(nach1, kon1 + 1 - nach1) == " true" || str1.Substring(nach1, kon1 + 1 - nach1) == " false")
            {
                return myElement(str1.Substring(nach1, kon1 + 1 - nach1), 17);
            }
            else
                if (IsNumber(str1, "0123456789", nach1) == true)
                {
                    pr3 = 0;
                    for (jjj = nach1; jjj < kon1; jjj++)
                    {
                        if (IsNumber(str1, "0123456789.Ee-", jjj) == true) pr3 = pr3 + 1;
                    }
                    if (pr3 == kon1 - nach1)
                    {
                        return myElement(str1.Substring(nach1, kon1 + 1 - nach1), 17);
                    }
                    else
                    {
                        MessageBox.Show("Нужно вводить вещественные" + '\n' + " числа с порядком!" + '\r' + "Ошибка --> " + str1.Substring(nach1, kon1 + 1 - nach1));
                        str = "";
                        return -1;
                    }
                }
                else { return 0; }
        }
        public int myElement(string my_word, int index)
        {
            myElemwt.number = index;
            myElemwt.m_name = my_word;
            arr[indarr] = myElemwt;
            indarr = indarr + 1;
            return 1;
        }
        //Метод Оператора
        public int IsThisOperator(string str1, int nach1, int kon1)
        {
            int ii, jj, kol;
            if (str1[nach1] == ' ') nach1 += 1;
            for (ii = 6; ii < 16; ii++)
            {
                if (kon1 - nach1 + 1 == (arrWords[ii].m_name).Length)
                {
                    kol = 0;
                    for (jj = 1; jj <= (arrWords[ii].m_name).Length; jj++)
                    {
                        if (str1[nach1 + jj - 1] == arrWords[ii].m_name[jj - 1]) kol = kol + 1;
                    }
                    if (kon1 - nach1 + 1 == kol)
                    {
                        return myElement(arrWords[ii].m_name, ii);
                    }
                }
            }
            return 0;
        }
        // Метод восходящего разбора
        public void Up(string text, RichTextBox richTextAnalysisUp, TextBox textCompiler)
        {
            int nach = 0, probel = 1, dop1, k = 0;
            arrS[1].m_temp = "";
            richTextAnalysisUp.Clear();
            textCompiler.Clear();
            str += text + " ";
            indarr = 0; indR = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    if (probel == 0)
                    {
                        probel = 1;
                        if (IsThisOperator(str, nach, i - 1) == 0)
                        {
                            dop1 = IsThisNumber(str, nach, i - 1);
                            if (dop1 == 0)
                            {
                                if ((str.Substring(nach + 1, i - nach - 1)).Length <= 8 && (str.Substring(nach + 1, i - nach - 1)).Length > 0)
                                {
                                    myElement(str.Substring(nach, i + 1 - nach), 16);
                                }
                                else
                                {
                                    if ((str.Substring(nach + 1, i - nach - 1)).Length > 8)
                                    {
                                        k = 1;
                                        MessageBox.Show("Длина идентификатора не может быть больше 8 символов!" + '\n' + "Ошибка --> " + str.Substring(nach, i + 1 - nach));
                                    }
                                    if ((str.Substring(nach + 1, i - nach - 1)).Length == 0)
                                    {
                                        k = 1;
                                        MessageBox.Show("Длина идентификатора не может быть меньше 0 символов!" + '\n' + "Сивмол № " + (i + 1).ToString() + " является пробелом.");
                                    }
                                }
                            }
                            if (dop1 == -1)
                            {
                                k = 1;
                            }
                        }
                    }
                if (k != 1)
                {
                    if (probel == 1) nach = i;
                    probel = 0;
                }
            }
            if (k != 1)
            {
                myElement("$", 18);
                algorithm( richTextAnalysisUp, textCompiler);
            }
        }
    }
}
