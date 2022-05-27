using HospitalRepository.HospitalRepository.BaseRepository;
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
    public class HospitalRepo : Repository<Hospital>, IHospitalRepo
    {
        protected ISession _session;
        public HospitalRepo(ISession session) : base(session)
        {
            _session=session;
        }

        public List<Doctor> Doctors(Guid huspitalId)
        {
            throw new NotImplementedException();
        }
    }
}
