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
    public class PatientRepo:Repository<Patient>, IPatientRepo
    {
        protected ISession _session;
        public PatientRepo(ISession session):base(session)
        {
            _session=session;
        }

        public void BookApointment(Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public void CancelApointment(Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public List<Apointment> GetMyApointments(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public void PayForDrug(PayForDrug drug)
        {
            throw new NotImplementedException();
        }

        public void PayForTreatment(PayForTreatment treatment)
        {
            throw new NotImplementedException();
        }
    }
}
