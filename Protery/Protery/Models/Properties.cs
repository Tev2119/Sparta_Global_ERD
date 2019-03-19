using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protery.Models
{
    public class Properties
    {
        private string country;
        private string location;
        private int price;
        private string Availability;
        
        private string typeKitchenSpace;


        public string Country { get => country; set => country = value; }
        public string Location { get => location; set => location = value; }
        public int Price { get => price; set => price = value; }
        public string Availability1 { get => Availability; set => Availability = value; }
       
       
        public string TypeKitchenSpace { get => typeKitchenSpace; set => typeKitchenSpace = value; }

    }
}