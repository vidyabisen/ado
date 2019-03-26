using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookEntity
{
    public class AddressBook
    {
        public int id { get; set; }
        public string Fname{ get; set; }
        public string Lname{ get; set; }
        public string email{ get; set; }
        public string PhonNo{ get; set; }
        public string Country{ get; set; }
    }
}
