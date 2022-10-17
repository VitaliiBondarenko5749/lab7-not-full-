using System.Text;

class Commando : SpecialisedSoldier, ICommando
{
    //Поля
    private List<Mission> missions;

    //Властивості
    public List<Mission> Missions { get => this.missions; }

    //Конструктори
    public Commando(string id, string firstname, string lastname, double salary, string corps, List<Mission> missions)
        : base(id, firstname, lastname, salary, corps)
    {
        this.missions = new List<Mission>(missions);
    }

    //Методи
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine("Missions:")
            .Append("  ")
            .Append(string.Join("\n", this.Missions));

        return sb.ToString();
    }
}