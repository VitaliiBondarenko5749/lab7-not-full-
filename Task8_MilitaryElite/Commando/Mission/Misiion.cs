class Mission : IMission
{
    //Поля 
    private string code_name;
    private string state;

    //Властивості
    public string CodeName
    {
        get => this.code_name;
        private set => this.code_name = value;
    }
    public string State
    {
        get => this.state;
        private set
        {
            if (value != "inProgress" || value != "Finished")
                throw new ArgumentException("invalid mission state");

            this.state = value;
        }
    }

    //Конструктори
    public Mission(string codeName, string state) { this.CodeName = codeName; this.State = state; }

    //Методи
    public void CompleteMission() => this.state = "Finished";
    public override string ToString() => $"Code Name: {this.CodeName} State: {this.State}";
}