using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class StaffIDMap:ClassMap<StaffID>
    {
        public StaffIDMap()
        {
            Id(x => x.Id);
            Map(x => x.IdNumber);
            Map(x => x.IssueDate);
            Map(x => x.ExpiringDate);
            Map(x => x.IsUse);
            References(x => x.Hospital);

        }
    }
}
