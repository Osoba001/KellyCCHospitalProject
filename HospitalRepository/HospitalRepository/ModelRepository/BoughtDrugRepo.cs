using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class BoughtDrugRepo:Repository<BoughtDrug>,IBoughtDrugRepo
    {
        public BoughtDrugRepo(INHibernateHelper helper) : base(helper)
        {

        }
    }
}
