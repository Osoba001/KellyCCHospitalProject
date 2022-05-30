using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class PaymentRepo:Repository<Payment>,IPaymentRepo
    {
        public PaymentRepo(INHibernateHelper helper) : base(helper)
        {

        }
    }
}
