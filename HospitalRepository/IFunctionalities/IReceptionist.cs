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
        List<Patient> PatientsSeenByDoctorDaily(Doctor doctor);
        List<Patient> PatientsSeenWeekly(Doctor doctor);
        List<Patient> PatientsSeenMonthly(Doctor doctor);
        List<Patient> PatientsSeenQuarterly(Doctor doctor);
        List<Patient> PatientsSeenYealy(Doctor doctor);
    }
}
