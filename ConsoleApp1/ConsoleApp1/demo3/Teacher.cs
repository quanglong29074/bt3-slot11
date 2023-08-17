using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demo3
{
    public class Teacher : AbstractTeacher
    {
        private List<string> tels;
        private string name;
        public Teacher() 
        { 
            tels = new List<string>();
        }

        public Teacher(string name)
        {
            this.name = name;
        }
        public List<string> Tels
        {
            get =>tels; 
            set => tels = value;
        }

        public string this[int index]
        {
            get => tels[index];
            set => tels[index] = value;
        }

        public virtual void teach()
        {
            Console.WriteLine("Teach.....");
        }

        public void lunch()
        {

        }

        public override void Run()
        {

        }

    }
}
