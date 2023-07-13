namespace SampleInterfaces{
    public struct Position
        {
            public int X { get; private set; }
            public int Y { get; private set; }
            public Position(int x = 0, int y = 0)
                {
                    X = x;
                    Y = y;
                }
        }
    interface ISurface{
        void beginDraw();
        void endDraw();
        void DrawAt(char c,Position position);
    }

    public class Surface:ISurface{
        public int left,top;
        public void beginDraw(){
            Console.Clear();
            left = Console.CursorLeft;
            top = Console.CursorTop;
        }

        public void endDraw()
        {
            Console.WriteLine();
        }

        public void DrawAt(char c, Position position)
        {
            try
            {
                Console.SetCursorPosition(left + position.X,
                top + position.Y);
                Console.Write(c);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        static void Main(String[] args){
            Surface s=new Surface();
            s.beginDraw();
            s.DrawAt('*',new Position(2,2));
            s.endDraw();
        }

    }
}