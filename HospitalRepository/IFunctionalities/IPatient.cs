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
        void MakePayment(decimal amount, Patient patient);
        void CancelApointment(Apointment apointment);
        List<Apointment> GetMyApointments(Guid patientId);
        void CreateContact(string phoneNo, string email, string addres, Hospital hospital);
        void CreatePationt(string name, string healtStatus, Gender gender, Contact contact, Hospital hospital);
    }
}
