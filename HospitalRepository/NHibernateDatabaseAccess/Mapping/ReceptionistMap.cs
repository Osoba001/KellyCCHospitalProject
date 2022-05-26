using FluentNHibernate.Mapping;
using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class ReceptionistMap:ClassMap<Receptionist>
    {
        public ReceptionistMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Gender);
            Map(x => x.DOB);
            References(x => x.Contact);
            References(x => x.StaffId);
        }
    }
}
