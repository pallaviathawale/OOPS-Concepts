using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConcepts
{
    public class PolymorphismDemo
    {
        //types of polymorphism
        //1.Compile Time Polymorphism/Method Overloading
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        //2.Run Time Polymorphism/Method Overriding
         public virtual  void AnimalSound()
        {
            Console.WriteLine("...Animal Makes Sound...");
        }

        public class Pig : PolymorphismDemo  //derived class
        {
            public override void  AnimalSound()
            {
                Console.WriteLine("....The pig say wee wee....");
            }
        }
        public class Dog : PolymorphismDemo //derived class
        {
            public override void AnimalSound()
            {
                Console.WriteLine(".....Barking.....");
            }
        }
    }
}
