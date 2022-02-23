using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class StudentForm : Form
    {
        //Student student;
        public StudentForm()
        {
            InitializeComponent();
        }
        //Profile UserControl
        ComboBox Profile_ComboBoxCourses;
        Label Profile_label_StudentName;

        //Exam UserControl
        ComboBox Exam_ComboBoxCourses;
        Button Exam_button_StartExam;

        Course Exam_Course; 

        //Grade UserControl
        DataGridView Grades_gridView;

        private void StudentForm_Load(object sender, EventArgs e)
        {
            #region Gui
            // User Control
            profile1.Visible = false;
            showCoursesGrades1.Visible = false;
            chooseExamCourseForm1.Visible = false;

            //Buttons BackGround
            button_profile.FlatStyle = FlatStyle.Flat;
            button_profile.BackColor = Color.Transparent;
            button_profile.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 1, 1, 1);

            button_Exam.FlatStyle = FlatStyle.Flat;
            button_Exam.BackColor = Color.Transparent;
            button_Exam.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 1, 1, 1);

            button_ShowGrades.FlatStyle = FlatStyle.Flat;
            button_ShowGrades.BackColor = Color.Transparent;
            button_ShowGrades.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 1, 1, 1);

            #endregion

            #region Load Component User Control
            LoadControlProfile();
            LoadControlsExam();
            LoadControlsShowGrade();
            #endregion


        }


        private void button_profile_Click(object sender, EventArgs e)
        {
            #region GUI UserControl
            profile1.Visible = true;
            showCoursesGrades1.Visible = false;
            chooseExamCourseForm1.Visible = false;
            #endregion

        }

        private void button_Exam_Click(object sender, EventArgs e)
        {
            #region GUI UserControl
            profile1.Visible = false;
            showCoursesGrades1.Visible = false;
            chooseExamCourseForm1.Visible = true;
            #endregion

        }

        private void button_ShowGrades_Click(object sender, EventArgs e)
        {
            #region GUI UserControl
            profile1.Visible = false;
            showCoursesGrades1.Visible = true;
            chooseExamCourseForm1.Visible = false;
            #endregion

        }
        private void AddDataComboBoxCourses_Profile(ComboBox comboBox,List<Course> coursesList)
        {
            foreach (Course course in coursesList)
            {
                comboBox.Items.Add(course.Name);
            }
        }

        #region Gui UserControl
        private void LoadControlProfile()
        {
            UserControl userControl_Profile = profile1;
            userControl_Profile.Controls.Contains(new ComboBox());
            Control[] Controls = userControl_Profile.Controls.Find("comboBox1", false);
            Profile_ComboBoxCourses = (ComboBox)Controls[0];

            UserControl userControl_Profile1 = profile1;
            userControl_Profile1.Controls.Contains(new Label());
            Control[] Controls1 = userControl_Profile1.Controls.Find("label_StudentName", false);
            Profile_label_StudentName = (Label)Controls1[0];
        }
        private void LoadControlsExam()
        {
            UserControl userControl_Exam = chooseExamCourseForm1;
            userControl_Exam.Controls.Contains(new ComboBox());
            Control[] Controls = userControl_Exam.Controls.Find("comboBox1", false);
            Profile_ComboBoxCourses = (ComboBox)Controls[0];
            Profile_ComboBoxCourses.SelectedIndexChanged += ComboBox_item_Change;

            UserControl userControl_Exam2 = chooseExamCourseForm1;
            userControl_Exam2.Controls.Contains(new Button());
            Control[] Controls2 = userControl_Exam2.Controls.Find("button_StartExam", false);
            Exam_button_StartExam = (Button)Controls2[0];
            Exam_button_StartExam.Click += Control_button_StartExam_Click;
        }
        void ComboBox_item_Change(object sender, EventArgs e)
        {
            int selectedIndex = Exam_ComboBoxCourses.SelectedIndex;
            //Exam_Course = student.Courses[selectedIndex];
        }
        void Control_button_StartExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm f1 = new ExamForm();
            f1.ShowDialog();
            this.Close();
        }
        private void LoadControlsShowGrade()
        {
            UserControl userControl_Grade= showCoursesGrades1;
            userControl_Grade.Controls.Contains(new DataGridView());
            Control[] Controls = userControl_Grade.Controls.Find("dataGridView1", false);
            Grades_gridView = (DataGridView)Controls[0];
        }


        #endregion

        private void showCoursesGrades1_Load(object sender, EventArgs e)
        {

        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }

        private void label_StudentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
