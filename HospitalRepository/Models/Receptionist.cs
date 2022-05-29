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
        public virtual List<Apointment> GetFuctureApoints(Hospital hospital)
        {
            return uow.Apointment.FindByPredicate(x => x.Patient.Hospital == hospital).ToList();
        }

        public virtual void AproveApoint(Apointment apointment, Doctor doctor, DateTime time)
        {
            apointment.Doctor=doctor;
            apointment.ApointmentTime = time;
            apointment.IsApprove=true;
            uow.Apointment.UpdateEntity(apointment);
            uow.Commit();
        }

        public virtual void RescheduleApoint(Apointment apointment, DateTime time)
        {
            apointment.ApointmentTime = time;
            uow.Apointment.UpdateEntity(apointment);
            uow.Commit();
        }

        public virtual void BookApointment(string discription, Patient patient, DateTime time)
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
                uow.Apointment.AddEntity(apointment);
                
            }

            uow.Commit();
        }

        public virtual List<Patient> PatientsSeenByDoctorDaily(Doctor doctor)
        {
            return uow.PatientRepo.FindByPredicate(x=>x.
            Apointment.Doctor==doctor && x.
            Apointment.IsAttendedTo && x.
            Apointment.ApointmentType== ApointmentType.Daily).ToList();
        }

        public virtual List<Patient> PatientsSeenWeekly(Doctor doctor)
        {
            return uow.PatientRepo.FindByPredicate(x => x.
             Apointment.Doctor == doctor && x.
             Apointment.IsAttendedTo && x.
             Apointment.ApointmentType == ApointmentType.Weekly).ToList();
        }

        public virtual List<Patient> PatientsSeenMonthly(Doctor doctor)
        {
            return uow.PatientRepo.FindByPredicate(x => x.
            Apointment.Doctor == doctor && x.
            Apointment.IsAttendedTo && x.
            Apointment.ApointmentType == ApointmentType.Monthly).ToList();
        }

        public List<Patient> PatientsSeenQuarterly(Doctor doctor)
        {
            return uow.PatientRepo.FindByPredicate(x => x.
             Apointment.Doctor == doctor && x.
             Apointment.IsAttendedTo && x.
             Apointment.ApointmentType == ApointmentType.Quacterly).ToList();
        }

        public virtual List<Patient> PatientsSeenYealy(Doctor doctor)
        {
            return uow.PatientRepo.FindByPredicate(x => x.
             Apointment.Doctor == doctor && x.
             Apointment.IsAttendedTo && x.
             Apointment.ApointmentType == ApointmentType.Yearly).ToList();
        }

        public virtual Apointment CheckPatientAPointment(Patient patient)
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

        public virtual void ChechOutPatient(Patient patient)
        {
            patient.Apointment.IsApprove = false;
            patient.Apointment.IsActive = true;
            patient.Apointment.IsAttendedTo = true;
            uow.PatientRepo.UpdateEntity(patient);
        }
    }
}
