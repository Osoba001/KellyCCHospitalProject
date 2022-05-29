using HospitalRepository.HospitalEnums;
using HospitalRepository.HospitalRepository.Wrapper;
using HospitalRepository.IFunctionalities;
using HospitalRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Patient:Person,IBaseModel,IPatient
    {
        protected Patient()
        {

        }
        public Patient(string name, string healtStatus, Gender gender, Hospital hospital) : base(name, gender)
        {
            Hospital = hospital;
            HealthStatus = healtStatus;
            IsRegister = false;
            Payment = new List<Payment>();
            Bills = new Bills();
        }
        public virtual Hospital Hospital { get; set; }
        public virtual List<Payment> Payment { get; set; }
        public virtual Bills Bills { get; set; }
        public virtual Apointment Apointment { get; set; }
        public virtual bool IsRegister { get; set; }
        public virtual string HealthStatus { get; set; }

        public void BookNewApointment(string discription, Patient patient, DateTime time)
        {
            
            var uow = new Wrapper();
            var p = uow.Apointment.FindByPredicate(x => x.Patient == patient).FirstOrDefault();
            if (p!=null)
            {
                p.IsApprove = false;
                p.IsActive = true;
                p.IsAttendedTo = false;
                p.Discription = discription;
                p.BookedTime = DateTime.Now;
                p.ApointmentTime = time;
                uow.Apointment.UpdateEntity(p);
            }
            else
            {
                Apointment apointment = new Apointment(discription, patient);
                apointment.ApointmentTime = time;
                uow.Apointment.AddEntity(apointment);
            }
            
            uow.Commit();
        }

        public void MakePayment(decimal amount, Patient patient, Hospital hospital, PaymentFor payingFor)
        {
            Payment payment = new Payment(amount,patient,hospital,payingFor);
            var uow = new Wrapper();
            uow.Payment.AddEntity(payment);
            uow.Commit();
        }

        public void CancelApointment(Apointment apointment)
        {
            var uow = new Wrapper();
            var p = uow.Apointment.FindByPredicate(x => x.Id ==apointment.Id).FirstOrDefault();
            if (p != null)
            {
                p.IsActive = false;
                p.IsApprove = false;
                uow.Apointment.UpdateEntity(p);
                uow.Commit();
            }
            
        }

        public List<Apointment> GetMyApointment(Patient patient)
        {
            var uow = new Wrapper();
            return uow.Apointment.FindByPredicate(x => x.Patient == patient).ToList();
        }


        public void CreatePationt(string name, string healtStatus, Gender gender, Hospital hospital)
        {
            Patient patient = new Patient(name, healtStatus, gender,hospital);
            var uow = new Wrapper();
            uow.PatientRepo.AddEntity(patient);
            uow.Commit();
        }

        public List<BoughtDrug> GetAllPrescibedDrugs(Patient patient)
        {
            var uow = new Wrapper();
            return uow.BoughtDrug.FindByPredicate(x => x.Patient == patient).ToList();
        }

        public void RescheduleApointment(Apointment apointment, DateTime time)
        {
            var uow = new Wrapper();
            var p=uow.Apointment.FindByPredicate(x=>x.Id==apointment.Id).FirstOrDefault();
            if (p!=null)
            {
                p.ApointmentTime = time;
                p.IsApprove = false;
                uow.Apointment.UpdateEntity(p);
                uow.Commit();
            }
            else
            {
                throw new Exception("This appointment does not exist");
            }
            
        }

        public List<Drug> GetAllDrugs(Hospital hospital)
        {
            var uow = new Wrapper();
            return uow.DrugRep.FindByPredicate(x => x.Pharmacist.Hospital == hospital).ToList();
        }
    }
}
