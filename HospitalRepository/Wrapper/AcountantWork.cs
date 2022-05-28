using HospitalRepository.NHibernateDatabaseAccess;

namespace HospitalRepository.HospitalRepository.Wrapper
{
    public class AcountantWork: IAcountantWork
    {
        protected ISession _session;
        public AcountantWork()
        {
            _session = NHibernateHelper.OpenSession();
        }
    }
}
