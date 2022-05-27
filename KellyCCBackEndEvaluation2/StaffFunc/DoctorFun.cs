using HospitalRepository.IFunctionalities;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace KellyCCBackEndEvaluation2.StaffFunc
{
    public class DoctorFun : IDoctor
    {
        public List<Apointment> ApprovedApontment(Guid huspitalId, Guid doctorId)
        {
            throw new NotImplementedException();
        }

        public void GivenTreatment(Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public void IsDoctor(Guid huspitalId, Guid doctorId)
        {
            throw new NotImplementedException();
        }
    }
}
