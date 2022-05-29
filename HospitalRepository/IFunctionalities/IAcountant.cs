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
        public List<Payment> AllPayment(Hospital hospital);
        List<Patient> PatientsOwing(Hospital hospital);
        List<Payment> PaymentWithinAPeriod(Hospital hospital, DateTime start, DateTime end);
        void AprovePayment(Payment payment);
        void BillPatientOnDrug(Patient patient, BoughtDrug boughtDrug);
        void BillPatientOnTreatment(Patient patient, Treatment treatment);
    }
}
