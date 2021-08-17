using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratbookData
{
    public partial class User
    {
        public User()
        {
            Strategies = new HashSet<Strategy>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassWord { get; set; }
        public bool AccountType { get; set; }

        public virtual ICollection<Strategy> Strategies { get; set; }
    }
}
