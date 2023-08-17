using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demo3
{
    public class CodeTeacher : Teacher, ITeacher
    {
        private int age;
        public CodeTeacher()
        {

        }
        public CodeTeacher(string name, int age): base(name) 
        {
            this.age = age;
        }

        public override void teach()
        {
            base.lunch();
        }

        public new void lunch()
        {

        }
        
        public void Eat()
        {

        }
    }
}
