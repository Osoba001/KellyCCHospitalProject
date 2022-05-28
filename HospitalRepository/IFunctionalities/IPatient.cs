using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalRepository.HospitalEnums;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace HospitalRepository.IFunctionalities
{
    public interface IPatient
    {
        void BookApointment(string discription,Patient patient);
        void MakePayment(decimal amount, Patient patient, Hospital hospital, PaymentFor payingFor);
        void CancelApointment(Apointment apointment);
        void RescheduleApointment(Apointment apointment, DateTime time);
        List<BoughtDrug> GetAllPrescibedDrugs(Patient patient);
        List<Apointment> GetMyApointments(Patient patient);
        void CreatePationt(string name, string healtStatus, Gender gender, Hospital hospital);
    }
}
