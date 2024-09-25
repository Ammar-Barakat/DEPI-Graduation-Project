﻿using System;
using System.Collections.Generic;

namespace HMS_Project.model;

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

    #region One2Many With MedicatoinSideEffects mult value attribut 
    public virtual ICollection<MedicatoinSideEffect> MedicatoinSideEffects { get; set; } = new HashSet<MedicatoinSideEffect>(); 
    #endregion
}
