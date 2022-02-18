using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Credit
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public decimal Ammount { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
    }
}
