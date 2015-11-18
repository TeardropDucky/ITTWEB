using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Hand_in1_grp7.Models
{
    public class LoanInformation
    {
        [Key]
        public int LoanId { get; set; }
        public int ComponentNr { get; set; }
        [ForeignKey("ComponentNr")]
        public Component ComponentData { get; set; } // Hvordan får man Componentnumber ind her
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string IsEmailSent { get; set; }
        public DateTime ReservationDate { get; set; }
        public string OwnerId { get; set; }
        public string ReservationId { get; set; }
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public UserInformation UserInfo { get; set; }

    }
}