using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_programs1.Properties
{
    class student
    {
        int sid;
        string sname;
        string clg;
        public student()
        {
            sid = 1;
            sname = "srinu";
            clg = "RRR";
        }
        public student(int sid, string sname, string clg)
        {
            this.sid = sid;
            this.sname = sname;
            this.clg = clg;
        }
        public student(int sid,string sname)
        {
            this.sid = sid;
            this.sname=sname;
            clg = "not provided";
        }
        public student(int sid)
        {
            this.sid=sid;
            name="not provided";
            clg="not provide";
        }
        public void stddetails()
        {
            Console.WriteLine("Student id is " + sid);
            Console.WriteLine("Student name is " + sname);
            Console.WriteLine("Student college is " + clg);
            Console.WriteLine("\n");
        }
    }
    internal class constructor_overloading
    {
        static void Main(string[] args)
        {
            student std=new student();
            std.stddetails();
            student std1=new student(102,"srinu","eee");
            std1.stddetails();
            student std2 = new student(102, "srinu");
            std2.stddetails();
            student std3=new student(105);
            std3.stddetails();
        }
    }
}
