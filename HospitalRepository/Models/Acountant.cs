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
    public class Acountant: Staff,IBaseModel,IAcountant
    {
        protected Acountant()
        {

        }
        public Acountant(string name, Gender gender, Contact contact, Hospital hospital) :base(name, gender, contact, hospital) 
        {
           
        }
       


        //Functionalities
        public List<Patient> PatientsOwing(Guid hospitalId)
        {
            throw new NotImplementedException();
        }

        public List<Payment> AllPayment(Guid hospitalId)
        {
            throw new NotImplementedException();
        }

        public List<Payment> PaymentInAYear(Guid hospitalId, DateTime year)
        {
            throw new NotImplementedException();
        }

        public List<Payment> PaymentInAMonth(Guid hospitalId, DateTime month)
        {
            throw new NotImplementedException();
        }

        public List<Payment> PaymentInAWeek(Guid hospitalId, DateTime week)
        {
            throw new NotImplementedException();
        }

        public List<Payment> PaymentInADay(Guid hospitalId, DateTime day)
        {
            throw new NotImplementedException();
        }

        public void AprovePayment(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
