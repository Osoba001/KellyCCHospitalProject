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
        List<Patient> PatientsSeenByParticularDoctoriEachDay();
        List<Patient> PatientsSeenWeekly();
        List<Patient> PatientsSeenMonthly();
        List<Patient> PatientsSeenQuarterly();
        List<Patient> PatientsSeenYealy();
    }
}
