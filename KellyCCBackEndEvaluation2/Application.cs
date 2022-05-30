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
        IAcountant _acountant;
        IPatient _patient;
        IPharmacist _pharmacist;
        IReceptionist _receptionist;
        public Application(IDoctor doctor, IAcountant acountant, IPatient patient, IPharmacist pharmacist, IReceptionist receptionist)
        {
            _doctor = doctor;
            _acountant = acountant;
            _patient = patient;
            _pharmacist = pharmacist;
            _receptionist = receptionist;
        }
        public void RunDoctors()
        {
            
        }

        public void RunAcountant()
        {

        }

        public void RunPatient()
        {

        }
        public void RunPharmacist()
        {

        }
        public void RunReceptionist()
        {

        }
    }
}
