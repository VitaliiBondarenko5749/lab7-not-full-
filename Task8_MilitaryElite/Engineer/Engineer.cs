using System.Text;

class Engineer : SpecialisedSoldier, IEngineer
{
    //Поля
    private List<Repair> repairs;

    //Властивості
    public List<Repair> Repairs { get => this.repairs; }

    //Конструктори
    public Engineer(string id, string firstName, string lastName, double salary, string corps, List<Repair> repairs)
           : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = new List<Repair>(repairs);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine("Repairs:")
            .Append(string.Join($"\n", this.repairs));

        return sb.ToString();
    }
}
