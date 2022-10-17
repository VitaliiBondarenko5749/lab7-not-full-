using System.Text;

abstract class SSoldier : Private, ISSoldier
{
   // private readonly string[] possibleCorps = new string[] { "Airforces", "Marines" };

    //Поля
    private string corps;

    //Властивості
    public string Corps
    {
        get => this.corps;
        
        private set
        {
            if (value != "Airforces" || value != "Marines")
                throw new ArgumentException("Invalid Corps");
          
            this.corps = value;
        }
    }

    //Конструктори
    public SSoldier(string id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    //Методи
    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine(base.ToString()).AppendLine($"Corps: {this.Corps}");

        return str.ToString();
    }
}