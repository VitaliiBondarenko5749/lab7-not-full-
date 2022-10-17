 class Citizen : Buyer
{
    //Поля
    private string name;
    private int age;
    private string id;
    private string b_date;

    //Властивості
    public override string Name { get => this.name; set => this.name = value; }
    public override int Age { get => this.age; set => this.age = value; }
    public string Id { get => this.id; set => this.id = value; }
    public string BDate { get => this.b_date; set => this.b_date = value; }
    public override int Food { get; set; } = 0;

    //Конструктори
    public Citizen(string name, int age, string id, string bdate) : base(name, age) { this.Id = id; this.BDate = bdate; }
   
    //Методи
    public override void BuyFood()
    {
        this.Food += 10;
    }
}