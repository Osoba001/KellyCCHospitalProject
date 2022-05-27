using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class BoughtDrug:BaseEntity,IBaseModel
    {
        protected BoughtDrug()
        {

        }
        public BoughtDrug(Patient patient, Drug drug, int quantity, Acountant acountant)
        {
            Patient=patient;
            Drug=drug;
            Time=DateTime.Now;
            quantity=quantity;
            Acountant=acountant;
        }
        public virtual Patient Patient { get; set; }
        public virtual Drug Drug { get; set; }
        public virtual DateTime Time { get; set; }
        public virtual int Quantity { get; set; }
        public virtual Acountant Acountant { get; set; }
    }
}
