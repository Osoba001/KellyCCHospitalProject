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
    public class AccountantRepo:Repository<Acountant>,IAcountant
    {
        protected ISession _session;
        public AccountantRepo(ISession session) : base(session)
        {
            _session=session;
        }

        public List<Patient> AllPayment(string hospitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsOwing(Guid hospitalId)
        {
            throw new NotImplementedException();
        }

        public List<Payment> PaymentInADay(Guid hospitalId, DateTime day)
        {
            throw new NotImplementedException();
        }

        public List<Payment> PaymentInAMonth(Guid hospitalId, DateTime month)
        {
            throw new NotImplementedException();
        }

        public List<Payment> PaymentInAWeek(Guid hospitalId, DateTime week)
        {
            throw new NotImplementedException();
        }

        public List<Payment> PaymentInAYear(Guid hospitalId, DateTime year)
        {
            throw new NotImplementedException();
        }
    }
}
