using static ObjectOrientedProgrammingConcepts.PolymorphismDemo;

namespace ObjectOrientedProgrammingConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".....Welcome to Object Oriented Programming Construct.....");

            PolymorphismDemo demo = new PolymorphismDemo();
            int result = demo.Add(22, 18);
            int result2 = demo.Add(22, 18, 16);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            PolymorphismDemo animal = new PolymorphismDemo();
            PolymorphismDemo mypig = new Pig();
            PolymorphismDemo mydog = new Dog();
            animal.AnimalSound();
            mydog.AnimalSound();
            mypig.AnimalSound();
        }

        
    }
}