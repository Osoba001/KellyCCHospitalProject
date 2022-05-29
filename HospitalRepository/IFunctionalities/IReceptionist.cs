using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace HospitalRepository.IFunctionalities
{
    public interface IReceptionist
    {
        List<Apointment> GetFuctureApoints(Hospital hospital);
        Apointment CheckPatientAPointment(Patient patient);
        void AproveApoint(Apointment apointment, Doctor doctor, DateTime time);
        void RescheduleApoint(Apointment apointment,DateTime time);
        void ChechOutPatient(Patient patient);
        void BookApointment(string discription, Patient patient, DateTime time);
        List<Patient> PatientsSeenByDoctoriEachDay(Doctor doctor, DateTime time);
        List<Patient> PatientsSeenWeekly(Doctor doctor, DateTime time);
        List<Patient> PatientsSeenMonthly(Doctor doctor, DateTime time);
        List<Patient> PatientsSeenQuarterly(Doctor doctor, DateTime time);
        List<Patient> PatientsSeenYealy(Doctor doctor, DateTime time);
    }
}
