interface ICommando : ISSoldier// + FName, LName, ID, Salary, Corps
{
    public List<IMission> Missions { get; }
}