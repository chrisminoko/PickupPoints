using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIckupPoint.BO.ResponseModels.PickuPointsModels
{
    public class Meta
    {
        public int total { get; set; }
        public int count { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int page { get; set; }
    }
}
