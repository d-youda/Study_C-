using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddelSchoolStudentManagement
{
    public class Student
    {   
        public Grade grade { get; set; }
        public StudentClass stClass { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int tall { get; set; }
        public Sex sex { get; set; }
        
        public Student(Grade grade, StudentClass stClass, int num, string name,int age, int tall, Sex sex )
        {
            this.grade = grade;
            this.stClass = stClass;
            this.num = num;
            this.name = name;
            this.age = age;
            this.tall = tall;
            this.sex = sex;

        }

        public Student(Grade grade, StudentClass stClass, int num, string name)
        : this(grade, stClass, num, name, 0, 0, Sex.미확인)
        {

        }
        //필수 항목들(학년/반/번호/이름) 꼭 들어가지 않으면 클래스 생성될 수 없도록 생성자 작성
    }
}
