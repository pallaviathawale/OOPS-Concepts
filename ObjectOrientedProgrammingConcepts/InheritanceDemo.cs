using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConcepts
{
    public class InheritanceDemo
    {


    }
    //Types of Inheritance
    //1.Single Level Inheritance
    public class Employee
    {
        public float salary = 20000;
    }

    public class programmer : Employee
    {
        public float Bonus = 15000;
    }
    // 2.MultiLevel Inheritance
    //public class Tester : programmer
    //{
    //    public float ExtraIncome = 1000;
    //}

    //3.Heirarchical Inheritance

    public class Tester : Employee
    {
        public float ExtraIncome = 1000;

    }


    //4.Multiple Inheritance- We can achieve multiple inheritance by using Interface

    public interface IDrawable
    {
        void Operation();

    }

    public class Addition :IDrawable
    {
        public void Operation()
        {
            Console.WriteLine(".....Perform Addition.....");
        }
    }

    public class Subtraction : IDrawable
    {
        public void Operation()
        {
            Console.WriteLine(".....Perform Subtraction.....");
        }
    }

    public class Multiplication : IDrawable
    {
        public void Operation()
        {
            Console.WriteLine(".....Perform Multiplication....");
        }
    }

}
