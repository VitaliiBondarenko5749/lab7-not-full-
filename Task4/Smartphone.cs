using System.Reflection.Metadata.Ecma335;

class Smartphone : ISmartphone, ISite
{
    //Властивості
    public string Model { get; private set; }

    //Конструктор
    public Smartphone(string model) { this.Model = model; }

    //Методи
    public string Calling(string number) => $"Calling... {number}";
    public string Browsing(string url) => $"Browsing: {url}";
} 