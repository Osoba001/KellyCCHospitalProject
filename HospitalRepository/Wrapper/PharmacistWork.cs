using HospitalRepository.NHibernateDatabaseAccess;

namespace HospitalRepository.HospitalRepository.Wrapper
{
    public class PharmacistWork: IPharmacistWork
    {
        protected ISession _session;
        public PharmacistWork()
        {
            _session = NHibernateHelper.OpenSession();
        }
    }
}
