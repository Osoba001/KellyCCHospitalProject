global using HospitalRepository.HospitalRepository.BaseRepository;
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
    public class ReceptionistRepo : Repository<Receptionist>, IReceptionist
    {
        protected ISession _session;
        public ReceptionistRepo(ISession session):base(session)
        {
            _session=session;   
        }

        public void AproveApoint(Patient patient, Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public void BookApointment(Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public List<Apointment> GetFuctureApoints()
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenByParticularDoctoriEachDay(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenMonthly(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenQuarterly(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenWeekly(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenYealy(Guid huspitalId)
        {
            throw new NotImplementedException();
        }
    }
}
