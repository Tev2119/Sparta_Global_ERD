using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protery.Models
{
    public class BuildType
    {
        private int buildTypeID;
        private string victorian;
        private string preVictorian;
        private string modern;
        private int age;

        public int BuildTypeID { get => buildTypeID; set => buildTypeID = value; }
        public string Victorian { get => victorian; set => victorian = value; }
        public string PreVictorian { get => preVictorian; set => preVictorian = value; }
        public string Modern { get => modern; set => modern = value; }
      
        public int Age { get => age; set => age = value; }

    }
}