using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace СompilerProject
{
    public struct Grammatics
    {
        public string m_name;
        public string m_temp;
        public int number;
    }
    class ReadGrammatics
    {
       Grammatics rule_down = new Grammatics();
       List<Grammatics> regulations = new List<Grammatics>();
       List<Grammatics> regulationsN = new List<Grammatics>();
       List<Grammatics> regulationsNN = new List<Grammatics>();
        int [,] rule_table;
        public void Read_Regulation()
        {
            //Gr.txt
            using (StreamReader read_regulation = new StreamReader("GrVr3.txt"))
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

        public int[,] Read_ControlTable(string file_name)
        {
            int widht = System.IO.File.ReadAllLines(file_name).Length;
            int length = Length_line_parser(file_name, ',');
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
            return rule_table;
        }
        public int Length_line_parser(string file_name, char symbol)
        {
            using (StreamReader read_table = new StreamReader(file_name))
            {
                string[] str = read_table.ReadLine().Split(new[] { symbol }, StringSplitOptions.RemoveEmptyEntries);
                return str.Length;
            }
        }
        public void Read_ControlTable1()
        {
            //Table.txt
            using (StreamReader read_tab = new StreamReader("TabelGrVr3.txt"))
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
        public void Read_RegulationsNN(string file_name)
        {
            using (StreamReader read_tab = new StreamReader(file_name))
            {
                int k = 0;
                while (!read_tab.EndOfStream)
                {
                    string[] str = read_tab.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    rule_down.m_name = str[0];
                    rule_down.number = k + 1;
                    regulationsNN.Add(rule_down);
                    k++;
                }
            }
        }
        public List<Grammatics> ListGrammatics
        {
            get { return regulations; }
            set { regulations = value; }
        }
        public List<Grammatics> ListGrammaticsN
        {
            get { return regulationsN; }
        }
        public List<Grammatics> ListGrammaticsNN
        {
            get { return regulationsNN; }
        }
    }
}
