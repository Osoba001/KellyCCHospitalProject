using HospitalRepository.HospitalEnums;
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
        public Payment(decimal amount, Patient patient, Hospital hospital, PaymentFor payingFor)
        {
            Amount= amount;
            Patient= patient;
            TimeOfPayment = DateTime.Now;
            IsAprove = false;
            Hospital= hospital;
            PayingFor= payingFor;
        }
        public virtual decimal Amount { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual DateTime TimeOfPayment { get; set; }
        public virtual bool  IsAprove { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual PaymentFor PayingFor { get; set; }
    }
}
