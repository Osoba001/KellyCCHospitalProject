using HospitalRepository.IFunctionalities;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace KellyCCBackEndEvaluation2.StaffFunc
{
    public class AdminFun : IAdmin
    {
        public Acountant Acountant(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public void CreateHospital(Hospital hospital)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> Doctors(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Staff> GetAllStaff(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public List<Nurse> Nurses(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public List<Patient> Patients(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public List<Pharmacist> pharmacists(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public Receptionist Receptionist(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }
    }
}
