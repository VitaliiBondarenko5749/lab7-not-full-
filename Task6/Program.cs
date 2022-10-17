class Program
{
    static void Main(string[] args)
    {
        List<CreatureIdentifier> creatureIdentifiers = new List<CreatureIdentifier>();

        while(true)
        {
            int k = 0;
            string[] input = Console.ReadLine().Split(' ');

            foreach (string s in input) { if (s == "End") { ++k; break; } }

            if (k > 0) break;

            if (input.Length == 5)
                creatureIdentifiers.Add(new(input[0], input[1], int.Parse(input[2]), input[3], input[4]));
            if (input.Length == 3)
                creatureIdentifiers.Add(new(input[0], input[1], input[2]));
        }

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");

        if(creatureIdentifiers.Count != 0)
        {
            int counter = 0;

            foreach (CreatureIdentifier creatureIdentifier in creatureIdentifiers)
            {
                string result = creatureIdentifier.BDate_identifier(creatureIdentifier.BDate, number);
                if (result == "") { }
                else
                {
                    ++counter;

                    Console.WriteLine(result);
                }
            }

            if (counter == 0)
                Console.WriteLine("<empty output>");
        }

    }
}