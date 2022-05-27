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
            Map(x => x.ExpiringDate);
            Map(x => x.ManufactureDate);
            Map(x => x.Photo);
            Map(x=>x.Quantity);
            References(x=>x.Pharmacist);
        }
    }
}
