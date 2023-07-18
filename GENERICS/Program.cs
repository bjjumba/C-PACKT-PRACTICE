namespace GenericSample
{
    public class Caller:Shape<int>{

        public override int Area(int x,int y)=>x*y;
        static void Main(){
            object obj=new GenericsDemo<int,double>(10,30.0);/*It can fit in object or var*/
            var t1=obj.GetType();
            Console.WriteLine(obj.ToString());
             Console.WriteLine($"{t1.Name}");
             /**/

        
        }
    }

    public class GenericsDemo<T, U>{
        public T Value {get; private set;}/*Setters and getters*/
        public U ValueTwo {get; private set;}
        public GenericsDemo(T value, U magic){
            Value=value;
            ValueTwo=magic;
        }
        /*Override toString method*/

        public override string ToString()=>$"{typeof(T)}:{Value}";
    }

  public abstract class Shape<T> 
  {
    public abstract T Area(T x,T y);
  }
  /*Abstract interface*/

      interface SampleInterface<T>{
         public T add();
      }

}