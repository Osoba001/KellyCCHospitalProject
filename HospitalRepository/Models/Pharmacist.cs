using HospitalRepository.HospitalEnums;
using HospitalRepository.HospitalRepository.Wrapper;
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
        public void AddNewDrugToStore(string name, DateTime exp, DateTime manufac, decimal unitprice, int quantity, Pharmacist pharmacist)
        {
            Drug drug=new Drug(name, exp, manufac, unitprice, quantity, pharmacist);
            var uow = new Wrapper();
            uow.DrugRep.AddEntity(drug);
            uow.Commit();
        }

        public List<Drug> GetAllDrugs(Pharmacist pharmacist)
        {
            var uow = new Wrapper();
            return uow.DrugRep.FindByPredicate(x => x.Pharmacist == pharmacist).ToList();
        }

        public List<Drug> GetExpiredDrugs(Pharmacist pharmacist)
        {
            var uow = new Wrapper();
            return uow.DrugRep.FindByPredicate(x=>x.ExpiringDate<=DateTime.Now && pharmacist==pharmacist).ToList();
        }

        public void RemoveDrugs(Drug drug)
        {
            var uow = new Wrapper();
            uow.DrugRep.RomoveEntity(drug);
            uow.Commit();
        }

        public void RemoveExpiredDrugs(Pharmacist pharmacist)
        {
            var uow = new Wrapper();
            var p=uow.DrugRep.FindByPredicate(x=>x.ExpiringDate>=DateTime.Now && x.Pharmacist== pharmacist).ToList();
            p.ForEach(x => uow.DrugRep.RomoveEntity(x));
            uow.Commit();
        }

        public void SellDoctorPrescibedDrug(BoughtDrug drug)
        {
            drug.IsPharmacistAprove = true;
            var uow = new Wrapper();
            uow.BoughtDrug.UpdateEntity(drug);
            var d=uow.DrugRep.FindByPredicate(x=>x.Id==drug.Drug.Id).FirstOrDefault();
            d.Quantity++;
            uow.DrugRep.UpdateEntity(d);
            uow.Commit();
        }

        public void SellNewDrug(Patient patient, Drug drug, int quantity, string instruction)
        {
           BoughtDrug newdrug=new BoughtDrug(patient, drug, quantity, instruction);
            newdrug.IsPharmacistAprove = true;
            var uow = new Wrapper();
            uow.BoughtDrug.AddEntity(newdrug);
            uow.Commit();
        }

        public List<Drug> Top10MostBoughtDrugs(Hospital hospital)
        {
            var uow = new Wrapper();
            return uow.BoughtDrug.FindByPredicate(x=>x.)
        }

        public void UpdateDrug(Drug drug)
        {
            throw new NotImplementedException();
        }
    }
}
