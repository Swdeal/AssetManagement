using AssetManagement.Core.Models;
using AssetManagement.Core.Models.BusinessObject.Emploee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.Facade.Interface
{
    public interface IEmployeeFacade
    {
        ExecuteResult Add(EmployeeBO employeeBO);
    }
}
