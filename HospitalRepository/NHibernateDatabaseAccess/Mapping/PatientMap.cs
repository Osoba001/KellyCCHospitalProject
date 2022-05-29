using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class PatientMap:ClassMap<Patient>
    {
        public PatientMap()
        {

            Id(x => x.Id);
            Map(x => x.Name);
            Map(x=>x.HealthStatus);
            Map(x => x.Gender);
            Map(x => x.DOB);
            Map(x=>x.IsRegister);
            Map(x => x.PhoneNo);
            Map(x => x.Email);
            Map(x => x.Address);
            References(x=>x.Hospital).Cascade.All();
            HasMany(x => x.Payment);
            HasOne(x=>x.Bills);
            HasOne(x => x.Apointment);


        }
    }
}
