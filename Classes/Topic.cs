using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
   public class Topic
    {
        int topic_id;
        string name;
        Course course;
        public int Topic_id { get; set; }
        public string Name { get; set; }
        public Course Course { get; set; }
        public Topic(int id , string name ,Course course) {
            topic_id = id;
            this.name = name;
            this.course = course;
        
        }

    }
}
