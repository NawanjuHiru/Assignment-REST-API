using Assignment_REST_API.ViewModel.REST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_REST_API.Business.Interface
{
    public interface ISAPService
    {
        SAPViewModel GetDataBySapCode(int sapCode);
    }
}
