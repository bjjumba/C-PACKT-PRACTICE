namespace Functional{
      public class Magic {
        public int Number {get; set;}
        
        public delegate int Combine(int a, int b);

        public static int Add(int a, int b) =>  a + b; 
        public static int Sub(int a, int b) =>  a - b; 
        public static int Mul(int a, int b) => a * b; 

        static int Apply(int a, int b, Combine f)
        {
            return f(a, b);
        }
         static void Main(){
            var s = Apply(2, 3, Add);
            Console.WriteLine($"{s}");
         }
      }
}