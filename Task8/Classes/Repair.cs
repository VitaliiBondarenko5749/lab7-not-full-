class Repair : IRepair
{
    //Поля
    private string part_name;
    private int hours_worked;

    //Властивості
    public string PartName 
    { 
        get => this.part_name;
        private set => this.part_name = value; 
    }
    public int HoursWorked 
    {
        get => this.hours_worked; 
        private set => this.hours_worked = value; 
    }

    //Конструктори
    public Repair(string partName, int hoursWorked)
    {
        this.PartName = partName;
        this.HoursWorked = hoursWorked;
    }

    //Методи
    public override string ToString() => $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
}