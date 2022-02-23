using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Department
    {
        int dept_id;
        string description;
        string name;
        DateTime hire_date;
        List<Student> students;
        List<Instructor> instructors;
        Instructor manager;

        public int Dept_id{ get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime Hire_date { get; set; }
        public Instructor Manager { get; set; }


        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }

        public Department() { }
        public Department(int _id,string _desc ,string _name,DateTime _hire_date ,List<Student> _students,List<Instructor> _instructors, Instructor _manager) {
            dept_id = _id;
            name = _name;
            description = _desc;
            hire_date = _hire_date;
            students = _students;
            instructors = _instructors;
            manager = _manager;

        
        }
    }
}
