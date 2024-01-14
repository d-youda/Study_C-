using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ex_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 클래스 상속
            /*
            * 부모 클래스는 자식 클래스를 가리킬 수 있다.
            * 그러나 자식 클래스는 부모 클래스 +알파이기 떄문에 부모클래스를 가리킬 수 없다.
            * 자식클래스는 부모 클래스가 가지고 있지 않은 인스턴스, 함수등을 가질 수 있기 때문이다.
            */
            Human h1 = new Human();
            Student st1 = new Student();

            Human h2 = st1;// (o)
            //Student s2 = h1; // (x) 암시적 형변환이 불가능함
            //2. as 와 is
            Student s2 = h1 as Student;//as는 명시적 형변환이다.
            /*
             * as를 사용하는 형변환은 컴파일 당시에 일어난다.
             * ()를 사용하는 형변환은 동적 테스팅이기 때문에 실행 시에 일어난다.
             * 그래서, ()형변환인데 큰 데이터를 작은 데이터로 형변환 하는 경우, 컴파일 당시엔 오류가 나지 않지만, 실행 시에 에러가 뜬다.
             */
            //Student s3 = (Student)h1;//실행 시 에러

            bool ret1 = s2 is Animal;//boolean값을 return
            /*
             * is는 type을 물어보는 연산자이다.
             */

            Animal a = new Animal();
            Console.WriteLine("to string: " + a.ToString());//namespace : 협업 시 클래스 이름 중복 방지 -> 식별자로 쓰임
            //ToString : name space 까지 있는 full name 작성해줌
            Type type = a.GetType();

            Console.WriteLine("type: " + type);
            Console.WriteLine("type test: " + type.FullName);


            Animal c = new Animal();
            Animal b = new Animal();

            Console.WriteLine("c equals b: " + c.Equals(b));//쌍둥이 둘이 같은 사람은 아니니까 false 나옴

            string sa = "Hello";
            string sb = "Hello";
            bool ref3 = sa.Equals(sb);//string이 equals 재정의함.-> 오버라이딩
            Console.WriteLine("two string equals: " + ref3);

            int ia = 5;
            int ib = 5;
            int ic = 4;
            bool iret = ia.Equals(ib);
            Console.WriteLine("1." + iret);
            bool iret2 = ia.Equals(ic);
            Console.WriteLine("1." + iret2);
            bool iret3 = ib.Equals(ic);
            Console.WriteLine("1." + iret3);

            Console.ReadKey();//프로그램 종료되도 콘솔 바로 종료되지 않도록


        }
    }
}
