using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalRepository.NHibernateDatabaseAccess.Models;
namespace HospitalRepository.IFunctionalities
{
    public interface IAdmin
    {
        void CreateHospital(Hospital hospital);
        List<Doctor> Doctors(Guid huspitalId);
        List<Pharmacist> pharmacists(Guid huspitalIds);
        List<Nurse> Nurses(Guid huspitalIds);
        List<Patient> Patients(Guid huspitalIds);
        Acountant Acountant(Guid huspitalIds);
        Receptionist Receptionist(Guid huspitalIds);
        List<Staff> GetAllStaff(Guid huspitalIds);
    }
}
