using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Doctor: Staff, IBaseModel
    {
        protected Doctor()
        {

        }
        public Doctor(string name, Gender gender, Contact contact, Hospital hospital, string area) : base(name, gender, contact,  hospital)
        {
            Specialization = area;
            List<Nurse> Nurses = new List<Nurse>();
            List<Patient> Patients = new List<Patient>();
            List<Apointment> Apointments = new List<Apointment>();
        }
        public virtual string Specialization { get; set; }
        public virtual List<Nurse> Nurses { get; set; }
        public virtual List<Patient>  Patients { get; set; }
        public virtual List<Apointment> Apointments { get; set; }
       
    }
}
