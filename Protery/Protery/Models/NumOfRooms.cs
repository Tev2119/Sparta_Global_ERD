using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protery.Models
{
    public class NumOfRooms
    {
        private int numBedrooms;
        private int numBathrooms;
        private int numfloors;

        public int NumBedrooms { get => numBedrooms; set => numBedrooms = value; }
        public int NumBathrooms { get => numBathrooms; set => numBathrooms = value; }
        public int Numfloors { get => numfloors; set => numfloors = value; }
    }
}