namespace ParMath.Interface
{
    public interface ITournament
    {
        string NameTournament { get; set; }
        string Description { get; set; }
        string StartDate { get; set; }
        string LastRegistDate { get; set; }
        string Place { get; set; }
        int Partiseted { get; set; }
    }
}