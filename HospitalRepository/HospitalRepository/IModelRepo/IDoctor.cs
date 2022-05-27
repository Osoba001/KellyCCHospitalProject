using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.IModelRepo
{
    public interface IDoctor:IRepostory<Doctor> 
    {
        List<Doctor> Doctors(Guid huspitalId);
        List<Apointment> ApprovedApontment(Guid huspitalId, Guid doctorId);
        void GivenTreatment(Treatment treatment);
    }
}
