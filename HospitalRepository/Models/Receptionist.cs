using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Receptionist : Staff,IBaseModel
    {
        protected Receptionist()
        {

        }
        public Receptionist(string name, Gender gender, Contact contact, Hospital hospital) : base(name, gender, contact, hospital)
        {

        }
    }
}
