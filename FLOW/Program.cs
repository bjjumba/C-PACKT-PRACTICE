namespace Flow{
    class Flow{
        static void Main(String[] args){
            // for(int i=0;i<20;i++){
            //     Console.WriteLine($"Hello world {i}");
            // }
            int i=0;

            // while (i<10){
            //     if(i%2==0){
            //         Console.WriteLine($"{i} is even");
            //     }else{
            //         Console.WriteLine($"{i} is Odd");
            //     }

            //     i++;//increment by 1
            // }

            /*FOR EACH; ADVANCED FOR*/
            string[] languages = { "Java", "C#", "Python", "C++","JavaScript" };

            foreach(string m in languages){
                Console.WriteLine(m);
            }
        }
    }
}