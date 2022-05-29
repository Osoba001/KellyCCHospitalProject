using HospitalRepository.HospitalEnums;
using HospitalRepository.HospitalRepository.Wrapper;
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
        public Doctor(string name, Gender gender, string phoneNo, string email, string addres, Hospital hospital, string area) :base(name, gender, phoneNo, email, addres, hospital) 
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
        IWrapper uow = new Wrapper();
        public List<Apointment> ApprovedApontment(Doctor doctor)
        {
            return uow.Apointment.FindByPredicate(x => x.IsApprove && x.Doctor==doctor).ToList();
        }
        public List<Apointment> ApprovedApontmentOnAParticularDay(Doctor doctor, DateTime day)
        {
            return uow.Apointment.FindByPredicate(x=>x.ApointmentTime.Day==day.Day && x.Doctor == doctor && x.IsApprove).ToList();
        }

        public void GivenTreatment(string name, Patient patient, Doctor doctor)
        {
            Treatment treatment = new Treatment(patient, name, doctor);
            uow.TreatmentReo.AddEntity(treatment);
            patient.Bills.Treatments.Add(treatment);
            uow.PatientRepo.UpdateEntity(patient);
            uow.Commit();
        }

        public void IsDoctorFree(Doctor doctor)
        {
            var d=uow.DoctorReo.FindByPredicate(x=>x.Id==doctor.Id).FirstOrDefault();
            if (d!=null)
            {
                d.IsFree = !d.IsFree;
                uow.DoctorReo.UpdateEntity(d);
                uow.Commit();
            }

        }

        public void PrescribeDrug(Doctor doctor, Patient patient, Drug drug, int quantity, string instruction)
        {
            BoughtDrug drugToBuy = new BoughtDrug(patient, drug, quantity, instruction);
            uow.BoughtDrug.AddEntity(drugToBuy);
            uow.Commit();
        }

        public void AttendToApointment(Apointment apointment)
        {
            var uow = new Wrapper();
            apointment.IsAttendedTo = true;
            apointment.ApointmentTime = DateTime.Now;
            uow.Apointment.UpdateEntity(apointment);
            uow.Commit();
        }

       
    }
}
