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
        List<Patient> PatientsSeenByParticularDoctoriEachDay(Guid huspitalId);
        List<Patient> PatientsSeenWeekly(Guid huspitalId);
        List<Patient> PatientsSeenMonthly(Guid huspitalId);
        List<Patient> PatientsSeenQuarterly(Guid huspitalId);
        List<Patient> PatientsSeenYealy(Guid huspitalId);
    }
}
