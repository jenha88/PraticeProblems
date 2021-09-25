using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP4
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    
        public Contact()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Photo = "";

        }

        public override string ToString()
        {
            return $"{ LastName}, { FirstName}";
        }
    }
}
