using HospitalRepository.HospitalEnums;
using HospitalRepository.IFunctionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Doctor: Staff, IBaseModel,IDoctor
    {
        protected Doctor()
        {

        }
        public Doctor(string name, Gender gender, Contact contact, Hospital hospital, string area) : base(name, gender, contact,  hospital)
        {
            Specialization = area;
            Nurses = new List<Nurse>();
            Treatments = new List<Treatment>();
            Apointments = new List<Apointment>();
            IsFree=true;
        }
        public virtual string Specialization { get; set; }
        public virtual bool IsFree { get; set; }
        public virtual List<Nurse> Nurses { get; set; }
        public virtual List<Apointment> Apointments { get; set; }
        public virtual List<Treatment> Treatments { get; set; }


        //Functionalities
        public List<Apointment> ApprovedApontment(Guid huspitalId, Guid doctorId)
        {
            throw new NotImplementedException();
        }

        public void GivenTreatment(string name, decimal amount, Patient patient, Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public void IsDoctorFree(Guid huspitalId, Guid doctorId)
        {
            throw new NotImplementedException();
        }

    }
}
