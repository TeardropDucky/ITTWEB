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
    // Employee
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.16.0.0")]
    public class Employee
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public bool Teacher { get; set; } // Teacher
        public int MinutesPerDay { get; set; } // MinutesPerDay

        // Reverse navigation
        public virtual ICollection<BudgetHoursOnActivity> BudgetHoursOnActivities { get; set; } // BudgetHoursOnActivity.FK_BudgetHoursOnActivity_Employee
        
        public Employee()
        {
            Teacher = true;
            BudgetHoursOnActivities = new List<BudgetHoursOnActivity>();
        }
    }

}
// </auto-generated>