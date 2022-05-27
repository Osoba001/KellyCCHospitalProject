using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class BoughtDrugMap:ClassMap<BoughtDrug>
    {
        public BoughtDrugMap()
        {
            Id(x => x.Id);
            Map(x => x.Time);
            Map(x => x.Quantity);
            References(x => x.Patient);
            References(x => x.Drug);
        }
    }
}
