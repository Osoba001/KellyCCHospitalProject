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
    public class DoctorRepo:Repository<Doctor>,IDoctor
    {
        protected ISession _session;
        public DoctorRepo(ISession session) : base(session)
        {
            _session=session;
        }

        public List<Apointment> ApprovedApontment(Guid huspitalId, Guid doctorId)
        {
            throw new NotImplementedException();
        }

        public void GivenTreatment(Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public void IsDoctor(Guid huspitalId, Guid doctorId)
        {
            throw new NotImplementedException();
        }
    }
}
