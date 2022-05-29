using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class DrugMap:ClassMap<Drug>
    {
        public DrugMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.UnitPrice);
            Map(x => x.Purpose);
            Map(x => x.Caution);
            Map(x => x.Photo);
            Map(x=>x.Quantity);
            HasMany(x => x.BoughtDrugs);
            References(x=>x.Pharmacist);
            References(x=>x.Hospital).Cascade.Delete();
        }
    }
}
