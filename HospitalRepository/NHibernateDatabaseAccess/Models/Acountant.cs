using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Acountant: Staff,IBaseModel
    {
        protected Acountant()
        {

        }
        public Acountant(string name, Gender gender, Contact contact, StaffID staffID):base(name, gender, contact, staffID) 
        {

        }
        
    }
}
