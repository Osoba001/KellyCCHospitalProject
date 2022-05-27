// See https://aka.ms/new-console-template for more information

using HospitalRepository.IFunctionalities;
using HospitalRepository.NHibernateDatabaseAccess.Models;

public class AdminFun : IAdmin
{
    public Acountant Acountant(Guid huspitalIds)
    {
        throw new NotImplementedException();
    }

    public void CreateHospital(Hospital hospital)
    {
        throw new NotImplementedException();
    }

    public List<Doctor> Doctors(Guid huspitalId)
    {
        throw new NotImplementedException();
    }

    public List<Staff> GetAllStaff(Guid huspitalIds)
    {
        throw new NotImplementedException();
    }

    public List<Nurse> Nurses(Guid huspitalIds)
    {
        throw new NotImplementedException();
    }

    public List<Patient> Patients(Guid huspitalIds)
    {
        throw new NotImplementedException();
    }

    public List<Pharmacist> pharmacists(Guid huspitalIds)
    {
        throw new NotImplementedException();
    }

    public Receptionist Receptionist(Guid huspitalIds)
    {
        throw new NotImplementedException();
    }
}

public class AcountantFunc : IAcountant
{
    public List<Payment> AllPayment(string hospitalId)
    {
        throw new NotImplementedException();
    }

    public List<Patient> PatientsOwing(Guid hospitalId)
    {
        throw new NotImplementedException();
    }

    public List<Payment> PaymentInADay(Guid hospitalId, DateTime day)
    {
        throw new NotImplementedException();
    }

    public List<Payment> PaymentInAMonth(Guid hospitalId, DateTime month)
    {
        throw new NotImplementedException();
    }

    public List<Payment> PaymentInAWeek(Guid hospitalId, DateTime week)
    {
        throw new NotImplementedException();
    }

    public List<Payment> PaymentInAYear(Guid hospitalId, DateTime year)
    {
        throw new NotImplementedException();
    }
}

public class ReceptionistFunc : IReceptionist
{
    public void AproveApoint(Patient patient, Apointment apointment)
    {
        throw new NotImplementedException();
    }

    public void BookApointment(Apointment apointment)
    {
        throw new NotImplementedException();
    }

    public List<Apointment> GetFuctureApoints()
    {
        throw new NotImplementedException();
    }

    public List<Patient> PatientsSeenByParticularDoctoriEachDay(Guid huspitalId)
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

    public List<Patient> PatientsSeenWeekly(Guid huspitalId)
    {
        throw new NotImplementedException();
    }

    public List<Patient> PatientsSeenYealy(Guid huspitalId)
    {
        throw new NotImplementedException();
    }
}
public class DoctorFun : IDoctor
{
    public List<Apointment> ApprovedApontment(Guid huspitalId, Guid doctorId)
    {
        throw new NotImplementedException();
    }

    public void GivenTreatment(Treatment treatment)
    {
        throw new NotImplementedException();
    }

    public void IsDoctor(Guid huspitalId, Guid doctorId)
    {
        throw new NotImplementedException();
    }
}
public class PatientFuct : IPatient
{
    public void BookApointment(Apointment apointment)
    {
        throw new NotImplementedException();
    }

    public void CancelApointment(Apointment apointment)
    {
        throw new NotImplementedException();
    }

    public List<Apointment> GetMyApointments(Guid patientId)
    {
        throw new NotImplementedException();
    }

    public void PayForDrug(PayForDrug drug)
    {
        throw new NotImplementedException();
    }

    public void PayForTreatment(PayForTreatment treatment)
    {
        throw new NotImplementedException();
    }
}
public class PharmacistFun : IPharmacist
{
    public void AddNewDrugToStore(Drug drug)
    {
        throw new NotImplementedException();
    }

    public List<Drug> GetExpiredDrugs(Guid phmId)
    {
        throw new NotImplementedException();
    }

    public void RemoveExpiredDrugs(Guid phmId)
    {
        throw new NotImplementedException();
    }

    public void SeleDrug(BoughtDrug drug)
    {
        throw new NotImplementedException();
    }

    public List<Drug> Top10MostBoughtDrugs(Guid hospitalId, Guid phmId)
    {
        throw new NotImplementedException();
    }

    public void UpdateDrugQuantity(Drug drug)
    {
        throw new NotImplementedException();
    }
}