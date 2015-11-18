using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Hand_in1_grp7.Models
{
    public class UserInformation
    {
        [Key]
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string CellNr { get; set; }

    }
}