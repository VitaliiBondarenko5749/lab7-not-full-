class Program
{
    static void Main(string[] args)
    {
        List<Citizen> citizens = new List<Citizen>();
        List<Rebel> rebels = new List<Rebel>();

        int n = int.Parse(Console.ReadLine());

        string[][] arr = new string[n][];

        for(int i = 0; i < arr.Length; ++i)
            arr[i] = Console.ReadLine().Split(' ');

        for (int i = 0; i < arr.Length; ++i)
        {
            if (arr[i].Length == 4)
            {
                if (CheckList(ref citizens, in arr[i][0]) == false)
                    citizens.Add(new(arr[i][0], int.Parse(arr[i][1]), arr[i][2], arr[i][3]));
            }
            if (arr[i].Length == 3)
            {
                if (CheckList(ref rebels, in arr[i][0]) == false)
                    rebels.Add(new(arr[i][0], int.Parse(arr[i][1]), arr[i][2]));
            }
        }

        Console.WriteLine();

        string name = "";
        int result = 0;

        while(true)
        {
            name = Console.ReadLine();

            if (name == "End") break;

            foreach(Citizen citizen in citizens)
            {
                if(citizen.Name == name)
                    citizen.BuyFood();               
            }
            foreach(Rebel rebel in rebels)
            {
                if(rebel.Name == name) 
                    rebel.BuyFood();                
            }
        }

        foreach(Citizen citizen in citizens)
            result += citizen.Food;
        foreach (Rebel rebel in rebels)
            result += rebel.Food;
        

        Console.WriteLine("\n" + result);
    }

    static bool CheckList(ref List<Citizen> c, in string name)
    {
        if(c.Count == 0)
            return false;

        foreach (Citizen citizen in c)
        {
            if(name == citizen.Name)
                return true;
        }

        return false;
    }

    static bool CheckList(ref List<Rebel> r, in string name)
    {
        if (r.Count == 0)
            return false;

        foreach (Rebel rebel in r)
        {
            if (name == rebel.Name)
                return true;
        }

        return false;
    }
}