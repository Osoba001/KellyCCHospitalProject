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
        public void AddNewDrugToStore(string name, string purpose, string cauction, decimal unitprice, int quantity, Pharmacist pharmacist, Hospital hospital)
        {
            Drug drug=new Drug(name, purpose, cauction, unitprice, quantity, pharmacist,hospital);
            var uow = new Wrapper();
            uow.DrugRep.AddEntity(drug);
            uow.Commit();
        }

        public List<Drug> GetAllDrugs(Pharmacist pharmacist)
        {
            var uow = new Wrapper();
            return uow.DrugRep.FindByPredicate(x => x.Pharmacist == pharmacist).ToList();
        }


        public void RemoveDrugs(Drug drug)
        {
            var uow = new Wrapper();
            uow.DrugRep.RomoveEntity(drug);
            uow.Commit();
        }

        public void SellDoctorPrescibedDrug(BoughtDrug drug)
        {
            drug.IsPharmacistAprove = true;
            var uow = new Wrapper();
            uow.BoughtDrug.UpdateEntity(drug);
            var d=uow.DrugRep.FindByPredicate(x=>x.Id==drug.Drug.Id).FirstOrDefault();
            if (d!=null)
            {
                d.Quantity = -drug.Quantity;
                uow.DrugRep.UpdateEntity(d);
                uow.Commit();
            }
            
        }

        public void SellDrug(Patient patient, Drug drug, int quantity, string instruction)
        {
           BoughtDrug newdrug=new BoughtDrug(patient, drug, quantity, instruction);
            newdrug.IsPharmacistAprove = true;
            var uow = new Wrapper();
            drug.Quantity = -quantity;
            uow.DrugRep.UpdateEntity(drug);
            uow.BoughtDrug.AddEntity(newdrug);
            uow.Commit();
        }

        public List<Drug> Top10MostBoughtDrugs(Hospital hospital)
        {
            var uow = new Wrapper();
            return uow.DrugRep.FindByPredicate(x=>x.Hospital==hospital)
                .OrderByDescending(x=>x.BoughtDrugs.Count()).Take(10).ToList();
        }

        public void UpdateDrugInfo(Drug drug)
        {
            var uow = new Wrapper();
            var p = uow.DrugRep.FindByPredicate(x => x.Id == drug.Id).FirstOrDefault();
            if (p!=null)
            {
                p.Purpose=drug.Purpose;
                p.Caution=drug.Caution;
                p.UnitPrice=drug.UnitPrice;
                uow.DrugRep.UpdateEntity(p);
                uow.Commit();
            }
        }
        public void IncreaseDrugQuantity(Drug drug, int quantityIncreasement)
        {
            var uow = new Wrapper();
            var p=uow.DrugRep.FindByPredicate(x=>x.Id==drug.Id).FirstOrDefault();
            if (p!=null)
            {
                drug.Quantity = quantityIncreasement;
                uow.DrugRep.UpdateEntity(p);
            }
        }
    }
}
