using AssetManagement.Core.DAO.Interface;
using AssetManagement.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.Service.Implement.Employee
{
    public sealed partial class EmployeeService : BaseService, IEmployeeService
    {
        private readonly IEmployeeDAO _employeeDAO;

        public EmployeeService (IEmployeeDAO employeeDAO)
        {
            _employeeDAO = employeeDAO;
        }
    }
}
