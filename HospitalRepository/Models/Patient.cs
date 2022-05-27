using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Patient:Person,IBaseModel
    {
        protected Patient()
        {

        }
        public Patient(string name, Gender gender, Contact contact, Hospital hospital) : base(name, gender, contact)
        {
            Hospital = hospital;
            IsRegister = false;
            List<Treatment> Treatment = new List<Treatment>();
            List<BoughtDrug> Drugs = new List<BoughtDrug>();
            List<Payment> Payment = new List<Payment>();
        }
        public virtual Hospital Hospital { get; set; }
        public virtual List<Treatment> Treatment { get; set; }
        public virtual List<BoughtDrug> Drugs { get; set; }
        public virtual List<Payment> Payment { get; set; }
        public virtual bool IsRegister { get; set; }
    }
}
