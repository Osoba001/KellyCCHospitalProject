using HospitalRepository.HospitalEnums;
using HospitalRepository.IFunctionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Receptionist : Staff,IBaseModel,IReceptionist
    {
        protected Receptionist()
        {

        }
        public Receptionist(string name, Gender gender, Contact contact, Hospital hospital) : base(name, gender, contact, hospital)
        {

        }

        //Functionalities
        public List<Apointment> GetFuctureApoints()
        {
            throw new NotImplementedException();
        }

        public void AproveApoint(Apointment apointment)
        {
            throw new NotImplementedException();
        }

        public void BookApointment(string discription, Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenByParticularDoctoriEachDay(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenWeekly(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenMonthly(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenQuarterly(Guid huspitalId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenYealy(Guid huspitalId)
        {
            throw new NotImplementedException();
        }
    }
}
