using System;

namespace C__files
{
    class Child:Calculate
    {
       // public string word= 'I am from the child class.';
        public string word= "I am from the child class.";

        public double Subtract(double a, double b){
            return b-a;
        }
    }

      class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Input 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = num1 + num2;
            Console.WriteLine(num3);

            Child one = new Child();
            Console.WriteLine(one.word);
            Console.WriteLine(one.phrase);
            
            Child two = new Child();   //two can access both superclass and subclass methods
            Console.WriteLine(two.Subtract(5, 8));
            Console.WriteLine(two.Subtract(15.2, 8.3));

            Calculate three = new Child();
            Console.WriteLine(three.Subtract(5, 8));
            //Console.WriteLine(three.Subtract(15.2, 8.3)); //gives error because three is of type superclass so it doesn't know Subtract() method in subclass
            
        }
    }
}
