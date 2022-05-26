using HospitalRepository.HospitalRepository.IModelRepo;
using HospitalRepository.NHibernateDatabaseAccess.Models;
using NHibernate;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class DrugRepo:Repository<Drug>,IDrugRep
    {
        protected ISession _session;
        public DrugRepo(ISession session) : base(session)
        {
            _session=session;
        }

        public List<Drug> Top10MostBought()
        {
            var D= _session.Query<Drug>().ToList();

        }
    }
}
