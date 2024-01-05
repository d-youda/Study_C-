using System;

namespace ControlStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요:");
            int num = Convert.ToInt32(Console.ReadLine()); 
            if(num > 90)
            {
                Console.WriteLine("우수");
                Console.WriteLine("수고하셨습니다.");
            }
            else if (num <= 90)
            {
                Console.WriteLine("보통");
                Console.WriteLine("좀 더 노력하세요.");
            }
        }
    }
}
