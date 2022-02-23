using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Instructor :Person
    {
        string name;
        int salary;

        List<Course> courses;
        public string Name { get; set; }
        public double Salary { get; set; }
        public List<Course> Courses { get; set; }
        public Instructor(){ }
        public Instructor(int id,string email ,string password,string _name, List<Course> courses, int _salary, Department department):base(id,email,password, department) {
            name = _name;
            salary = _salary;
            this.courses = courses;

        }

    }
}
