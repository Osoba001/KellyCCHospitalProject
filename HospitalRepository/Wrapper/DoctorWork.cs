using HospitalRepository.NHibernateDatabaseAccess;

namespace HospitalRepository.HospitalRepository.Wrapper
{
    public class DoctorWork : IDoctorWork
    {
        protected ISession _session;
        public DoctorWork()
        {
            _session = NHibernateHelper.OpenSession();
        }
    }
}
