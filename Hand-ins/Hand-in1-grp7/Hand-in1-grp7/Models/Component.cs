using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hand_in1_grp7.Models
{
    public class Component
    {
        public int ID {get; set;}
        public int Number { get; set; }
        public string SerieNr { get; set; }
        public string Name { get; set; }
        public string Info { get; set;}
        public string Datasheet { get; set; }
        public string Image { get; set; } //change image to image and not a link
        public string Manufacturer { get; set; }
        public List<string> AdminComments { get; set; }
        public List<string> UserComment { get; set; }

        public Component(int ComponentID, int ComponentNumber, string ComponentName, string SerieNumber = "0",string Information = "Not provided", string DatasheetLink = "http://i.imgur.com/CaHHiaY.jpg", string ComponentImage = "FeelsBadMan.jpg", string ManufacturerLink = "http://i.imgur.com/CaHHiaY.jpg", List<string> Admin_Comments = null, List<string> User_Comment = null){
            ID = ComponentID;
            Number = ComponentNumber;
            Name = ComponentName;
            SerieNr = SerieNumber;
            Info = Information;
            Datasheet = DatasheetLink;
            Image = ComponentImage;
            Manufacturer = ManufacturerLink;
            AdminComments = Admin_Comments;
            UserComment = User_Comment;
        }
    }
}