using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Deposit
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public double Balance { get; set; }
        public decimal Percent { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
    }
}
