namespace TYPES
{
    class TypeConversion{
        static void Main(String[] args){   

            String s="Benji";

            object o=s;  //implicit casting

            string r=(String) o;//explicit casting


            //conversion using helper classes
            int p=int.Parse("42");
            //try readline

            var input=Console.ReadLine();

            Console.WriteLine(input.GetType());

        }
    }
    
}