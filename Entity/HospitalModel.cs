using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MedicalCenter
{
    public partial class HospitalModel : DbContext
    {
        public HospitalModel()
            : base("name=HospitalModel")
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Sickness_record> Sickness_record { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .Property(e => e.Time)
                .HasPrecision(0);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Passport)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Employee_status)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Appointment)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.Employee_number)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Sickness_record)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.Employee_number)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Passport)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Appointment)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.Patient_number)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Sickness_record)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.Patient_number)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.Job_title)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.Rights)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.Service_type)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Appointment)
                .WithRequired(e => e.Service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sickness_record>()
                .Property(e => e.Sickness_type)
                .IsUnicode(false);

            modelBuilder.Entity<Sickness_record>()
                .Property(e => e.Diagnosis)
                .IsUnicode(false);

            modelBuilder.Entity<Speciality>()
                .Property(e => e.Speciality_type)
                .IsUnicode(false);

            modelBuilder.Entity<Speciality>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Speciality>()
                .HasMany(e => e.Service)
                .WithRequired(e => e.Speciality)
                .WillCascadeOnDelete(false);
        }
    }
}
