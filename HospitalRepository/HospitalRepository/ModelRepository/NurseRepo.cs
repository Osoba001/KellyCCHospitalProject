using HospitalRepository.HospitalRepository.IModelRepo;
using HospitalRepository.NHibernateDatabaseAccess.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class NurseRepo:Repository<Nurse>,INurseRepo
    {
        public NurseRepo(INHibernateHelper helper) : base(helper)
        {
;
        }
    }
}
