using HospitalRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class BillMap:ClassMap<Bills>
    {
        public BillMap()
        {
            Id(x => x.Id);
            HasMany(x => x.BoughtDrugs);
            HasMany(x => x.Treatments);
            References(x => x.Patient).Cascade.All();
        }
    }
}
