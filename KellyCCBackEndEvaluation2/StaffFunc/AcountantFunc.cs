using HospitalRepository.IFunctionalities;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace KellyCCBackEndEvaluation2.StaffFunc
{
    public class AcountantFunc : IAcountant
    {
        public List<Payment> AllPayment(string hospitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsOwing(Guid hospitalId)
        {
            throw new NotImplementedException();
        }

        public List<Payment> PaymentInADay(Guid hospitalId, DateTime day)
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

        public List<Payment> PaymentInAYear(Guid hospitalId, DateTime year)
        {
            throw new NotImplementedException();
        }
    }
}
