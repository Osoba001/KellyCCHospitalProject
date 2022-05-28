using HospitalRepository.NHibernateDatabaseAccess;

namespace HospitalRepository.HospitalRepository.Wrapper
{
    public class ReceptionistWork: IReceptionistWork
    {
        protected ISession _session;
        public ReceptionistWork()
        {
            _session= NHibernateHelper.OpenSession();
        }
    }
}
