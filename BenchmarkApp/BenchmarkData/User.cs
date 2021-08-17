using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkData
{
    public partial class User
    {
        public User()
        {
            Games = new HashSet<Game>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool AccountType { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
