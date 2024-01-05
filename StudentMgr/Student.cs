using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhyu
{
    //class full name : namespace.class

    /// <summary>
    /// dhyu.Stduent 클래스 정의
    /// </summary>
    public class Student//바깥에서 인스턴스로 만들어 쓸 수 있도록 함
    {
        private string name;
        private string address;
        private int age;
        #region 생성자
        public Student(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public Student(string name): this(name, null)//바로 위 생성자 부름
        {
            //name = null;//name에 할당된 주소가 없다. -> 참조형식에서만 사용 가능함.
        }
        public Student():this(null)//파라미터 하나인 자기 상위 생성자 부르는 문법 -> 바로 위 생성자 부름
        {
            
        }

        //시그니처 : method_name(parameter type) -> 메소드 풀 명칭
        #endregion
        /// <summary>
        /// getter of name
        /// </summary>
        //public string getName()
        //{//숨어는 있는데 name 값 던져줌
        //    return name;
        //}
        ///// <summary>
        ///// setter of name
        ///// </summary>
        ///// <param name="name"></param>
        //public void setName(string name)
        //{
        //    this.name = name;
        //}

        //public string Name
        ////프로퍼티 -> 컴파일러가 getter/setter로 실행해줌
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public string Name { get; set; } //더 줄인 프로퍼티
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            if (age<0 || age > 121)
            {
                Console.WriteLine("나이는 음수가 되거나 120세가 넘을 수 없습니다.");
                return;//age 실행하지 않고 돌아감
            }
            this.age = age;
        }
        public void printName()
        {
            Console.WriteLine("name: " + name);
        }

        public void printAddress()
        {
            Console.WriteLine("address: " + address);
        }
    }

}
