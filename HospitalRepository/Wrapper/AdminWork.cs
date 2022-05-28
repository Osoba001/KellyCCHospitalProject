using HospitalRepository.NHibernateDatabaseAccess;

namespace HospitalRepository.HospitalRepository.Wrapper
{
    public class AdminWork: IAdminWork
    {
        protected ISession _session;
        public AdminWork()
        {
            _session = NHibernateHelper.OpenSession();
        }
    }
}
