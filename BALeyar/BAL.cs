using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBookEntity;
using AddressBoolWithDissconnectedNTier;
//this is a change
namespace BALeyar
{
    public class BAL
    {
        DALayer dl = new DALayer();

        public int InsertAddress(AddressBook ab)
        {
            return (dl.InsertAddress(ab));
        }
        public int DeleteAddress(int adid)
        {
            return (dl.DeleteAddress(adid));
        }
        public int UpdateAddress(int id,AddressBook ab)
        {
            return (dl.UpdateAddress(id, ab));
        }
        public AddressBook SearchAddress(int Address_ID)
        {
            return (dl.SearchAddress(Address_ID));
        }
    }
}
