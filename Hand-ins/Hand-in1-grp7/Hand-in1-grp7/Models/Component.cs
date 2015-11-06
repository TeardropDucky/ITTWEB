using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hand_in1_grp7.Models
{
    public class Component
    {
        private int id {get; set;}
        private int number { get; set; }
        private string serieNr { get; set; }
        private string name { get; set; }
        private string info { get; set;}
        private string datasheet { get; set; }
        private string image { get; set; } //change image to image and not a link
        private string manufacturer { get; set; }
        private List<string> adminComments { get; set; }
        private List<string> userComment { get; set; }

        private Component(int ID, int Number, string Name, string SerieNumber = "0",string Information = "Not provided", string DatasheetLink = "http://i.imgur.com/CaHHiaY.jpg", string Image = "FeelsBadMan.jpg", string ManufacturerLink = "http://i.imgur.com/CaHHiaY.jpg", List<string> AdminComments = null, List<string> UserComment = null){
            id = ID;
            number = Number;
            name = Name;
            serieNr = SerieNumber;
            info = Information;
            datasheet = DatasheetLink;
            image = Image;
            manufacturer = ManufacturerLink;
            adminComments = AdminComments;
            userComment = UserComment;
        }
    }
}