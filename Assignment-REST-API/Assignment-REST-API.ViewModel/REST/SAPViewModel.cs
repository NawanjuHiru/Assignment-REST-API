using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_REST_API.ViewModel.REST
{
    public class SAPViewModel
    {
        public int BP { get; set; }
        public int ARCode { get; set; }
        public int ARName { get; set; }
        public int SAPCode { get; set; }
        public bool Status { get; set; }
        public bool ARCategory { get; set; }
        public string Spoc1 { get; set; }
        public string Spoc2 { get; set; }
        public string NDReference { get; set; }
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
        public DateTime YearMonth { get; set; }
        public bool Commitment { get; set; }
        public int Actual { get; set; }
        //public string UpdatedBy { get; set; }
        //public DateTime LastUpdate { get; set; }
    }
}
