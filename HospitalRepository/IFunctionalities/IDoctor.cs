using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace HospitalRepository.IFunctionalities
{
    public interface IDoctor
    {
        List<Apointment> ApprovedApontment(Doctor doctor);
        List<Apointment> ApprovedApontmentOnAParticularDay(Doctor doctor, DateTime day);
        void GivenTreatment(string name,decimal amount, Patient patient, Doctor doctor);
        void IsDoctorFree( Doctor doctor);
        void PrescribeDrug(Doctor doctor, Patient patient, Drug drug, int quantity, string instruction);
        void AttendToApointment(Apointment apointment);
    }
}
