using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_09
{
    class Human : Animal //Human이 Animal클래스 상속받음
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CellPhone { get; set; }
        public Human()
        {
            //Console.WriteLine("Animal"+this.ToString());
        }
        public void Drawing()
        {

        }
        public void Study()
        {

        }
    }
}
