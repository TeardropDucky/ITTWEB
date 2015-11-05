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
    // Activity
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.16.0.0")]
    public class Activity
    {
        public int Id { get; set; } // Id (Primary key)
        public string Title { get; set; } // Title

        // Reverse navigation
        public virtual ICollection<BudgetHoursOnActivity> BudgetHoursOnActivities { get; set; } // BudgetHoursOnActivity.FK_BudgetHoursOnActivity_Activity
        
        public Activity()
        {
            BudgetHoursOnActivities = new List<BudgetHoursOnActivity>();
        }
    }

}
// </auto-generated>
