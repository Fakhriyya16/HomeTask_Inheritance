
namespace Homework_Inheritance
{
    internal class Fish : Animal
    {
        public string color;

        public Fish(): base("Just Animal")
        {
            Console.WriteLine("Fish Constructor");
        }
    }
}
