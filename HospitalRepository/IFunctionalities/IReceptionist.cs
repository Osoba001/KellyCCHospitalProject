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
        void AproveApoint(Apointment apointment);
        void RescheduleApoint(Apointment apointment,DateTime time);
        void BookApointment(string discription, Patient patient, DateTime time);
        List<Patient> PatientsSeenByDoctoriEachDay(Doctor doctor);
        List<Patient> PatientsSeenWeekly(Doctor doctor);
        List<Patient> PatientsSeenMonthly(Doctor doctor);
        List<Patient> PatientsSeenQuarterly(Doctor doctor);
        List<Patient> PatientsSeenYealy(Doctor doctor);
    }
}
