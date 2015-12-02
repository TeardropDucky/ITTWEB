using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace HandIn2_FoodProcessor.Models
{
    public class UserInfo
    {
        [Key]
        public string UserId { get; set; }
        public string Name { get; set; }
    }
}