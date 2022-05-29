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
        public List<Apointment> GetFuctureApoints(Hospital hospital)
        {
            var uow = new Wrapper();
            return uow.Apointment.FindByPredicate(x => x.Patient.Hospital == hospital).ToList();
        }

        public void AproveApoint(Apointment apointment, Doctor doctor, DateTime time)
        {
            apointment.Doctor=doctor;
            apointment.ApointmentTime = time;
            apointment.IsApprove=true;
            var uow = new Wrapper();
            uow.Apointment.UpdateEntity(apointment);
            uow.Commit();
        }

        public void RescheduleApoint(Apointment apointment, DateTime time)
        {
            apointment.ApointmentTime = time;
            var uow = new Wrapper();
            uow.Apointment.UpdateEntity(apointment);
            uow.Commit();
        }

        public void BookApointment(string discription, Patient patient, DateTime time)
        {
            var uow = new Wrapper();
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
                Apointment apointment = new Apointment(discription, patient);
                apointment.ApointmentTime = time;
                apointment.IsApprove = true;
                uow.Apointment.AddEntity(apointment);
            }

            uow.Commit();
        }

        public List<Patient> PatientsSeenByDoctoriEachDay(Doctor doctor, DateTime time)
        {
            var uow = new Wrapper();
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
            var uow = new Wrapper();
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
            var uow = new Wrapper();
            return uow.PatientRepo.FindByPredicate(x => x.
            Apointment.Doctor == doctor && x.
            Apointment.IsAttendedTo && x.
            Apointment.ApointmentTime.Year == time.Year).ToList();
        }

        

    }
}
