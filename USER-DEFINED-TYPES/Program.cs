namespace UserDefined
{
    class UserDefined{

        private String? name;/*make the field nullable*/

        public String studentNo {get;set;}



        public int EmployeeId => 1;/*stands for read onlys*/

        public readonly String regNo;
            /*  
                readonly =>
                This means the value can only be declared in the constructor
                These are called runtime constants
            */

        /*Create my Constructor*/

        UserDefined(String m){
            regNo=m;
        }
        /*Creating a method*/

        public String getDetails()=>$"This is our {regNo}";/*simple expression method*/

        /*Create a sample getter and setter*/

        public String Name{
            get {return name;}
            set {name=value;}//always use value
        }
        static void Main(String[] args){

            UserDefined u=new UserDefined("20/u/2087/eve");

            //u.regNo="2000702087";

            u.Name="Jjumba";

            object m=u.Name;
            
            Console.WriteLine();

        }
    }
}
