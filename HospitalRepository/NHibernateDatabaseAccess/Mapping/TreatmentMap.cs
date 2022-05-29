using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class TreatmentMap:ClassMap<Treatment>
    {
        public TreatmentMap()
        {
            Id(x=>x.Id);
            Map(x => x.Name);
            Map(x => x.Date);
            Map(x => x.Amount);
            References(x => x.Doctor);
            References(x => x.Patient);
        }
    }
}
