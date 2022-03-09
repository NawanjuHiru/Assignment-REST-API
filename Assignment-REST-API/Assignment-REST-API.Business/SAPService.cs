using Assignment_REST_API.Business.Interface;
using Assignment_REST_API.Data.Data;
using Assignment_REST_API.ViewModel.REST;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_REST_API.Business
{
    public class SAPService : ISAPService
    {
        private readonly ApplicationDbContext assignmentDb;
        private readonly IConfiguration config;

        public SAPService(ApplicationDbContext assignmentDb, IConfiguration config)
        {
            this.assignmentDb = assignmentDb;
            this.config = config;
        }

        public SAPViewModel GetDataBySapCode(int sapCode)
        {

            var query = assignmentDb.Saps.Where(x => x.SAPCode == sapCode).FirstOrDefault();
            
            var vm = new SAPViewModel
            {
                BP = query.BP,
                ARCode = query.ARCode,
                ARName = query.ARName,
                SAPCode = query.SAPCode,
                Status = query.Status,
                ARCategory = query.ARCategory,
                Spoc1 = query.Spoc1,
                Spoc2 = query.Spoc2,
                NDReference = query.NDReference,
                SiteId = query.SiteId,
                Description = query.Description,
                Project = query.Project,
                Provision = query.Provision,
                OnAirDate1 = query.OnAirDate1,
                LastUpdate = DateTime.UtcNow,
                ProjectStatus = query.ProjectStatus,
                TargetWeek = query.TargetWeek,
                RiskLevel = query.RiskLevel,
                OnAirDate2 = query.OnAirDate2,
                Remarks = query.Remarks,
                UpdatedBy = query.UpdatedBy,
                UpdatedDate = DateTime.UtcNow,
                YearMonth = query.YearMonth,
                Commitment = query.Commitment,
                Actual = query.Actual,
            };

            return (vm);
        }

        public SAPCodesViewModel GetSapCodes()
        {
            var query = assignmentDb.Saps.Where(x => x.Status == true).FirstOrDefault();

            var vm = new SAPCodesViewModel
            {
                SAPCode = query.SAPCode,
            };

            return (vm);
        }
    }
}
