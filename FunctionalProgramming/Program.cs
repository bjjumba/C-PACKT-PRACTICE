 using System;
 namespace Functional{
      public class Magic {
        public int Number {get; set;}
        
        public delegate int Combine(int a, int b);

        public static int Add(int a, int b) =>  a + b; 
        public static int Sub(int a, int b) =>  a - b; 
        public static int Mul(int a, int b) => a * b; 

        static T Apply <T> (T a, T b, Func <T,T,T> f)
        {
            return f(a, b);
        }

        static Func <int, int, int> sample = (a,b) => a+b;
         static void Main(){
            var s = Apply <int> (2, 3, Add);
            Console.WriteLine($"{s}");
            int m = Magic.sample(1,3);
            Console.WriteLine($"hhh {m}");

            var list =new List<int> {1,2,3,4};
            list.RemoveAll(n => n % 2 == 1);
         }
      }
}