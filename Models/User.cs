using System.Collections.Generic;

namespace betluck.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }

        public IList<Tournament> Posts { get; set; }
        public IList<Role> Roles { get; set; }
    }
}