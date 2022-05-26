using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.IModelRepo
{
    public interface IReceptionist:IRepostory<Receptionist>
    {
        void BookingApointforPatient(Patient patient,Apointment apointment);
    }
}
