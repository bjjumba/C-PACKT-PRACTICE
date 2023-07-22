

namespace Sample{
   public class SimpleDelegate{
      public  delegate void CallBack(String name);

      public static void CallMe(string name){
         Console.WriteLine($"{name}");
      }

      CallBack hello=CallMe;


     static void Main(){
        // SimpleDelegate s=new SimpleDelegate();
        // s.hello("Hello Benji");

        var engine=Tuple.Create("Jjumba",1,true,Tuple.Create(2,78));

        Console.WriteLine(engine.Rest.Item1);
      }
   }
}