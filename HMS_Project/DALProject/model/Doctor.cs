﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.model
{
    public class Doctor : ModelBase
    {
		// Relation With AppUser
		public string? UserId { get; set; }
		public virtual AppUser AppUser { get; set; }

		#region One2Many With DoctorSpecializationLookup
		public int? SpecializationId { get; set; }
        public virtual DoctorSpecializationLookup DoctorSpecialization { get; set; }=null!;
        #endregion

        #region One2Many With Clinic
        public int? ClinicId { get; set; }
        public virtual Clinic Clinic { get; set; } = null!;
        #endregion

        #region One2Many with Prescription
        public virtual ICollection<Prescription> Prescriptions { get; set; } = new HashSet<Prescription>();
        #endregion

        #region One2Many With DoctorScheduleLookup
        public virtual ICollection<DoctorScheduleLookup> DoctorScheduleLookups { get; set; } = new HashSet<DoctorScheduleLookup>();
        #endregion

        #region One2Many With Apointment
        public virtual ICollection <Apointment> Apointments { get; set; }= new HashSet<Apointment>();
        #endregion
    }
}
