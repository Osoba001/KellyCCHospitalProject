using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Hospital:BaseEntity, IBaseModel
    {
        protected Hospital()
        {

        }
        public Hospital(string name, string address, Contact contact)
        {
            Name = name;
            Address = address;
            Contact = contact;
            List<Doctor> Doctors =new List<Doctor>();
            List<Nurse> Nurses=new List<Nurse>();
            List<Pharmacist> Pharmacists = new List<Pharmacist>();
            List<Patient> Patients = new List<Patient>();
        }
        public virtual string Name { get; set; }
        public string Administrator { get; set; }
        public virtual string Address { get; set; }
        public virtual DateOnly RegisterDate { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
        public virtual List<Nurse> Nurses { get; set; }
        public virtual List<Pharmacist> Pharmacists { get; set; }
        public virtual Receptionist Receptionist { get; set; }
        public virtual Acountant Accountant { get; set; }
        public virtual List<Patient> Patients { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual List<StaffID> StaffId { get; set; }
    }
}
