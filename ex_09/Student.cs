using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_09
{
    class Student : Human //Student가 Human, Animal 상속 -> 본인 조상 클래스는 다 상속받음
    {
        public int Grade { get; set; }
        public int StudentClass { get; set; }
        public int StudentId { get; set; }
        public Student()
        {
            Console.WriteLine("Student:"+this.ToString());
        }

    }
}
