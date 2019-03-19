using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protery.Models
{
    public class Extensions
    {
        private int extensionsID;
        private string porch;
        private bool garden;
        private string conservatory;
        private int squareAcres;

        public int ExtensionsID { get => extensionsID; set => extensionsID = value; }
        public string Porch { get => porch; set => porch = value; }
        public bool Garden { get => garden; set => garden = value; }
        public string Conservatory { get => conservatory; set => conservatory = value; }
        public int SquareAcres { get => squareAcres; set => squareAcres = value; }
    }
}