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
        public Acountant()
        {

        }
        public Acountant(string name, Gender gender, string phoneNo, string email, string addres, Hospital hospital) :base(name, gender, phoneNo, email, addres, hospital) 
        {
           
        }

        //Functionalities
        IWrapper uow;
        public Acountant(IWrapper _uow)
        {
            uow=_uow;
        }
        public virtual List<Patient> PatientsOwing(Hospital hospital)
        {
             return uow.PatientRepo.FindByPredicate(x=>x
             .Bills.AmountBilled>x.
             Payment.Sum(x=>x.Amount) && x
             .Hospital== hospital).ToList();
        }

        public virtual List<Payment> AllPayment(Hospital hospital)
        {
            return uow.Payment.FindByPredicate(x => x.Hospital == hospital).ToList();
        }

        public virtual List<Payment> PaymentWithinAPeriod(Hospital hospital, DateTime start, DateTime end)
        {
            if (start<=end)
            {
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

        public virtual void AprovePayment(Payment payment)
        {
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

        public virtual void BillPatientOnDrug(Patient patient, BoughtDrug boughtDrug)
        {
            var b = uow.BillRepo.FindByPredicate(x => x.Patient == patient).FirstOrDefault();
            b.BoughtDrugs.Add(boughtDrug);
            uow.BillRepo.UpdateEntity(b);
            uow.Commit();
           // throw new NotImplementedException();
        }

        public virtual void BillPatientOnTreatment(Patient patient, Treatment treatment, decimal amount)
        {
            treatment.Amount = amount;
            var b = uow.BillRepo.FindByPredicate(x => x.Patient == patient).FirstOrDefault();
            if (b == null) patient.Bills = new Bills(patient);
            b.Treatments.Add(treatment);
            uow.BillRepo.UpdateEntity(b);
            uow.Commit();
            // throw new NotImplementedException();
        }
    }
}
