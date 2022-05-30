using HospitalRepository.HospitalRepository.Wrapper;
using HospitalRepository.IFunctionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KellyCCBackEndEvaluation2
{
    public class Application : IApplication
    {
        IDoctor _doctor;
        public Application(IDoctor doctor)
        {
            _doctor = doctor;
        }
        public void RunDoctors()
        {
            
        }

        IAcountant _acountant;
        public Application(IAcountant acountant)
        {
            _acountant = acountant;
        }
        public void RunAcountant()
        {

        }

        IPatient _patient;
        public Application(IPatient patient)
        {
            _patient = patient;
        }
        public void RunPatient()
        {

        }

        IPharmacist _pharmacist;
        public Application(IPharmacist pharmacist)
        {
            _pharmacist = pharmacist;
        }
        public void RunPharmacist()
        {

        }

        IReceptionist _receptionist;
        public Application(IReceptionist receptionist)
        {
            _receptionist = receptionist;
        }
        public void RunReceptionist()
        {

        }
    }
}
