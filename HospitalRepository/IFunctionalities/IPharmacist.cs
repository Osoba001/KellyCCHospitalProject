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
        List<Drug> GetAllDrugs(Pharmacist pharmacist);
        List<Drug> Top10MostBoughtDrugs(Hospital hospital);
        void SellDrug(Patient patient, Drug drug, int quantity,string instruction);
        void SellDoctorPrescibedDrug(BoughtDrug drug);
        void AddNewDrugToStore(string name, string purpose, string cauction, decimal unitprice, int quantity, Pharmacist pharmacist, Hospital hospital);
        void UpdateDrugInfo(Drug drug);
        void IncreaseDrugQuantity(Drug drug, int quantityIncreasement);
        void RemoveDrugs(Drug drug);
    }
}
