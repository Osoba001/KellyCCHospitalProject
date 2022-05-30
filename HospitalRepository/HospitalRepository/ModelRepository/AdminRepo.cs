global using HospitalRepository.HospitalRepository.IModelRepo;
global using NHibernate;
using HospitalRepository.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class AdminRepo:Repository<Admin>,IAdminRepo
    {
        public AdminRepo(INHibernateHelper helper) : base(helper)
        {

        }
    }
}
