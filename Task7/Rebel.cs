class Rebel : Buyer
{
    //Поля
    private string name;
    private int age;
    private string group;

    //Властивості
    public override string Name { get => this.name; set => this.name = value; }
    public override int Age { get => this.age; set => this.age = value; }
    public string Group { get => this.group; set => this.group = value; }
    public override int Food { get; set; } = 0;

    //Конструктори
    public Rebel(string name_, int age_, string group_) : base(name_, age_) { this.Group = group_; }

    //Методи
    public override void BuyFood()
    {
        this.Food += 5;
    }
}