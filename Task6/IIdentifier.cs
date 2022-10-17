interface IIdentifier
{
    //Властивості
    public string Type { get; }
    public string Name { get; }
    public int Age { get; }
    public string Id { get; }
    public string BDate { get; }

    //Методи
    public string BDate_identifier(string checker, int date);
}
