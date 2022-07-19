namespace betluck.Models
{

    public class Team
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public IList<League> Leagues { get; set; }
    }
}
