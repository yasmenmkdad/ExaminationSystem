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
    public partial class ExamForm : Form
    {
        int indexOfQuestion;
        Exam exam;

        #region Test
        //string Answer;
        //List<Question> questionsList; 
        #endregion

        public ExamForm() 
        {
            InitializeComponent();
            indexOfQuestion = 0;
        }


        protected void Choicebutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Red;
            //Answer = button.Text.ToString();   // Student Answer
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            #region GUI
            button_RigthArrow.FlatStyle = FlatStyle.Flat;
            button_LeftArrow.FlatStyle = FlatStyle.Flat;
            #endregion


            button_LeftArrow.Visible = false;
            //LoadScreenQuestion();

        }

        private void button_RigthArrow_Click(object sender, EventArgs e)
        {
            if (button_RigthArrow.Text == "Submit")
            {
                MessageBox.Show("best wishes for success");
                this.Hide();
                StudentForm f1 = new StudentForm();
                f1.ShowDialog();
                this.Close();
                return;
            }
            RemoveButtons();
            indexOfQuestion++;
            //LoadScreenQuestion();
            button_LeftArrow.Visible = true;
            if (indexOfQuestion == exam.Questions.Count - 1){ 
                button_RigthArrow.Text = "Submit";
            }
        }

        private void button_LeftArrow_Click(object sender, EventArgs e)
        {
            RemoveButtons();
            indexOfQuestion--;
            //LoadScreenQuestion();
            if (indexOfQuestion == 0)
            {
                button_LeftArrow.Visible = false;
            }
        }

        private void LoadScreenQuestion(Question question)
        {
            int x = 420, y = 300;
            label_Question.Text = question.Question_content;
            List<RJButton> buttons = new List<RJButton>();
            for (int i = 0; i < exam.Questions[indexOfQuestion].Choices.Count; i++)
            {
                RJButton button = new RJButton();
                button.Location = new Point(x, y);
                button.BackColor = Color.Maroon;
                button.Text = exam.Questions[indexOfQuestion].Choices.ElementAt(i).choice_content;
                button.Click += new EventHandler(Choicebutton_Click);
                this.Controls.Add(button);
                y += button.Height + 20;
            }

        }
        private void RemoveButtons()
        {
            foreach (Control item in this.Controls.OfType<RJButton>().ToList())
            {
                this.Controls.Remove(item);
            }
        }
    }
}
