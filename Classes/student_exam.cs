using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
   public class student_exam
    {
        string ans;
        int grade;
        Question question;
        Exam exam;
        Student student;

       public string Ans { get; set; }
       public int Grade { get; set; }
       public Question Question { get; set; }
       public Exam Exam { get; set; }
       public Student Student { get; set; }
        public student_exam() { 
        
        }
        public student_exam(string ans,int grade, Question ques,Exam exam, Student stud)
        {
            this.ans = ans;
            this.grade = grade;
            this.question = ques;
            this.exam = exam;
            this.student = stud;


        }
    }
}
