using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIckupPoint.BO.ResponseModels.PickuPointsModels
{
    public class Attributes
    {
        public string name { get; set; }
        public string pickupPointCode { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public Coordinates coordinates { get; set; }
        public object locationMapImage { get; set; }
        public Photo photo { get; set; }
        public string openingHours { get; set; }
    }
}
