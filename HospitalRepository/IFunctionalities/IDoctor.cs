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
        List<Apointment> ApprovedApontment(Guid huspitalId, Guid doctorId);
        void GivenTreatment(string name,decimal amount, Patient patient, Doctor doctor);
        void IsDoctorFree(Guid huspitalId, Guid doctorId);
    }
}
