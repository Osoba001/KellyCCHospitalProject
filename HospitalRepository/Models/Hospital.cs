using HospitalRepository.HospitalEnums;
using HospitalRepository.Models;
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
        public Hospital(string name, string regNo,  string addres)
        {
            Name = name;
            RegistrationNo = regNo;
             Doctors =new List<Doctor>();
             Nurses=new List<Nurse>();
             Pharmacists = new List<Pharmacist>();
            Patients = new List<Patient>();
            StaffId = new List<StaffID>();
            Address = addres;
        }
        public virtual string Name { get; set; }
        public Admin Administrator { get; set; }
        public virtual string RegistrationNo { get; set; }
        public virtual DateOnly RegisterDate { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
        public virtual List<Nurse> Nurses { get; set; }
        public virtual List<Pharmacist> Pharmacists { get; set; }
        public virtual Receptionist Receptionist { get; set; }
        public virtual Acountant Accountant { get; set; }
        public virtual List<Patient> Patients { get; set; }
        public virtual string PhoneNo { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
        public virtual List<StaffID> StaffId { get; set; }
    }
}
