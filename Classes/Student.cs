using System;
using System.Collections.Generic;

namespace ExaminationSystem
{
    public class Student : Person
    {
        String first_name;
        string last_name;
        string address;
        int age;

        List<Course> courses;

        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; }
        public Student() { }


        public Student(int _id, string email,string password,string fname,string lname ,string _address,int _age,Department _department, List<Course> courses) :base(_id,email,password,_department) {
            first_name = fname;
            last_name = lname;
            address = _address;
            age = _age;
            this.courses = courses;
            



        }



    }
}
