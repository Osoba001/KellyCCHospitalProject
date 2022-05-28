using HospitalRepository.HospitalEnums;
using HospitalRepository.IFunctionalities;
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
        public Patient(string name, string healtStatus, Gender gender, Contact contact, Hospital hospital) : base(name, gender, contact)
        {
            Hospital = hospital;
            HealthStatus = healtStatus;
            IsRegister = false;
            Treatment = new List<Treatment>();
            Drugs = new List<BoughtDrug>();
            Payment = new List<Payment>();
            Apointments = new List<Apointment>();
        }
        public virtual Hospital Hospital { get; set; }
        public virtual List<Treatment> Treatment { get; set; }
        public virtual List<BoughtDrug> Drugs { get; set; }
        public virtual List<Payment> Payment { get; set; }
        public virtual List<Apointment> Apointments { get; set; }
        public virtual bool IsRegister { get; set; }
        public virtual string HealthStatus { get; set; }

        public void BookApointment(string discription, Patient patient)
        {
            throw new NotImplementedException();
        }

        public void MakePayment(decimal amount, Patient patient)
        {
            throw new NotImplementedException();
        }

        public void CancelApointment(Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public List<Apointment> GetMyApointments(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public void CreateContact(string phoneNo, string email, string addres, Hospital hospital)
        {
            throw new NotImplementedException();
        }

        public void CreatePationt(string name, string healtStatus, Gender gender, Contact contact, Hospital hospital)
        {
            throw new NotImplementedException();
        }
    }
}
