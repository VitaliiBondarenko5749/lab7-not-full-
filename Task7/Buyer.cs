abstract class Buyer : IIdentifiable, IBuyer
{
    //Властивості
    public abstract string Name { get; set; }
    public abstract int Age { get; set; }
    public abstract int Food { get; set; }

    //Конструктори
    public Buyer(string name, int age) { this.Name = name; this.Age = age;}
    //Методи
    public abstract void BuyFood();
} 