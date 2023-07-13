namespace structSample
{
    class Sample{

        struct Point{
            public int x;
            public int y;
        }
        static void Main(String[] args){

            Point p;/*create a value not reference*/

            p.x=0;
            p.y=1;

            Console.WriteLine("Successfully created my First Struct");
        }
    }
}
