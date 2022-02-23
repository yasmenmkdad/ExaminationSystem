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
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void button_Exam_Click(object sender, EventArgs e)
        {


            student_panel.Visible = false;
            course_panel.Visible = false;
            examgeneration.Visible = true;
            


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }

        private void button_profile_Click(object sender, EventArgs e)
        {

            examgeneration.Visible = false;
            student_panel.Visible = false;
            course_panel.Visible = true;


        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

            course_panel.Visible = false;
            examgeneration.Visible = false;
           
            student_panel.Visible=false;
        }
        private void LoadControlProfile()
        {
            
        }

        private void button_StudInfo_Click(object sender, EventArgs e)
        {
            course_panel.Visible = false;
            examgeneration.Visible = false;
            student_panel.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            InstructorForm insform = new InstructorForm();
            insform.Close();
            form.Show();
           

        }

        private void studentgrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generateExam_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
