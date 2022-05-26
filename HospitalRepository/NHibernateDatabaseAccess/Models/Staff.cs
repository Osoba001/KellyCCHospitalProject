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
        public Staff(string name, Gender gender, Contact contact, StaffID staffID):base(name,gender,contact)
        {
            StaffId = staffID;
        }
        public StaffID StaffId { get; set; }
    }
}
