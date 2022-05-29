using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class ApointmentMap:ClassMap<Apointment>
    {
        public ApointmentMap()
        {
            Id(x => x.Id);
            Map(x=>x.IsActive);
            Map(x => x.IsApprove);
            Map(x => x.IsAttendedTo);
            Map(x => x.ApointmentTime);
            Map(x => x.BookedTime);
            Map(x => x.Discription);
            Map(x => x.ApointmentType);
            References(x => x.Patient).Cascade.All();
            References(x => x.Doctor);
        }
    }
}
