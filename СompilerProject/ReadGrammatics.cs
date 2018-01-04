using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace СompilerProject
{
    public struct GrammaticsDown
    {
        public string m_name;
        public int number;
    }
    class ReadGrammatics
    {
       GrammaticsDown rule_down = new GrammaticsDown();
       List<GrammaticsDown> regulations = new List<GrammaticsDown>();
       List<GrammaticsDown> regulationsN = new List<GrammaticsDown>();
       List<GrammaticsDown> regulationsNN = new List<GrammaticsDown>();
        int [,] rule_table;
        public void Read_Regulation()
        {
            //Gr.txt
            using (StreamReader read_regulation = new StreamReader("Gr.txt"))
            {
                int k = 0;
                while(!read_regulation.EndOfStream)
                {
                    string[] str = read_regulation.ReadLine().Split(new[] { "->"}, StringSplitOptions.RemoveEmptyEntries);
                    rule_down.m_name = str[1];
                    rule_down.number = k+1;
                    regulations.Add(rule_down);
                    k++;
                }
            }
        }

        public void Read_ControlTable(string file_name)
        {
            //ControlTable.txt
           // Array.Clear(rule_table, 0, rule_table.Length);
            int widht = System.IO.File.ReadAllLines(file_name).Length;
            int length;
            using (StreamReader read_table = new StreamReader(file_name))
            {
                string[] str1 = read_table.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                length = str1.Length;
            }
            rule_table = new int[widht+1, length];
            int str_number=0;
            using (StreamReader read_table = new StreamReader(file_name))
            {
                while (!read_table.EndOfStream)
                {
                    string[] str = read_table.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    for(int k=0; k< length; k++)
                    {
                        rule_table[str_number, k] = int.Parse(str[k]);
                    }
                    str_number++;
                }
            }
        }

        public void Read_ControlTable1()
        {
            //Table.txt
            using (StreamReader read_tab = new StreamReader("Table.txt"))
            {
                int k = 0;
                string[] str = read_tab.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int z = 0; z < str.Length; z++ )
                {
                    rule_down.m_name = str[z];
                    rule_down.number = z+1;
                    regulationsN.Add(rule_down);
                }
                while (!read_tab.EndOfStream)
                {
                    str = read_tab.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    rule_down.m_name = str[0];
                    rule_down.number = k+1;
                    regulationsNN.Add(rule_down);
                    k++;
                }
            }
        }

        public List<GrammaticsDown> ListGrammatics
        {
            get { return regulations; }
            set { regulations = value; }
        }
        public List<GrammaticsDown> ListGrammaticsN
        {
            get { return regulationsN; }
        }
        public List<GrammaticsDown> ListGrammaticsNN
        {
            get { return regulationsNN; }
        }
        public int[,] RuleTable
        {
            get { return rule_table; }
        }

    }
}
