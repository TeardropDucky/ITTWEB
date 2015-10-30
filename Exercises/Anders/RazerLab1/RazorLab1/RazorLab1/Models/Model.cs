using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorLab1.Models
{
    public class Model
    {
        public int ModelID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}