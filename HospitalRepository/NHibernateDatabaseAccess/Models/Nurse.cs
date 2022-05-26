using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Nurse : Staff,IBaseModel
    {
        protected Nurse()
        {

        }
        public Nurse(string name, Gender gender, Contact contact, StaffID staffID) : base(name, gender, contact, staffID)
        {

        }
    }
    
}
