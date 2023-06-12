namespace ObjectOrientedProgrammingConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".....Welcome to Object Oriented Programming Construct.....");

            Food food = new Food("Pizza", "Pasta", "Fish_Fry"); //Create an object of Food class

            
            Console.WriteLine("....My Favourite Food....:");   // Access the object's properties and methods
            Console.WriteLine("Junk Food: " + food.Junk_Food);
            Console.WriteLine("Healthy Food:" + food.Healthy_Food);
            Console.WriteLine("Sea Food:" + food.Sea_Food);
           // food.Vegetables();


        }

            //program with object and class concept
        public class Food            //defined class as Food
        {
            public string Junk_Food;   //class variables
            public string Healthy_Food;       //class variables
            public string Sea_Food;    //class variables


            public Food(string J_Food, string H_Food,string S_Food)  // defined constructor
            {
                Junk_Food = J_Food;
                Healthy_Food = H_Food;
                Sea_Food = S_Food;
            }

            public void Vegetables()                   //class method
            {
                Console.WriteLine(".........Let's Eat some healthy......");
            }
        }
        
    }
}