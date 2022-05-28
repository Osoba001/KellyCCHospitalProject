using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class HospitalMap:ClassMap<Hospital>
    {
        public HospitalMap()
        {
            Id(x => x.Id);
            HasOne(x => x.Administrator);
            Map(x => x.Name);
            Map(x => x.RegistrationNo);
            Map(x => x.RegisterDate);
            Map(x => x.PhoneNo);
            Map(x => x.Email);
            Map(x => x.Address);
            HasOne(x => x.Accountant);
            HasMany(x=> x.Doctors);
            HasMany(x => x.Nurses);
            HasOne(x => x.Receptionist);
            HasMany(x => x.Patients);
            HasMany(x => x.Pharmacists);
            HasMany(x => x.StaffId);
        }
    }
}
