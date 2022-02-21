using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_REST_API.Model.REST
{
    public class Site
    {
        public int SiteId { get; set; }
        public string Description { get; set; }
        public string Project { get; set; }
        public string Provision { get; set; }
        public DateTime OnAirDate1 { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool ProjectStatus { get; set; }
        public bool TargetWeek { get; set; }
        public bool RiskLevel { get; set; }
        public DateTime OnAirDate2 { get; set; }
        public string Remarks { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<SAP> SAPs { get; set; }

    }
}
