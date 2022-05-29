using HospitalRepository.HospitalEnums;
using HospitalRepository.HospitalRepository.Wrapper;
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
        public Receptionist(string name, Gender gender, string phoneNo, string email, string addres, Hospital hospital) : base(name, gender, phoneNo, email, addres, hospital)
        {

        }
        //Functionalities
        IWrapper uow = new Wrapper();
        public List<Apointment> GetFuctureApoints(Hospital hospital)
        {
            return uow.Apointment.FindByPredicate(x => x.Patient.Hospital == hospital).ToList();
        }

        public void AproveApoint(Apointment apointment, Doctor doctor, DateTime time)
        {
            apointment.Doctor=doctor;
            apointment.ApointmentTime = time;
            apointment.IsApprove=true;
            uow.Apointment.UpdateEntity(apointment);
            uow.Commit();
        }

        public void RescheduleApoint(Apointment apointment, DateTime time)
        {
            apointment.ApointmentTime = time;
            uow.Apointment.UpdateEntity(apointment);
            uow.Commit();
        }

        public void BookApointment(string discription, Patient patient, DateTime time)
        {
            var p = uow.Apointment.FindByPredicate(x => x.Patient == patient).FirstOrDefault();
            if (p != null)
            {
                p.IsApprove = true;
                p.IsActive = true;
                p.IsAttendedTo = false;
                p.Discription = discription;
                p.BookedTime = DateTime.Now;
                p.ApointmentTime = time;
                uow.Apointment.UpdateEntity(p);
            }
            else
            {
                Apointment apointment = new Apointment(patient);
                apointment.ApointmentTime = time;
                apointment.IsApprove = true;
                apointment.IsActive = true;
                apointment.IsAttendedTo = false;
                apointment.Discription = discription;
                apointment.BookedTime = DateTime.Now;
                apointment.ApointmentTime = time;
                patient.Apointment=apointment;
                uow.PatientRepo.UpdateEntity(patient);
            }

            uow.Commit();
        }

        public List<Patient> PatientsSeenByDoctoriEachDay(Doctor doctor, DateTime time)
        {
            return uow.PatientRepo.FindByPredicate(x=>x.
            Apointment.Doctor==doctor && x.
            Apointment.IsAttendedTo && x.
            Apointment.ApointmentTime.Day==time.Day).ToList();
        }

        public List<Patient> PatientsSeenWeekly(Doctor doctor, DateTime time)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenMonthly(Doctor doctor, DateTime time)
        {
            return uow.PatientRepo.FindByPredicate(x => x.
            Apointment.Doctor == doctor && x.
            Apointment.IsAttendedTo && x.
            Apointment.ApointmentTime.Month == time.Month).ToList();
        }

        public List<Patient> PatientsSeenQuarterly(Doctor doctor, DateTime time)
        {
            throw new NotImplementedException();
        }

        public List<Patient> PatientsSeenYealy(Doctor doctor, DateTime time)
        {
            
            return uow.PatientRepo.FindByPredicate(x => x.
            Apointment.Doctor == doctor && x.
            Apointment.IsAttendedTo && x.
            Apointment.ApointmentTime.Year == time.Year).ToList();
        }

        public Apointment CheckPatientAPointment(Patient patient)
        {
            if (patient.IsRegister)
            {
                var p = uow.Apointment.FindByPredicate(x => x.Patient == patient);
                if (p == null)
                {
                    throw new Exception("Patient does not have apointment");
                }
                else
                {
                    return p.FirstOrDefault();
                }
            }
            else
            {
                throw new Exception("Patient is not register");
            }
           
        }

        public void ChechOutPatient(Patient patient)
        {
            patient.Apointment.IsApprove = false;
            patient.Apointment.IsActive = true;
            patient.Apointment.IsAttendedTo = true;
            uow.PatientRepo.UpdateEntity(patient);
        }
    }
}
