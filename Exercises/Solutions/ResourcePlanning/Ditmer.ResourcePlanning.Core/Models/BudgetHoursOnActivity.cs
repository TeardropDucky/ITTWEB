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
    public class BudgetHoursOnActivity
    {
        public int Id { get; set; } // Id (Primary key)
        public int ActivityId { get; set; } // ActivityId
        public int EmployeeId { get; set; } // EmployeeId
        public int BudgetPeriodeId { get; set; } // BudgetPeriodeId
        public int Minutes { get; set; } // Minutes

        // Foreign keys
        public virtual Activity Activity { get; set; } // FK_BudgetHoursOnActivity_Activity
        public virtual BudgetPeriode BudgetPeriode { get; set; } // FK_BudgetHoursOnActivity_BudgetPeriode
        public virtual Employee Employee { get; set; } // FK_BudgetHoursOnActivity_Employee
    }

}
// </auto-generated>