namespace Dice {
    public class Dog
    {
        static void Main(){
            int[] arr = { 1, 1, 3, 5, 8, 13, 21, 34};
            int sum = arr.Where(x => x % 2 == 1).Sum();

            var text = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed do eiusmod tempor incididunt ut labore et doloremagna aliqua.";
            var count = text.Split(new char[] { ' ', ',', '.' });
            // .Where(w => !string.IsNullOrEmpty(w))
            // .Count();

            var groups = text.Split(new char[] { ' ', ',', '.' })
                .GroupBy(w => w.Length, w => w.ToLower())
                .Select(g => new { Length =g.Key, Words = g })
                .Where(g => g.Length > 0)
                .OrderBy(g => g.Length);

            foreach (var group in groups)
            {
                Console.WriteLine($"Length={group.Length}");
                foreach (var word in group.Words)
                {
                    Console.WriteLine($" {word}");
                }
            }
            // Console.WriteLine(groups);
        }
    }
}