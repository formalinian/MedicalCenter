namespace MedicalCenter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        [Key]
        public int Appointment_code { get; set; }

        public int Employee_number { get; set; }

        public int Patient_number { get; set; }

        public int Service_code { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public int Office { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Service Service { get; set; }
    }
}
