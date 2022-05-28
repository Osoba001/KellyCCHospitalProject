using HospitalRepository.HospitalEnums;
using HospitalRepository.IFunctionalities;
using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.Models
{
    public class Admin : Staff, IBaseModel,IAdmin
    {
        public Admin()
        {

        }
        public Admin(string name, Gender gender, Contact contact, Hospital hospital) : base(name, gender, contact, hospital)
        {

        }


        //Functionalities
        public Acountant Acountant(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public void CreateHospital(Hospital hospital)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> Doctors(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Staff> GetAllStaff(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public List<Nurse> Nurses(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public List<Patient> Patients(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public List<Pharmacist> pharmacists(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public Receptionist Receptionist(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }
    }
}
