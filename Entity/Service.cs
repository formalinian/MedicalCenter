namespace MedicalCenter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            Appointment = new HashSet<Appointment>();
        }

        [Key]
        public int Service_code { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Speciality_code { get; set; }

        [Required]
        [StringLength(20)]
        public string Service_type { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointment { get; set; }

        public virtual Speciality Speciality { get; set; }
    }
}
