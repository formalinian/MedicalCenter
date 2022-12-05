namespace MedicalCenter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Appointment = new HashSet<Appointment>();
            Sickness_record = new HashSet<Sickness_record>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Number { get; set; }

        [Required]
        [StringLength(11)]
        public string Passport { get; set; }

        [Required]
        [StringLength(20)]
        public string Surname { get; set; }

        [Required]
        [StringLength(20)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(20)]
        public string Patronymic { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(7)]
        public string Gender { get; set; }

        [StringLength(35)]
        public string Employee_address { get; set; }

        [Required]
        [StringLength(10)]
        public string Employee_status { get; set; }

        public long Diploma { get; set; }

        public long Labor { get; set; }

        [Required]
        [StringLength(20)]
        public string Pass { get; set; }

        public int Position_code { get; set; }

        public int? Speciality_code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sickness_record> Sickness_record { get; set; }

        public virtual Position Position { get; set; }

        public virtual Speciality Speciality { get; set; }
    }
}
