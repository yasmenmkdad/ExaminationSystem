using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Exam
    {
        int ex_id;
        int grade;
        Course course;
        List<Question> questions;

        public int Ex_id { get; set; }
        public int Grade { get; set; }
        public Course Course { get; set; }
       public List<Question> Questions { get; set; }

        public Exam() { }
        public Exam(int id, int grade, Course course , List<Question> questions) {
            this.ex_id = id;
            this.grade = grade;
            this.course = course;
            this.questions = questions;

        }


    }
}
