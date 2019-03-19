using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protery.Models
{
    public class PropertyType
    {
        private int propTypeID;
        private string mansion;
        private string house;
        private string flat;
        private string bungalow;
        private string complexies;

        public int PropTypeID { get => propTypeID; set => propTypeID = value; }
        public string Mansion { get => mansion; set => mansion = value; }
        public string House { get => house; set => house = value; }
        public string Flat { get => flat; set => flat = value; }
        public string Bungalow { get => bungalow; set => bungalow = value; }
        public string Complexies { get => complexies; set => complexies = value; }
    }
}