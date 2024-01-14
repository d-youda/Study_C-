using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] kor = new int[10];//10개의 element 있는 int형 배열
            //kor[0] = 10;
            //kor[1] = 20;
            int[] kor = new int[] { 10, 20, 30, 60, 100, 70 };
            string[] name = new string[] { "lee", "kim", "Yu" };

            Console.WriteLine("kor[0]: "+ kor[0]);
            Console.WriteLine(name[0]+"의 국어성적" + kor[0]+"점");
            Console.ReadKey();

            int[,] kor_eng = new int[10, 10];//2차원 배열
            int[,] kor_eng2 = new int[,] { { 10, 20, 30 }, { 30, 90, 100 }, { 90, 100, 70 } };
            int[,,] kor_eng_math = new int[,,] { { { } } };//3차원 배열

            Studnet[] students = new Studnet[35];//학생 10명
            students[0] = new Studnet("lee");//1번 학생
            students[1] = new Studnet("kim");//2번 학생
            students[33] = null;//밑에는 예비라 안써유

            Studnet[] first_grade_student = new Studnet[30];
            Studnet[] second_grade_student = new Studnet[30];
            Studnet[] thirdt_grade_student = new Studnet[30];


        }
        class Studnet
        {
            private string name;
            private int kor;
            public Studnet(string name)
            {
                this.name = name;
            }
        }
    }
}
