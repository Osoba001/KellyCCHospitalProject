using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class TreatmentRepo:Repository<Treatment>,ITreatmentRepo
    {
        public TreatmentRepo(INHibernateHelper helper) : base(helper)
        {

        }
    }
}
