using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Apointment:BaseEntity, IBaseModel
    {
        protected Apointment()
        {

        }
        public Apointment(string distriction, Patient patient, Hospital hospital)
        {
            Discription= distriction;
            Patient= patient;
            hospital= Hospital;
            IsAttendedTo = false;
            IsActive =true;
            IsApprove = false;
            BookedTime = DateTime.Now;
        }
        public string Discription { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Hospital Hospital { get; set; }
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
