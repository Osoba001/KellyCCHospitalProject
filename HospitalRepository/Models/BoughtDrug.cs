using HospitalRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class BoughtDrug: BaseEntity, IBaseModel
    {
        public BoughtDrug()
        {

        }
        public BoughtDrug(Patient patient, Drug drug, int quantity,string instruction)
        {
            Drug=drug;
            Quantity = quantity;
            Patient=patient;
            Instructions=instruction;
            IsPharmacistAprove = false;
            Date=DateTime.Now;
        }
        public virtual Patient Patient { get; set; }
        public virtual Drug Drug { get; set; }
        public virtual int Quantity { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual string Instructions { get; set; }
        public virtual bool IsPharmacistAprove { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual decimal Amount => Drug.UnitPrice * Quantity;
    }
}
