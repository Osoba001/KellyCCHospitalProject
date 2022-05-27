using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.IModelRepo
{
    public interface IHospitalRepo:IRepostory<Hospital>
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
