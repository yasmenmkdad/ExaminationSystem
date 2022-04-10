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
    public partial class FormReport5: Form
    {
        int ExamID;
        public FormReport5(int ExID)
        {
            InitializeComponent();
            ExamID = ExID;
        }

        private void FormReport5_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            //CrystalReport51.SetParameterValue("@examNo",ExamID);
        }
    }
}
