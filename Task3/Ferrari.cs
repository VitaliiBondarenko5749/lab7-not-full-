class Ferrari : ICar
{
    //Властивості
    public string Model { get; private set; } = "488-Spider";
    public string Driver_name { get; private set; }

    //Конструктори
    public Ferrari(string driver_name) { this.Driver_name = driver_name; }
    public Ferrari(string driver_name, string model_name) : this(driver_name) { this.Model = model_name; }
 
    //Методи
    public string Brakes() => "Brakes!";
    public string Gas() => "Zadu6avam sA!";
    public override string ToString() => $"\n{this.Model}/{this.Brakes()}/{this.Gas()}/{this.Driver_name}";
}