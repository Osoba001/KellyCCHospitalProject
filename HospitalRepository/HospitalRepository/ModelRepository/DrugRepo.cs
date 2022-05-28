using HospitalRepository.HospitalRepository.IModelRepo;
using HospitalRepository.NHibernateDatabaseAccess.Models;
using NHibernate;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class DrugRepo:Repository<Drug>,IDrugRep
    {
        public DrugRepo(ISession session) : base(session)
        {
        }

    }
}
