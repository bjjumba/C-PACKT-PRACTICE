
int[] arr ={2,3,4,5,6};
Console.WriteLine($"Before {arr[0]}");

Change(ref arr);

Console.WriteLine($"After {arr[0]}");

/*Sum*/
Sum(1,2,3,4,5);
static void Change(ref int[] arr)
{
    arr[0] = 1;

    arr = new int[5] {-1,-2,-3,-4,-5};
}

/* add multiple numbers*/
static void Sum(params int[] list)
{
    var sum = 0;
   for(int i = 0; i < list.Length ; i++){

       sum  = + list[i];
       Console.WriteLine(list[i]);
   }

   Console.WriteLine($"Sum {sum}");
}