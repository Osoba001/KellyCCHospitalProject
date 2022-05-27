using HospitalRepository.IFunctionalities;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace KellyCCBackEndEvaluation2.StaffFunc
{
    public class ReceptionistFunc : IReceptionist
    {
        public void AproveApoint(Patient patient, Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public void BookApointment(Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public List<Apointment> GetFuctureApoints()
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenByParticularDoctoriEachDay(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenMonthly(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenQuarterly(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenWeekly(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenYealy(Guid huspitalId)
        {
            throw new NotImplementedException();
        }
    }
}
