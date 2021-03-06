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
        public Patient()
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


        IWrapper uow;
        public Patient(IWrapper _uow)
        {
            uow = _uow;
        }
        public virtual void BookNewApointment(string discription, Patient patient, DateTime time)
        {

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
                 p= new Apointment(patient);
                p.ApointmentTime = time;
                p.IsApprove = false;
                p.IsActive = true;
                p.IsAttendedTo = false;
                p.Discription = discription;
                p.BookedTime = DateTime.Now;
                p.ApointmentTime = time;
                uow.Apointment.AddEntity(p);
            }
            
            uow.Commit();
        }

        public virtual void MakePayment(decimal amount, Patient patient, Hospital hospital, PaymentFor payingFor)
        {
            Payment payment = new Payment(amount,patient,hospital,payingFor);
            uow.Payment.AddEntity(payment);
            uow.Commit();
        }

        public virtual void CancelApointment(Apointment apointment)
        {
            var p = uow.Apointment.FindByPredicate(x => x.Id ==apointment.Id).FirstOrDefault();
            if (p != null)
            {
                p.IsActive = false;
                p.IsApprove = false;
                uow.Apointment.UpdateEntity(p);
                uow.Commit();
            }
            
        }

        public virtual List<Apointment> GetMyApointment(Patient patient)
        {
            return uow.Apointment.FindByPredicate(x => x.Patient == patient).ToList();
        }


        public virtual void CreatePationt(string name, string healtStatus, Gender gender, Hospital hospital)
        {
            Patient patient = new Patient(name, healtStatus, gender,hospital);
            uow.PatientRepo.AddEntity(patient);
            uow.Commit();
        }

        public virtual List<BoughtDrug> GetAllPrescibedDrugs(Patient patient)
        {
            return uow.BoughtDrug.FindByPredicate(x => x.Patient == patient).ToList();
        }

        public virtual void RescheduleApointment(Apointment apointment, DateTime time)
        {
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

        public virtual List<Drug> GetAllDrugs(Hospital hospital)
        {
            return uow.DrugRep.FindByPredicate(x => x.Pharmacist.Hospital == hospital).ToList();
        }
    }
}
