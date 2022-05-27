using HospitalRepository.HospitalRepository.IModelRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.Wrapper
{
    public interface IWrapper
    {
        IPatientRepo PatientRepo { get; }
        IDrugRep DrugRep { get; }
        IReceptionist Receptionist { get; }
        IPharmacist Pharmacist { get; }
        INurseRepo NurseRepo { get; }
        IHospitalRepo HospitalRepo { get; }
        IDoctor DoctorReo { get; }
        IAcountant Acountant { get; }
        void Commit();
    }
}
