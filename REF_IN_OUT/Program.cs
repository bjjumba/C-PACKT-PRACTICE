namespace Ref_In_Out{
    class RefSampe{
        /*
        
          ref->pass a value by reference
          in->readonly ref!cannot be modified
        */
       /*pass a value by reference*/
        static void Swap(ref int a,ref int b){
            int temp =a;
            a=b;
            b=temp;
        }
       /*Method that return a ref*/
                // public ref RefSampe GetOwner()
                // {
                //     return ref RefSampe;
                // }

        /*Demonstrate in*/

        static void Square(int number, out int res){
            res=number*number;
        }
       
        static void Main(String[] args){
            int a=10;
            int b=20;

            Swap(ref a,ref b);/*demonstrate ref*/

            int res;

            Square(23,out res);/*demonstrate out*/

            int summation=add(1,2,3,4,5);
            // Console.WriteLine($"a={a}  b={b}");

            Console.WriteLine(summation);
        }

        /*method to take in multiple params*/

        static int add(params int[] numbers){
            int sum=0;
              if (numbers.Length==0)
                return 0;
             foreach (int number in numbers){
                  sum+=number;
             }

             return sum;
        }
    }
}