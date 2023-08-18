namespace WorkingCollection
{
    partial class Program {

        static void Output(string title, IEnumerable<string> collection)
        {
          Console.WriteLine(title);
          foreach(string item in collection)
          {
             Console.WriteLine(item);
          }
        }
        static void Main(){
            List<string> cities = new();
                cities.Add("London");
                cities.Add("Paris");
                cities.Add("Milan");

            Output("Initial list", cities);
            /*Dictionary*/
            Dictionary<int, string> keywords = new();
            keywords.Add(1,"Integer");
            foreach(KeyValuePair<int, string> item in keywords)
            {
                Console.WriteLine($" {item.Key}: {item.Value}");
            }
        }
    }
}