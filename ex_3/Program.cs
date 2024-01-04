using System;
namespace ex_3
{
    internal class Program
    {
        static int a = 0;//멤버 변수 (클래스 내부 선언)
        static void Main(string[] args)
        {
            //지역 변수 (메소드 내 선언됨)
            int a=1;
            Console.WriteLine("a=" + a);
            function1(a);
            Console.WriteLine("a=" + a);
        }

        static private void function1(int a) 
        {
            a = 2;
        }
    }
}
