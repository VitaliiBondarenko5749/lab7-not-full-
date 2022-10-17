abstract class Soldier : ISoldier
{
    //Властивості
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Id { get; private set; }

    //Властивості
    public Soldier(string id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}
