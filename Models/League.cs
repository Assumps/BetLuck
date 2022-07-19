namespace betluck.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Team> Teams { get; set; }

    }
}
