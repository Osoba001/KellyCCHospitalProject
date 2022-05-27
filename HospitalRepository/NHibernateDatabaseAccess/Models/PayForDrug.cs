using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class PayForDrug:Payment, IBaseModel
    {
        protected PayForDrug()
        {

        }
        public PayForDrug(decimal amount, Patient patient, Drug drug, Acountant acountant) :base(amount, patient,acountant)
        {
            Drug = drug;
        }
        public virtual Drug Drug { get; set; }
    }
}
