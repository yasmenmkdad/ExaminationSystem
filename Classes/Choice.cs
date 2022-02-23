using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Choice
    {
        Question question;///?????????????????????????????///
        public string choice_content;

        public Question Question { get; set; }
        public string Choice_content { get; set; }

        public Choice() { }
        public Choice(Question question,string choice_content) {
            this.question = question;
            this.choice_content = choice_content;
        }


    }
}
