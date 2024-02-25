
namespace Homework_Inheritance
{
    internal class Bird : Animal
    {
        public int age;

        public Bird() : base("Just Animal")
        {
            Console.WriteLine("Bird Constructor");
        }

        public void Sound()
        {
            Console.WriteLine("Bird Sound");
        }
    }
}
