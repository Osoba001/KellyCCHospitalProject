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
        public Nurse(string name, Gender gender, Contact contact, Hospital hospital) : base(name, gender, contact, hospital)
        {

        }
    }
    
}
