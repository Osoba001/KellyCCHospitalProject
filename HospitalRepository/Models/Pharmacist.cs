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
        IWrapper uow = new Wrapper();
        public void AddNewDrugToStore(string name, string purpose, string cauction, decimal unitprice, int quantity, Pharmacist pharmacist, Hospital hospital)
        {
            Drug drug=new Drug(name, purpose, cauction, unitprice, quantity, pharmacist,hospital);
            uow.DrugRep.AddEntity(drug);
            uow.Commit();
        }

        public List<Drug> GetAllDrugs(Pharmacist pharmacist)
        {
            return uow.DrugRep.FindByPredicate(x => x.Pharmacist == pharmacist).ToList();
        }


        public void RemoveDrugs(Drug drug)
        {
            uow.DrugRep.RomoveEntity(drug);
            uow.Commit();
        }

        public void SellDoctorPrescibedDrug(BoughtDrug drug)
        {
            drug.IsPharmacistAprove = true;
            uow.BoughtDrug.UpdateEntity(drug);
            var p = drug.Patient.Bills;
            p.BoughtDrugs.Add(drug);
            var d=uow.DrugRep.FindByPredicate(x=>x.Id==drug.Drug.Id).FirstOrDefault();
            d.Quantity = -drug.Quantity;
            uow.DrugRep.UpdateEntity(d);
            uow.Commit();

        }

        public void SellDrug(Patient patient, Drug drug, int quantity, string instruction)
        {
           BoughtDrug newdrug=new BoughtDrug(patient, drug, quantity, instruction);
            newdrug.IsPharmacistAprove = true;
            drug.Quantity = -quantity;
            uow.DrugRep.UpdateEntity(drug);
            uow.BoughtDrug.AddEntity(newdrug);
            patient.Bills.BoughtDrugs.Add(newdrug);
            uow.PatientRepo.UpdateEntity(patient);
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
            var p = uow.DrugRep.FindByPredicate(x => x.Id == drug.Id).FirstOrDefault();
            if (p!=null)
            {
                p.Purpose=drug.Purpose;
                p.Caution=drug.Caution;
                p.UnitPrice=drug.UnitPrice;
                uow.DrugRep.UpdateEntity(p);
                uow.Commit();
            }
            else
            {
                throw new Exception("Drug dose not exist in the record");
            }
        }
        public void IncreaseDrugQuantity(Drug drug, int quantityIncreasement)
        {
            var p=uow.DrugRep.FindByPredicate(x=>x.Id==drug.Id).FirstOrDefault();
            if (p!=null)
            {
                drug.Quantity = quantityIncreasement;
                uow.DrugRep.UpdateEntity(p);
                uow.Commit();
            }
            else
            {
                throw new Exception("Drug dose not exist in the record");
            }

        }
    }
}
