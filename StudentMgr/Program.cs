using dhyu; //밖에 있는 namespace 가져옴 

namespace StudentMgr
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student1 = new Student();//클래스 인스턴스 변수
            student1.Name = "홍길동";
            System.Console.WriteLine(student1.Name);
            

        }
    }
}
