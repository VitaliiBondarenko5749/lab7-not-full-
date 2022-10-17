class Program
{
    static void Main(string[] args)
    {
        List<Robot> robots = new List<Robot>();
        List<Citizen> citizens = new List<Citizen>();

        while (true)
        {
            int k = 0;
            string[] input = Console.ReadLine().Split(' ');

            foreach (string s in input) { if (s == "End") { ++k; break; } }

            if (k > 0) break;

            if (input.Length == 3)
                citizens.Add(new (input[0], int.Parse(input[1]), input[2]));
            if (input.Length == 2)
                robots.Add(new(input[0], input[1]));
        }

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        foreach (Citizen check in citizens)
        {
            string checker = check.Id;
            string s = checker.Substring(checker.Length - 3);

            if (number == Convert.ToUInt32(s))
                Console.WriteLine(check.Id);
        }
        foreach (Robot check in robots)
        {
            string checker = check.Id;
            string s = checker.Substring(checker.Length-3);

            if (number == Convert.ToUInt32(s))
                Console.WriteLine(check.Id);
        }
    }
}