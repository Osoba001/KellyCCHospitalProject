using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class DoctorMap:ClassMap<Doctor>
    {
        public DoctorMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Gender);
            Map(x => x.DOB);
            Map(x=>x.Specialization);
            References(x => x.Contact);
            References(x => x.Hospital).Cascade.All();
            References(x => x.StaffId);
            HasMany(x => x.Nurses);
            HasMany(x => x.Apointments);
            HasMany(x => x.Patients);
        }
    }
}
