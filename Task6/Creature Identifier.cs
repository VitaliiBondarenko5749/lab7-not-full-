using System.Globalization;

class CreatureIdentifier : IIdentifier
{
    //Властивості
    public string Type { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Id { get; private set; }
    public string BDate { get; private set; } = "00/00/0000";

    //Конструктор
    public CreatureIdentifier(string type, string name, int age, string id, string bdate)
    { this.Type = type; this.Name = name; this.Age = age; this.Id = id; this.BDate = bdate; }
    public CreatureIdentifier(string type, string name, string smth)
    {
        if(type.ToLower() == "robot")
        {
            this.Type = type;
            this.Name = name;
            this.Id = smth;
        }
        if(type.ToLower() == "pet")
        {
            this.Type=type;
            this.Name = name;
            this.BDate = smth;
        }
    }

    //Методи
    public string BDate_identifier(string checker, int date)
    {
        string s = checker.Substring(checker.Length - 4);

        if (date == Convert.ToUInt32(s))
            return checker;

        return "";
    }
}