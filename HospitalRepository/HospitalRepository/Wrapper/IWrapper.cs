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
        IReceptionistRepo Receptionist { get; }
        IPharmacistRepo Pharmacist { get; }
        INurseRepo NurseRepo { get; }
        IHospitalRepo HospitalRepo { get; }
        IDoctorRepo DoctorReo { get; }
        IAcountantRepo Acountant { get; }
        IAdminRepo Admin { get; }
        IApointmentRepo Apointment { get; }
        IBoughtDrugRepo BoughtDrug { get; }
        IPaymentRepo Payment { get; }
        IStaffIDRepo StaffIDRepo { get; }
        ITreatmentRepo TreatmentReo { get; }
        void Commit();
    }
}
