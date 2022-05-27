using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Staff:Person
    {
        protected Staff()
        {

        }
        public Staff(string name, Gender gender, Contact contact, Hospital hospital):base(name,gender,contact)
        {
           Hospital= hospital;
        }
        public virtual StaffID StaffId { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
