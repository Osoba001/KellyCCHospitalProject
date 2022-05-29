using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Apointment:BaseEntity, IBaseModel
    {
        public Apointment()
        {

        }
        public Apointment(Patient patient)
        {
            Patient= patient;
            IsAttendedTo = false;
            IsActive =true;
            IsApprove = false;
            ApointmentType = ApointmentType.Monthly;
        }
        public virtual string Discription { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ApointmentType ApointmentType { get; set; }
        private DateTime _apointmentTime;

        public virtual DateTime ApointmentTime
        {
            get { return _apointmentTime; }
            set {
                if (value > DateTime.Now)
                {
                    _apointmentTime = value;
                }
                else throw new Exception("Apointment Time can not be less than current time");
            }
        }
        public virtual DateTime BookedTime { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsApprove { get; set; }
        public virtual bool IsAttendedTo { get; set; }
    }
}
