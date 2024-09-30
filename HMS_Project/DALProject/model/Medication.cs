﻿using System;
using System.Collections.Generic;

namespace DALProject.model;

public class Medication
{
    public string MedicationCode { get; set; } = null!;

    public string MedName { get; set; } = null!;

    public int Strength { get; set; }

    #region One2Many With PrescriptionItemMedication
    public virtual ICollection<PrescriptionItemMedication> PrescriptionItemMedications { get; set; }= new HashSet<PrescriptionItemMedication>();
    #endregion

    #region Many2Many With ActiveSubstance
    public virtual ICollection<ActiveSubstance> ActiveSubstances { get; set; } = new HashSet<ActiveSubstance>();
    #endregion
}