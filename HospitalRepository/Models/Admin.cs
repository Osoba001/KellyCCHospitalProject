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
        public Admin(string name, Gender gender, string phoneNo, string email, string addres, Hospital hospital) : base(name, gender, phoneNo, email, addres, hospital)
        {

        }


        //Functionalities
        public virtual Acountant Acountant(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public virtual void CreateHospital(Hospital hospital)
        {
            throw new NotImplementedException();
        }

        public virtual List<Doctor> Doctors(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public virtual List<Staff> GetAllStaff(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public virtual List<Nurse> Nurses(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public virtual List<Patient> Patients(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public virtual List<Pharmacist> pharmacists(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }

        public virtual Receptionist Receptionist(Guid huspitalIds)
        {
            throw new NotImplementedException();
        }
    }
}
