using HospitalRepository.NHibernateDatabaseAccess;

namespace HospitalRepository.HospitalRepository.Wrapper
{
    public class PatientWork:IPatientWork
    {
        protected ISession _session;
        public PatientWork()
        {
            _session = NHibernateHelper.OpenSession();
        }
    }
}
