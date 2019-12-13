namespace PrintPDF_Rotativa.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeEntity : DbContext
    {
        public EmployeeEntity()
            : base("name=EmployeeEntity")
        {
        }

        public virtual DbSet<T_Employee> T_Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_Employee>()
                .Property(e => e.empName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Employee>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Employee>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<T_Employee>()
                .Property(e => e.HRA)
                .HasPrecision(12, 1);

            modelBuilder.Entity<T_Employee>()
                .Property(e => e.TA)
                .HasPrecision(13, 2);

            modelBuilder.Entity<T_Employee>()
                .Property(e => e.DA)
                .HasPrecision(13, 2);

            modelBuilder.Entity<T_Employee>()
                .Property(e => e.GrossSalary)
                .HasPrecision(16, 2);

            modelBuilder.Entity<T_Employee>()
                .Property(e => e.TDS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<T_Employee>()
                .Property(e => e.NetSalary)
                .HasPrecision(20, 4);
        }
    }
}
