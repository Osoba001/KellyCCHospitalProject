using HospitalRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class BoughtDrug: HospitalService
    {
        protected BoughtDrug()
        {

        }
        public BoughtDrug(Patient patient, Drug drug, int quantity): base(patient)
        {
            Drug=drug;
            quantity=quantity;
            Amount=quantity*drug.UnitPrice;
        }
        public virtual Drug Drug { get; set; }
        public virtual int Quantity { get; set; }
    }
}
