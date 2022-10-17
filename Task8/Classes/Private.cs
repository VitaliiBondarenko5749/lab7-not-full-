class Private : Soldier, IPrivate
{
    //Властивості
    public double Salary { get; private set; }

    //Конструктори
    public Private(string id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    //Методи
    public override string ToString() => $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
}
