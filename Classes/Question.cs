using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
   public enum type { TF , MCQ}
    public class Question
    {
        int ques_id;
        string question_content;
        int grade;
        type type;
       string model_ans;
        Course course;
        List<Choice> choices;
        List<Exam> exams;
        public int Ques_id { get; set; }
       public string Question_content { get; set; }
       public int Grade { get; set; }
        public type Type { get; set; }
       public string Model_ans { get; set; }
       public Course Course { get; set; }
       public List<Choice> Choices;
        
        public List<Exam> Exams { get; set; }
        public Question() { 
        
        
        }
        public Question(type type, int id, string question_content,int grade, string model_ans, Course course, List<Choice> choices, List<Exam> exams) {
            this.ques_id = id;
            this.question_content = question_content;
            this.grade = grade;
            this.type = type;
            this.model_ans = model_ans;
            this.course = course;
            this.choices = choices;
            this.exams = exams;

        
        }



    }
}
