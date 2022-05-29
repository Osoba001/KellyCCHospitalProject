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
        public Nurse(string name, Gender gender, string phoneNo, string email, string addres, Hospital hospital) : base(name, gender, phoneNo, email, addres, hospital)
        {

        }
        public virtual Doctor Doctor { get; set; }
    }
    
}
