using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.IModelRepo
{
    public interface IPharmacist:IRepostory<Pharmacist>
    {
        List<Drug> Top10MostBoughtDrugs(Guid hospitalId,Guid phmId);
        void SeleDrug(BoughtDrug drug);
        void AddNewDrugToStore(Drug drug);
        void UpdateDrugQuantity(int quantity, Guid drugId, Guid phmId);
        List<Drug> GetExpiredDrugs(Guid hospitalId);
    }
}
