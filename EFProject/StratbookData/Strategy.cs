using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratbookData
{
    public class Strategy
    {
        public int StrategyId { get; set; }
        public string StrategyDescription { get; set; }
        public string StrategyType { get; set; }
        public string Map { get; set; }
        public string RoleType { get; set; }
        public string RoleInstructions { get; set; }
        public int StrategyRating { get; set; }
    }
}
