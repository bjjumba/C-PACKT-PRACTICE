namespace OOP{
    public class Shape{
        public virtual void draw(int x,int y){
             int w=x*y;
             Console.WriteLine(w);
        }
    }
    /*carryout inheritance*/

    public class Square:Shape{
        public override void draw(int x,int y){

        }
    }
    /*test base*/
    public class Pet{
        public string Name {get; private set;}
        public Pet(String name){
            Console.WriteLine("base Constructor");
            Name=name;
        }
        public Pet Clone() { return new Pet(Name); }
    }

    public class Dog:Pet{
        public string Color { get; private set; }
        public Dog(string name, string color):base(name)
            { 
                Console.WriteLine("Child Constructor");
                Color = color; 
            }
        static void Main(String[] args){
            Dog p=new Dog("POPPY","BLACK");
            Console.WriteLine(p.GetType());
        }
    }
}