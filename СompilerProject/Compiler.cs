using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СompilerProject
{
    //dev
    public partial class Compiler : Form
    {
        AnalysisDown analysis_down = new AnalysisDown();
        AnalysisUp analysis_up = new AnalysisUp();
        AnalysisUpOrg analysis_up_org = new AnalysisUpOrg();
        public Compiler()
        {
            InitializeComponent();
         //   textInputData.Text = "else := id const then := id const if & id const";
            textInputData.Text = "else := id [ id ] const then := id [ id ] const if < id id else := id [ id ] const then := id [ id ] const if id := id [ id ] const";
            //textInputData.Text = "else := id [ id ] const then := id [ id ] const if < id id else := id [ id ] const then := id [ id ] const if < id id";
            //textInputData.Text = "set k 6E-1 for neq div k 9E-3 5E-2 set k mult k 3E-15 set x [ mult k k ] div mult x [ div k k ] or y y mult c sqrt z [ k ] set i 5E-1 for neq i 4E-17 set i div i 5E-8 set y [ div i mult i i ] div mult x [ div i i ] mult 5E-2 sqrt y [ i ] not y [ i ]";
        }

        private void butResult_Click(object sender, EventArgs e)
        {
            analysis_down.AnalysisStart(richTextAnalysisDown, textInputData.Text);
           // analysis_up.StartUP(richTextAnalysisUp, textCompiler, textInputData.Text);
          //  analysis_up_org.StartUP(richTextAnalysisUp, textCompiler, textInputData.Text);

        }

        private void richTextAnalysisDown_TextChanged(object sender, EventArgs e)
        {
            richTextAnalysisDown.SelectionStart = richTextAnalysisDown.Text.Length;
            richTextAnalysisDown.ScrollToCaret();
        }

        private void richTextAnalysisUp_TextChanged(object sender, EventArgs e)
        {
            richTextAnalysisUp.SelectionStart = richTextAnalysisUp.Text.Length;
            richTextAnalysisUp.ScrollToCaret();
        }
    }
}
