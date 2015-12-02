using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandIn2_FoodProcessor.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace HandIn2_FoodProcessor.Models
{
    public class Posts
    {
        [Key]
        public int PostId { get; set; }
        public Consumables Consumable {get; set;}
        public int GramProtein { get; set; }
        public UserInfo User { get; set; }
        public DateTime PostDate { get; set; }
    }
}