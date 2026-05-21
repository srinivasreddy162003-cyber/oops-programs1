//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops_programs1.Properties
//{
//    class newclass1
//    {
//        int sid;
//        string sname;
//        static string sclg = "vignan university";
//        public newclass1(int sid, string sname)
//        {
//            this.sid = sid;
//            this.sname = sname;
//        }
//        public void stddetails()
//        {
//            Console.WriteLine("student id is " + sid);
//            Console.WriteLine("student name is " + sname);
//            Console.WriteLine("student college name is " + sclg);
//            Console.WriteLine("\n");
//        }
//    }
//    internal class constructs
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter number of students ");
//            int N = int.Parse(Console.ReadLine());

//            newclass1[] std = new newclass1[N];
//            for (int i = 0; i < N; i++)
//            {
//                Console.WriteLine("\n Enter students details");

//                Console.WriteLine("enter student id");
//                int id = int.Parse(Console.ReadLine());

//                Console.WriteLine("enter student name");
//                string name = Console.ReadLine();

//                std[i] = new newclass1(id, name);

//            }
//            Console.WriteLine("student details are");
//            for (int i = 0; i < std.Length; i++)
//            {
//                std[i].stddetails();
//            }

//        }
//    }
//}
