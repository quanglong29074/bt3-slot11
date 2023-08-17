using ConsoleApp1.demo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.demo3;
using ConsoleApp1.demo4;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VoidStringDelegate vsd = new VoidStringDelegate(DemoDelegate.Goodbye);
            vsd("Xin chào");
            VoidStringDelegate vsd1 = new VoidStringDelegate(new DemoDelegate().SayHello);
            vsd1("Xin chào");

            var t2 = new DemoDelegate();
            t2.SayHello("T2210A");
            DemoDelegate.Goodbye("T2210A");

            VoidStringDelegate vsd2 = new VoidStringDelegate(new DemoDelegate().SayHello);
            vsd2 += DemoDelegate.Goodbye;
            vsd2 += DemoDelegate.Goodbye;
            vsd2 += DemoDelegate.Goodbye;
            vsd2 += DemoDelegate.Goodbye;
            vsd2 += DemoDelegate.Goodbye;

            vsd2("T2210A");

            DisplayMessage("Hello word", DemoDelegate.Goodbye);

            VoidStringDelegate vsd3 = delegate (string s)
            {
                Console.WriteLine(s);
            };
            VoidStringDelegate vsd4 = s => Console.WriteLine(s);

            vsd3("aaa");
            vsd4("sdes");
        }

       static void DisplayMessage(string message, VoidStringDelegate callback)
        {
            callback(message);
        }
        static void Main4(string[] args)
        {
          Teacher t = new Teacher();
            t.Tels.Add("03493842");
            t.Tels.Add("49847394");
            Console.WriteLine(t.Tels[0]);
            t[0] = "43729439239";
            Console.WriteLine(t[0]);
        }
        static void Main2(string[] args)
        {
            Student s = new Student();
            s.Name = "Nguyễn Văn An";
            s.Eat("aaaaa");
            s.Eat();

            List<Student> listStudents = new List<Student>();
            listStudents.Add(s);
        }
        static void Main3(string[] args)
        {
            int x = 10;
            float y = 3.14159f;
            double z = 3.1415;

            Console.WriteLine("Result:" + (x + y + z));

            var k = 19;
            var input = Console.ReadLine();// 128 -> string 128
            int inputInt = Convert.ToInt32(input);
          

            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i]
            }
            foreach (int ar in arr)
            {
                //ar <=> arr[i]
            }
        }
    }
}
