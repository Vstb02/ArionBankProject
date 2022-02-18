using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Card
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Number { get; set; }
        public double Balance { get; set; }
        public int Bonus { get; set; }
        public string PaymentSystem { get; set; }
        public string Type { get; set; }
        public int Cvv { get; set; }
        public string CardholderName { get; set; }
        public string CardholderSurname { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
