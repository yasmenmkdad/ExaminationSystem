using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace ExaminationSystem
{
    public partial class FormReport6 : Form
    {
        int ExamID, StudentID;
        public FormReport6(int ExID,int StdtID)
        {
            InitializeComponent();
            ExamID = ExID;
            StudentID = StdtID;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormReport6_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;

            CrystalReport6_11.SetParameterValue("@examNo", ExamID);
            CrystalReport6_11.SetParameterValue("@stdNo", StudentID);


        }
    }
}
