using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Hand_in1_grp7.Models
{
    public class ComponentInformation
    {
        [Key]
        public int InfoId { get; set; }
        public string ComponentName { get; set; }
        public string ComponentInfo { get; set; }
        public string DataSheet { get; set; }
        public string Image { get; set; }
        public string ManufacturerLink { get; set; }
        public int Category { get; set; }
        [ForeignKey("Category")]
        public Category CategoryInfo { get; set; }




    }
}