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

        public List<SAPViewModel> GetSAPDetails()
        {
            var response = new List<SAPViewModel>();

            var query = assignmentDb.Saps.Where(u => u.Status == true);

            var SAPList = query.ToList();

            foreach (var item in SAPList)
            {
                var vm = new SAPViewModel
                {
                    BP = item.BP,
                    ARCode = item.ARCode,
                    ARName = item.ARName,
                    SAPCode = item.SAPCode,
                    Status = item.Status,
                    ARCategory = item.ARCategory,
                    Spoc1 = item.Spoc1,
                    Spoc2 = item.Spoc2,
                    NDReference = item.NDReference,
                    SiteId = item.SiteId,
                    Description = item.Description,
                    Project = item.Project,
                    Provision = item.Provision,
                    OnAirDate1 = item.OnAirDate1,
                    LastUpdate = item.LastUpdate,
                    ProjectStatus = item.ProjectStatus,
                    TargetWeek = item.TargetWeek,
                    RiskLevel = item.RiskLevel,
                    OnAirDate2 = item.OnAirDate2,
                    Remarks = item.Remarks,
                    UpdatedBy = item.UpdatedBy,
                    UpdatedDate = item.UpdatedDate,
                    YearMonth = item.YearMonth,
                    Commitment = item.Commitment,
                    Actual = item.Actual,
                };

                response.Add(vm);
            }

            return response;
        }
    }
}
