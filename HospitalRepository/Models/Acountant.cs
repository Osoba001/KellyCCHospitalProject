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
    public class Acountant: Staff,IBaseModel,IAcountant
    {
        protected Acountant()
        {

        }
        public Acountant(string name, Gender gender, string phoneNo, string email, string addres, Hospital hospital) :base(name, gender, phoneNo, email, addres, hospital) 
        {
           
        }
       


        //Functionalities
        public List<Patient> PatientsOwing(Hospital hospital)
        {
            var uow = new Wrapper();
             return uow.PatientRepo.FindByPredicate(x=>x
             .Bills.AmountBilled>x.
             Payment.Sum(x=>x.Amount) && x
             .Hospital== hospital).ToList();
        }

        public List<Payment> AllPayment(Hospital hospital)
        {
            var uow = new Wrapper();
            return uow.Payment.FindByPredicate(x => x.Hospital == hospital).ToList();
        }

        public List<Payment> PaymentWithinAPeriod(Hospital hospital, DateTime start, DateTime end)
        {
            if (start<=end)
            {
                var uow = new Wrapper();
                return uow.Payment.FindByPredicate(x =>
                x.TimeOfPayment <= end &&
                x.TimeOfPayment >= start &&
                x.Hospital == hospital && x.IsAprove).ToList();
            }
            else
            {
                throw new Exception("Start date can not be greater then end date");
            }
            
        }

        public void AprovePayment(Payment payment)
        {
            var uow = new Wrapper();
            var p = uow.Payment.FindByPredicate(x => x.Id == payment.Id).FirstOrDefault();
            if (p!=null)
            {
                p.IsAprove = true;
                uow.Payment.UpdateEntity(p);
                uow.Commit();
            }
            else
            {
                throw new Exception("Appointment does not exist");
            }
        }

        public void BillPatientOnDrug(Patient patient, BoughtDrug boughtDrug)
        {
            var uow=new Wrapper();
            var b=uow.BillRepo.FindByPredicate(x=>x.Patient==patient).FirstOrDefault();
            if (b==null) patient.Bills = new Bills(patient);
            b.BoughtDrugs.Add(boughtDrug);
            uow.BillRepo.UpdateEntity(b);
            uow.Commit();
        }

        public void BillPatientOnTreatment(Patient patient, Treatment treatment, decimal amount)
        {
            var uow = new Wrapper();
            treatment.Amount=amount;
            var b = uow.BillRepo.FindByPredicate(x => x.Patient == patient).FirstOrDefault();
            if (b == null) patient.Bills = new Bills(patient);
            b.Treatments.Add(treatment);
            uow.BillRepo.UpdateEntity(b);
            uow.Commit();
        }
    }
}
