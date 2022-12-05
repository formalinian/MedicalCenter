namespace MedicalCenter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sickness_record
    {
        [Key]
        public int Record_number { get; set; }

        public int Employee_number { get; set; }

        public int Patient_number { get; set; }

        [Required]
        [StringLength(30)]
        public string Sickness_type { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Diagnosis { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
