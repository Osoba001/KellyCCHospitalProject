using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class BoughtDrugsRepo:Repository<BoughtDrug>,IBoughtDrugRepo
    {
        public BoughtDrugsRepo(ISession session) : base(session)
        {

        }
    }
}
