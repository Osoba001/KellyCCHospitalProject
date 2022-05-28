using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Payment:BaseEntity,IBaseModel
    {
        public Payment()
        {

        }
        public Payment(decimal amount, Patient patient)
        {
            Amount= amount;
            Patient= patient;
            TimeOfPayment = DateTime.Now;
            IsAprove = false;
        }
        public virtual decimal Amount { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual DateTime TimeOfPayment { get; set; }
        public virtual bool  IsAprove { get; set; }
    }
}
