using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace HandIn2_FoodProcessor.Models
{
    public class Consumables
    {
        [Key]
        public int ConsumableId { get; set; }
        public string ConsumableName { get; set; }
        public int ProteinPer100Gram { get; set; }
    }
}