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
        List<Apointment> GetFuctureApoints();
        void AproveApoint(Apointment apointment);
        void BookApointment(string discription, Patient patient);
        List<Patient> PatientsSeenByParticularDoctoriEachDay(Guid huspitalId);
        List<Patient> PatientsSeenWeekly(Guid huspitalId);
        List<Patient> PatientsSeenMonthly(Guid huspitalId);
        List<Patient> PatientsSeenQuarterly(Guid huspitalId);
        List<Patient> PatientsSeenYealy(Guid huspitalId);
    }
}
