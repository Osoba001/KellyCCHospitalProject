
namespace HospitalRepository.NHibernateDatabaseAccess
{
    public interface INHibernateHelper
    {
        ISessionFactory SessionFactory { get; }

        void InitializeSessionFatory();
        ISession OpenSession();
    }
}