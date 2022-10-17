class Program
{
    static void Main(string[] args)
    {
        Smartphone phone = new("Samsung");

        string[] numbers = Console.ReadLine().Split(' ');
        string[] links = Console.ReadLine().Split(' ');

        Console.WriteLine();

        for(int i = 0; i < numbers.Length; ++i)
        {
            try
            {
                if (IsNumberValid(numbers[i]) == true)
                    Console.WriteLine(phone.Calling(numbers[i]));
                else
                    throw new ArgumentException("Invalid number!");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        for(int i = 0; i < links.Length; ++i)
        {
            try
            {
                if (IsUrlValid(links[i]) == true)
                    Console.WriteLine(phone.Browsing(links[i]));
                else
                    throw new ArgumentException("Invalid URL!");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static bool IsUrlValid(string url)
    {
        for (int i = 0; i < url.Length; i++)
        {
            if (char.IsDigit(url[i]))
            {
                return false;
            }
        }

        return true;
    }

    static bool IsNumberValid(string phoneNumber)
    {
        for (int i = 0; i < phoneNumber.Length; i++)
        {
            if (!char.IsDigit(phoneNumber[i]))
            {
                return false;
            }
        }

        return true;
    }
}