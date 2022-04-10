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
    public partial class FormReport4 : Form
    {
        int CourseID;
        public FormReport4(int crsID)
        {
            InitializeComponent();
            CourseID = crsID;
        }

        private void FormReport4_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            CrystalReport41.SetParameterValue("@crsId", CourseID);
        }
    }
}
