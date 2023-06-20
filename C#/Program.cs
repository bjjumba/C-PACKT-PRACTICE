namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=12;
            int hex = 0x2A;
            int bin = 0b_0010_1010;

            String name=String.Empty;

            name+="Jjumba";

            char [] letters={'h','e','l','l','o'};

            String magic=string.Format("jkk {0}",23);

            String derived=new String(letters);

            Console.WriteLine(magic.ToUpper());
            /* Date Time*/


            DateTime dt = new DateTime(2019, 12, 25);

            /*Object boxing and unboxing*/
            int y=7;

            object benji=y;

            int z=(int)benji;
            /*make a value nullable*/
            int? c=42;

            /*Check whether has a value*/

            Console.WriteLine(c.HasValue);



            Console.WriteLine(z);
            


            Console.WriteLine(dt);
        }
    }
}