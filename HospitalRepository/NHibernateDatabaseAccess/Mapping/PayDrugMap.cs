using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class PayDrugMap:ClassMap<PayForDrug>
    {
        public PayDrugMap()
        {
            Id(x => x.Id);
            Map(x => x.TimeOfPayment);
            Map(x => x.Amount);
            References(x => x.Patient);
            References(x => x.Drug);
            References(x => x.Acountant);
        }
    }
}
