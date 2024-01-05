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
        }
        public void Eat()
        {

        }
        public void Walk()
        {

        }
    }
}
