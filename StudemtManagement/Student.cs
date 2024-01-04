using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudemtManagement
{
    public class Student
    {
        //필드, 프로퍼티
        public Grade stGrade { get; set; }// PK
        public StudentClass StClass { get; set; }//PK
        public int stNumber { get; set; }//PK
        public string Name { get; set; } //NotNull
        public string Address { get; set; }
        public Sex stSex { get; set; }//namespace 전반에 걸쳐 보임

        //생성자
        public Student(Grade grade, StudentClass stclass, int stnumber, string name, Sex sex)

        {
            this.stGrade = grade;
            this.StClass = stclass;
            this.stNumber = stnumber;
            this.Name = name;
            this.stSex = sex;
        }
        public Student(Grade grade, StudentClass stclass ,int stnumber,string name)
            : this(grade, stclass, stnumber, name, Sex.미확인)
        {
            
        }
        public void PrintMe()
        {
            Console.WriteLine(stGrade+": "+StClass+":"+stNumber+"["+Name+"]");
        }


        //메소드

    }
}
