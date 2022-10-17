class Citizen : IPerson
{
    //Властивості
    public string Name { get; private set; }
    public int Age { get; private set; }

    //Коструктор
    public Citizen(string name, int age) { Name = name; Age = age; }
}