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
        public Staff()
        {

        }
        public Staff(string name, Gender gender, string phoneNo, string email, string addres, Hospital hospital):base(name,gender)
        {
           Hospital= hospital;
            PhoneNo = phoneNo;
            Email = email;
            Address = addres;
        }
        public virtual StaffID StaffId { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
