using AssetManagement.Core.Facade.Interface;
using AssetManagement.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.Facade.Implement.Employee
{
    public sealed partial class EmployeeFacade : BaseFacade, IEmployeeFacade
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeFacade (IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
    }
}
