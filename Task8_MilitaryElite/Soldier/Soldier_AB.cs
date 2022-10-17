abstract class Soldier : ISoldier 
{
    //Властивості
    public string Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    //Конструктори
    public Soldier(string id, string first_name, string last_name)
    {
        this.Id = id;
        this.FirstName = first_name;
        this.LastName = last_name;
    }

    //Методи
    public override string ToString() => $"Name: {this.FirstName + " " + this.LastName} Id: {this.Id}";
}
