﻿class Citizen : IPerson, IBirthable, IIdentifiable
{
    //Властивості
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Birthdate { get; private set; }
    public string Id { get; private set; }

    //Коструктор
    public Citizen(string name, int age, string id, string birthdate) { Name = name; Age = age; Birthdate = birthdate; Id = id; }
}