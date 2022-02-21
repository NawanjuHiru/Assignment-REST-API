using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_REST_API.Model.REST
{
    public class Amount
    {
        public long Id { get; set; }
        public DateTime YearMonth { get; set; }
        public bool Commitment { get; set; }
        public int Actual { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SAP SAPCode { get; set; }

        public virtual ICollection<SAP> SAPs { get; set; }
    }
}
