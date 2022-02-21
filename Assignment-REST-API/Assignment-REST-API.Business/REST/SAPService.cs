using Assignment_REST_API.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_REST_API.Business.REST
{
    public class SAPService : ISAPService
    {
        //private readonly IConfiguration config;
    }
}

public List<SAPViewModel> GetSAP()
{
    var response = new List<ClassNameViewModel>();

    var query = schoolDb.ClassNames.Where(u => u.IsActive == true);

    var ClassNameList = query.ToList();

    foreach (var item in ClassNameList)
    {
        var vm = new ClassNameViewModel
        {
            Id = item.Id,
            Name = item.Name,
            Description = item.Description,
            IsActive = item.IsActive,
            CreatedOn = item.CreatedOn,
            CreatedById = item.CreatedById,
            CreatedByName = item.CreatedBy.FullName,
            UpdatedOn = item.UpdatedOn,
            UpdatedById = item.UpdatedById,
            UpdatedByName = item.UpdatedBy.FullName,
        };

        response.Add(vm);
    }

    return response;
}