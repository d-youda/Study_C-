namespace ex_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //학생
            //학년, 반, 번호, (학번)
            //사람
            //성명, 혈액형, 국적, 주소, 전화번호
            //동물(Animal)
            //나이, 성별, 몸무게

            Student st = new Student();//동물, 사람, 학생 속성 다 가지고 있음!
            Console.WriteLine(st.ToString());//object에서 제공해줌 -> full class name 출력함.
            


        }
    }
}
