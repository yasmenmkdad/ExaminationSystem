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
    public partial class FormReport3 : Form
    {
        int InstructorID;
        public FormReport3(int InsID)
        {
            InitializeComponent();
            InstructorID = InsID;
        }

        private void FormReport3_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            CrystalReport31.SetParameterValue("@insId", InstructorID);
        }
    }
}
