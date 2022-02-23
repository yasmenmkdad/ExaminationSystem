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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_Instructors_Click(object sender, EventArgs e)
        {
            data_grd.Visible = true;
            save.Visible= true;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Admin admin = new Admin();
            admin.Close();
            form.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            data_grd.Visible = false;
            save.Visible = false;
        }

        private void btn_Students_Click(object sender, EventArgs e)
        {
            data_grd.Visible = true;
            save.Visible = true;
        }

        private void btn_Courses_Click(object sender, EventArgs e)
        {
            data_grd.Visible = true;
            save.Visible = true;
        }
    }
}
