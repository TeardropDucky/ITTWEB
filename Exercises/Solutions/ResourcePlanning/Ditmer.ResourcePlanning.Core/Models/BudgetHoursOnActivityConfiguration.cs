// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace Ditmer.ResourcePlanning.Core.Models
{
    // BudgetHoursOnActivity
    public class BudgetHoursOnActivityConfiguration : EntityTypeConfiguration<BudgetHoursOnActivity>
    {
        public BudgetHoursOnActivityConfiguration()
            : this("dbo")
        {
        }
 
        public BudgetHoursOnActivityConfiguration(string schema)
        {
            ToTable(schema + ".BudgetHoursOnActivity");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ActivityId).HasColumnName("ActivityId").IsRequired().HasColumnType("int");
            Property(x => x.EmployeeId).HasColumnName("EmployeeId").IsRequired().HasColumnType("int");
            Property(x => x.BudgetPeriodeId).HasColumnName("BudgetPeriodeId").IsRequired().HasColumnType("int");
            Property(x => x.Minutes).HasColumnName("Minutes").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Activity).WithMany(b => b.BudgetHoursOnActivities).HasForeignKey(c => c.ActivityId); // FK_BudgetHoursOnActivity_Activity
            HasRequired(a => a.BudgetPeriode).WithMany(b => b.BudgetHoursOnActivities).HasForeignKey(c => c.BudgetPeriodeId); // FK_BudgetHoursOnActivity_BudgetPeriode
            HasRequired(a => a.Employee).WithMany(b => b.BudgetHoursOnActivities).HasForeignKey(c => c.EmployeeId); // FK_BudgetHoursOnActivity_Employee
        }
    }

}
// </auto-generated>
