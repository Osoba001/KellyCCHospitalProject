using HospitalRepository.HospitalEnums;
using HospitalRepository.IFunctionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Pharmacist: Staff, IBaseModel,IPharmacist
    {
        public Pharmacist(string name, Gender gender, string phoneNo, string email, string addres, Hospital hospital) : base(name, gender, phoneNo, email, addres, hospital)
        {
            Drugs = new List<Drug>();
        }
        public virtual List<Drug> Drugs { get; set; }

        //Functionalities
        public void AddNewDrugToStore(string name, DateOnly exp, DateOnly manufac, decimal unitprice, int quantity, Pharmacist pharmacist)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetAllDrugs(Guid phmId)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetExpiredDrugs(Guid phmId)
        {
            throw new NotImplementedException();
        }

        public void RemoveDrugs(Guid phmId)
        {
            throw new NotImplementedException();
        }

        public void RemoveExpiredDrugs(Guid phmId)
        {
            throw new NotImplementedException();
        }

        public void SeleDrug(Patient patient, Drug drug, int quantity)
        {
            throw new NotImplementedException();
        }

        public List<Drug> Top10MostBoughtDrugs(Guid hospitalId, Guid phmId)
        {
            throw new NotImplementedException();
        }

        public void UpdateDrug(Drug drug)
        {
            throw new NotImplementedException();
        }
    }
}
