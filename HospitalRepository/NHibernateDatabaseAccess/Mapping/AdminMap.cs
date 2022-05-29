using HospitalRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class AdminMap:ClassMap<Admin>
    {
        public AdminMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Gender);
            Map(x => x.DOB);
            Map(x => x.PhoneNo);
            Map(x => x.Email);
            Map(x => x.Address);
            HasOne(x => x.StaffId);
            References(x => x.Hospital).Cascade.All();
        }
    }
}
