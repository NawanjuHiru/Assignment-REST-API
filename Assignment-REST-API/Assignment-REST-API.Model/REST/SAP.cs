using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_REST_API.Model.REST
{
    public class SAP
    {
        public int BP { get; set; }
        public int ARCode { get; set; }
        public string ARName { get; set; }
        public int SAPCode { get; set; }
        public bool Status { get; set; }
        public bool ARCategory { get; set; }
        public string Spoc1 { get; set; }
        public string Spoc2 { get; set; }
        public string NDReference { get; set; }
    }
}
