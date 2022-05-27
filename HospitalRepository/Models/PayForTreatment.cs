using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class PayForTreatment:Payment, IBaseModel
    {
        protected PayForTreatment()
        {

        }
        public PayForTreatment(decimal amount, Patient patient, Treatment treatment, Acountant acountant) : base(amount, patient,acountant)
        {
            Treatment=treatment;
        }
        public virtual Treatment Treatment { get; set; }
    }
}
