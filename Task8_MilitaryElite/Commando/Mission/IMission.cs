interface IMission
{
    //Властивості
    public string CodeName { get; }
    public string State { get; }

    //Методи
    public void CompleteMission();
}