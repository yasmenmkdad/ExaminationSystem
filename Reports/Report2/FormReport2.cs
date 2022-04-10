using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class FormReport2 : Form
    {
        int StudentID;
        public FormReport2(int stdID)
        {
            InitializeComponent();
            StudentID = stdID;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            CrystalReport2_11.SetParameterValue("@stdId",StudentID);
        }
    }
}
