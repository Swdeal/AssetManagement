using AssetManagement.Core.Models.DataObject.Employee;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeGuid"></param>
        /// <returns></returns>
        public bool Delete(string employeeGuid)
        {
            EmployeeDO employeeDO = _employeeDAO.GetEmployee(employeeGuid);
            return _employeeDAO.Delete(employeeDO);
        }
    }
}
