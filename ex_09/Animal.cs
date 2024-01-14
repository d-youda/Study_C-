using StudemtManagement;

namespace ex_09
{
    internal class Animal
    {
        public int age { get; set; }
        public Sex sex { get; set; }
        public int weight { get; set; }
        public Animal()
        {
            Console.WriteLine("Animal: "+ this.ToString());
        }

        public void Sleep()
        {
            System.Console.WriteLine("I'm sleep now"); 
        }
        public void Eat()
        {

            System.Console.WriteLine("I'm eating banana");
        }
        public void Walk()
        {
            System.Console.WriteLine("I'm walking int  the street");
        }
    }
}
