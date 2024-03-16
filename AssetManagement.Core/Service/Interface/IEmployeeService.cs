using AssetManagement.Core.Models.BusinessObject.Emploee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.Service.Interface
{
    public interface IEmployeeService
    {
        bool Add(EmployeeBO employeeBO);
    }
}
