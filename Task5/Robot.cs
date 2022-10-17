class Robot : IRobot
{
    //Властивості
    public string Model { get; private set; }
    public string Id { get; private set; }

    //Конструктори
    public Robot(string model, string id) { this.Model = model; this.Id = id; }  
}