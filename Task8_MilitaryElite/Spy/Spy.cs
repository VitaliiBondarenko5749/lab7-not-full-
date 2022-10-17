using System.Text;

class Spy : Soldier, ISpy
{
    //Властивості
    public int CodeNumber { get; private set; }

    //Конструктори
    public Spy(string id, string firstName, string lastName, int codeNumber)
           : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    //Методи
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}")
            .AppendLine($"Code Number: {this.CodeNumber}");

        return sb.ToString().Trim();
    }
}