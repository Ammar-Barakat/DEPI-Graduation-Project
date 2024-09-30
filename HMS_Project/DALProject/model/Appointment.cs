﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.model
{
    public class Appointment
    {
        public  int AppointmentId { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentTime { get; set; }
        /// <summary>
        ///  AppointmentStatus take his value from enum AppointmentStatus
        /// </summary>
        public string AppointmentStatus { get; set; } = null!;
        public virtual string Examination { get; set; } = null!;


        #region One2Many With Receptionist
        public long? ReceptionistId { get; set; }
        public virtual Receptionist Receptionist { get; set; } = null!;
        #endregion

        #region One2Many With Clinic
        public int? ClinicId { get; set; }
        public  virtual Clinic Clinic { get; set; } = null!;
        #endregion

        #region One2Many With Patient
        public long PatientId { get; set; }
        public virtual Patient Patient { get; set; } = null!; 
        #endregion

        #region One2Many With Doctor
        public virtual long DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; } = null!;
        #endregion

        #region One2One With Invoice
        public virtual Invoice Invoice { get; set; }= null!;
        #endregion

        #region One2One With Prescription
        public virtual Prescription Prescription { get; set; } = null!;
        #endregion
    }
}