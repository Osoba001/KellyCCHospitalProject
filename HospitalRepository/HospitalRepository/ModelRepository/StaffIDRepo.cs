using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class StaffIDRepo:Repository<StaffID>,IStaffIDRepo
    {
        public StaffIDRepo(INHibernateHelper helper) : base(helper)
        {

        }
    }
}
