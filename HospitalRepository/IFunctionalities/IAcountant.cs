using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalRepository.NHibernateDatabaseAccess.Models;

namespace HospitalRepository.IFunctionalities
{
    public interface IAcountant
    {
        List<Patient> PatientsOwing(Guid hospitalId);
        List<Payment> AllPayment(Guid hospitalId);
        List<Payment> PaymentInAYear(Guid hospitalId, DateTime year);
        List<Payment> PaymentInAMonth(Guid hospitalId, DateTime month);
        List<Payment> PaymentInAWeek(Guid hospitalId, DateTime week);
        List<Payment> PaymentInADay(Guid hospitalId, DateTime day);
        void AprovePayment(Payment payment);
    }
}
