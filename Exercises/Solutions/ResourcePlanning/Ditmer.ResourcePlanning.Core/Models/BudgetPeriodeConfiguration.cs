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
    // BudgetPeriode
    public class BudgetPeriodeConfiguration : EntityTypeConfiguration<BudgetPeriode>
    {
        public BudgetPeriodeConfiguration()
            : this("dbo")
        {
        }
 
        public BudgetPeriodeConfiguration(string schema)
        {
            ToTable(schema + ".BudgetPeriode");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar");
            Property(x => x.PeriodeStart).HasColumnName("PeriodeStart").IsOptional().HasColumnType("datetime");
            Property(x => x.PeriodeEnd).HasColumnName("PeriodeEnd").IsOptional().HasColumnType("datetime");
        }
    }

}
// </auto-generated>
