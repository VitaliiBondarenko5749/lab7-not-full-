using System.Text;

class LeutenantGeneral : Private, ILeutenantGeneral
{
    //Властивості
    public List<Private> PrivateSoldiers { get; private set; }

    //Конструктори
    public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<Private> privateSoldiers)
        : base(id, firstName, lastName, salary)
    {
        this.PrivateSoldiers = new List<Private>(privateSoldiers);
    }

    //Методи
    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine(base.ToString()).AppendLine("Privates:")
            .AppendLine(String.Join("\n", PrivateSoldiers));

        return sb.ToString();
    }
}