using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIckupPoint.BO.ResponseModels.PickuPointsModels
{
    public class Root
    {
        public Meta meta { get; set; }
        public List<Datum> data { get; set; }
        public bool success { get; set; }
    }
}
