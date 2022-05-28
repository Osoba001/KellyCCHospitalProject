using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace HospitalRepository.IFunctionalities
{
    public interface IPharmacist
    {
        List<Drug> GetAllDrugs(Guid phmId);
        List<Drug> Top10MostBoughtDrugs(Guid hospitalId, Guid phmId);
        void SeleDrug(Patient patient, Drug drug, int quantity);
        void AddNewDrugToStore(string name, DateOnly exp, DateOnly manufac, decimal unitprice, int quantity, Pharmacist pharmacist);
        void UpdateDrug(Drug drug);
        List<Drug> GetExpiredDrugs(Guid phmId);
        void RemoveExpiredDrugs(Guid phmId);
        void RemoveDrugs(Guid phmId);
    }
}
