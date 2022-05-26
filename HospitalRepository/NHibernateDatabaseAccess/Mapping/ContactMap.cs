using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class ContactMap:ClassMap<Contact>
    {
        public ContactMap()
        {
            Id(x => x.Id);
            Map(x => x.PhoneNo);
            Map(x => x.Email);
            Map(x => x.Address);
            References(x => x.Hospital);
        }
    }
}
