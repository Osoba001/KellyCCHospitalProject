using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.IModelRepo
{
    public interface IAcountant:IRepostory<Acountant>
    {
        List<Patient> PatientsOwing(Guid hospitalId);
        List<Patient> AllPayment(string hospitalId);
        List<Payment> PaymentInAYear(Guid hospitalId, DateTime year);
        List<Payment> PaymentInAMonth(Guid hospitalId, DateTime month);
        List<Payment> PaymentInAWeek(Guid hospitalId,DateTime week);
        List<Payment> PaymentInADay(Guid hospitalId, DateTime day);
    }
}
