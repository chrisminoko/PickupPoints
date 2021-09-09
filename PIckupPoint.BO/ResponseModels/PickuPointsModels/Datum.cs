using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIckupPoint.BO.ResponseModels.PickuPointsModels
{
    public class Datum
    {
        public Attributes attributes { get; set; }
        public List<object> meta { get; set; }
        public string type { get; set; }
        public int version { get; set; }
    }
}
