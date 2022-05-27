using HospitalRepository.HospitalRepository.IModelRepo;
using HospitalRepository.NHibernateDatabaseAccess.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class PharmacistRepo:Repository<Pharmacist>,IPharmacist
    {
        protected ISession _session;
        public PharmacistRepo(ISession session):base(session)
        {
            _session=session;
        }

        public void AddNewDrugToStore(Drug drug)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetExpiredDrugs(Guid phmId)
        {
            throw new NotImplementedException();
        }

        public void RemoveExpiredDrugs(Guid phmId)
        {
            throw new NotImplementedException();
        }

        public void SeleDrug(BoughtDrug drug)
        {
            throw new NotImplementedException();
        }

        public List<Drug> Top10MostBoughtDrugs(Guid hospitalId, Guid phmId)
        {
            throw new NotImplementedException();
        }

        public void UpdateDrugQuantity(Drug drug)
        {
            throw new NotImplementedException();
        }
    }
}
