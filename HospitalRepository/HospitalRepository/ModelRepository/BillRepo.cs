using HospitalRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class BillRepo:Repository<Bills>,IBillRepo
    {
        public BillRepo(INHibernateHelper helper) : base(helper)
        {

        }
    }
}
