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
        void SellNewDrug(Patient patient, Drug drug, int quantity,string instruction);
        void SellDoctorPrescibedDrug(BoughtDrug drug);
        void AddNewDrugToStore(string name, DateTime exp, DateTime manufac, decimal unitprice, int quantity, Pharmacist pharmacist);
        void UpdateDrug(Drug drug);
        List<Drug> GetExpiredDrugs(Pharmacist pharmacist);
        void RemoveExpiredDrugs(Pharmacist pharmacist);
        void RemoveDrugs(Drug drug);
    }
}
