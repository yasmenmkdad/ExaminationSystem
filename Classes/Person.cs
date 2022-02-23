using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
   public class Person
    {
        int id;
        string email;
        string password;
        Department department;

        public int Id { get; set; }
        public string Email { get; set; }

        public int Password { get; set; }
        public Department Department { get; set; }

        public Person() { }
        public Person(int _id,string _email,string _password,Department _dept) {
            id = _id;
            email = _email;
            password = _password;
            department = _dept;
        }


    }
}
