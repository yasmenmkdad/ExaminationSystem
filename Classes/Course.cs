using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
   public class Course
    {
        int course_id;
        string name;
        int duration;
        List<Topic> topics;
        List<Question> questions;
        List<Exam> exams;
        List<Instructor> instructors;
        List<Student> students;
        public int Course_id{ get; set; } 
       public string Name  { get; set; }
       public int Duration { get; set; }
       public List<Topic> Topics;
        public List<Question> Questions { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Student> Students { get; set; }
        public Course() {
             
          name="";
           duration=0;
        }
        public Course(int id, string name, int duration, List<Topic> topics, List<Exam> exams, List<Question> questions, List<Instructor> instructors, List<Student> students) {
            course_id = id;
            this.name = name;
            this.duration = duration;
            this.topics = topics;
            this.exams = exams;
            this.questions = questions;
            this.instructors = instructors;
            this.students = students;
        }

    }
}
