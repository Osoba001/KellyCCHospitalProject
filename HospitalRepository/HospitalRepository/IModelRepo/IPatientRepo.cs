using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.IModelRepo
{
    public interface IPatientRepo: IRepostory<Patient>
    {
        void BookApointment(Apointment apointment);
        void PayForDrug(PayForDrug drug);
        void PayForTreatment(PayForTreatment treatment);
        void CancelApointment(Apointment apointment);
        List<Apointment> GetMyApointments(Guid patientId);
    }
}
