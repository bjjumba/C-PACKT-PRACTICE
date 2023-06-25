namespace ArraySample{
    class Sample{
        static void Main(String[] args){

            int [,] sample=new int [2,3]{
                {1,2,3},
                {4,5,6}
            };
            /*iterate through the arrays*/

            for(int i=0;i<sample.GetLength(0);++i){
                for(int j=0;i<sample.GetLength(1);++j){
                    Console.Write($"{sample[i, j]} ");
                }
            }

            
           Console.WriteLine("Hello World");
        }
    }
}
