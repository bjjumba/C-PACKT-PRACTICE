namespace Enumeration{
    public class SampleEnum{
        enum Priority : int{
            Low=0,
            Normal=1
        }
        static void Main(String[] args){
            int p=(int) Priority.Low;
            Console.WriteLine("Hello World");
            Console.WriteLine(p);

            var foo=new ProgramTwo.Magic();
            Console.WriteLine(foo);

        }
    }
}

namespace ProgramTwo{
    class Magic {
        int name=0;
    }
}

