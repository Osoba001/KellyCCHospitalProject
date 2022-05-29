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
            Map(x => x.Date);
            Map(x => x.Quantity);
            Map(x => x.IsPharmacistAprove);
            Map(x => x.Instructions);
            References(x => x.Drug);
            References(x => x.Doctor);
            References(x => x.Patient).Cascade.All();
        }
    }
}
