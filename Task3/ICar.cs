interface ICar
{
    //Властивості
    public string Model { get; } //Назва моделі
    public string Driver_name { get; } //Назва імені

    //Методи
    public string Brakes(); //Коли тормозить машина
    public string Gas(); //Коли газує машина
}