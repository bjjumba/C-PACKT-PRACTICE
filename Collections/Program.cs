namespace CollectionSample
{
    public class CollectionSample{
        public static void  Main(){
            // var numbers=new List<int>{1,2,3,4};
            // numbers.Add(1);
            // numbers.AddRange(new int[]{1,23,78});
            // numbers.Insert(7,7);
            // numbers.Remove(1);
            // var g=numbers.FindAll(e=>e<10);
            
            // Console.WriteLine($"hello {g}");
            // numbers.Sort();
            // foreach(int x in numbers){
            //     Console.WriteLine(x);
            // }
            /*Stack Section*/

            String[] names=new String[]{"Jjumba","Nagawa"};
            Stack<String> magic=new Stack<string>(names);
            /*LinkedList*/
            int[] numbers=new int[]{1,2,3,4,5,6};
            LinkedList<int> numberList=new LinkedList<int>(numbers);
            Console.WriteLine(numberList.FindLast(5));
        }
    }
}