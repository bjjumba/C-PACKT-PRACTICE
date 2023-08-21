using Microsoft.EntityFrameworkCore;
using EFCore.Model;

namespace EFCore
{
    partial class Program
    {

        static bool NameLongerThanFour(string name)
        {
             return name.Length > 4;
        }
        static void Main(string[] args)
        {
            // Call the QueryingCategories() method
            // QueryingCategories();

            // string[] names = {"Jjumba" ,"Eric", "Benjamin", "Anna" , "Mukisahhhh"};
            // IOrderedEnumerable<string> query1 = names.Where(NameLongerThanFour).OrderBy(name => name.Length).ThenBy(name => name);

            // // Answer returned as an array of strings containing Pam and Jim
            // string[] result1 = query1.ToArray();

            // foreach (string name in query1)
            // {
        
            //   WriteLine(name); // outputs Pam
           
            // }
        

            // Keep the console window open
            // Console.ReadLine();

            FilterAndSort();
        }

        // Rest of the code...
    }
}
