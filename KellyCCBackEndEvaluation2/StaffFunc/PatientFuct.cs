using HospitalRepository.IFunctionalities;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace KellyCCBackEndEvaluation2.StaffFunc
{
    public class PatientFuct : IPatient
    {
        public void BookApointment(Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public void CancelApointment(Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public List<Apointment> GetMyApointments(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public void PayForDrug(PayForDrug drug)
        {
            throw new NotImplementedException();
        }

        public void PayForTreatment(PayForTreatment treatment)
        {
            throw new NotImplementedException();
        }
    }
}
