using System;

namespace WebApplication.Models
{
    public class Credit
    {
        public int CreditID { get; set; }
        public string CreditName { get; set; }
        public int IsSummer { get; set; }
        public int IsSpring { get; set; }
        public int IsFall { get; set; }

    }
}