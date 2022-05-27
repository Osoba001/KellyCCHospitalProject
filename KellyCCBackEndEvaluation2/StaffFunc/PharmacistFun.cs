using HospitalRepository.IFunctionalities;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace KellyCCBackEndEvaluation2.StaffFunc
{
    public class PharmacistFun : IPharmacist
    {
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
