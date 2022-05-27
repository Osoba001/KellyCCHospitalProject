using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Payment:BaseEntity
    {
        public Payment()
        {

        }
        public Payment(decimal amount, Patient patient, Acountant acountant)
        {
            Amount= amount;
            Patient= patient;
            Acountant= acountant;
            TimeOfPayment = DateTime.Now;
        }
        public virtual decimal Amount { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual DateTime TimeOfPayment { get; set; }
        public virtual Acountant Acountant { get; set; }
    }
}
