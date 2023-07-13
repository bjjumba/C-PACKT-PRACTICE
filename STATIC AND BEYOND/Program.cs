namespace STATIC_REF_ETC
{
    class Employee{
         private String? name;
         private readonly int id;

         private static int count=1;

         private Employee(int id,String name){
              this.name=name;
              this.id=id;
         }

         /*create a static method*/


         public static Employee create(int id,String name){
                return new  Employee(id,name);
         }

         public static void add(){
            Console.WriteLine("Magic");
         }


         /*OUR MAIN*/

         static void Main(String[] args){
            add();/*Call A static method*/
         }
    }
}
