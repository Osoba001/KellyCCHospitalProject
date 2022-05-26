using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Pharmacist: Staff, IBaseModel
    {
        public Pharmacist(string name, Gender gender, Contact contact, StaffID staffID) : base(name, gender, contact, staffID)
        {
            List<Drug> Drugs = new List<Drug>();
        }
        public virtual List<Drug> Drugs { get; set; }
    }
}
