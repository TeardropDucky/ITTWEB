using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hand_in1_grp7.Models
{
    public class ComponentOverview
    {
        public List<ComponentInformation> Components { get; set; }
        public List<Category> Categories { get; set; }

        public int SelectedCategory { get; set; }
    }
}