using AssetManagement.Core.DAO.Interface;
using AssetManagement.Core.Models.DataObject.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.CoreTests.Fake
{
    public class FakeEmployeeDAO : IEmployeeDAO
    {
        public bool Add(EmployeeDO employeeDO)
        {
            if (string.IsNullOrEmpty(employeeDO.EmployeeID) ||
                string.IsNullOrEmpty(employeeDO.EmployeePWD) ||
                string.IsNullOrEmpty(employeeDO.EmployeeName) ||
                string.IsNullOrEmpty(employeeDO.EmployeeEmail))
            {
                return false;
            }
            
            return true;
        }

        public bool Delete(EmployeeDO employeeDO)
        {
            if (string.IsNullOrEmpty(employeeDO.EmployeeUID) == false)
            {
                return true;
            }

            return false;
        }

        public bool Edit(EmployeeDO employeeDO)
        {
            throw new NotImplementedException();
        }

        public EmployeeDO GetEmployee(string employeeGuid)
        {
            return new EmployeeDO
            {
                EmployeeUID = employeeGuid,
            };
        }

        public List<EmployeeDO> GetEmployeeList(EmployeeQueryDO queryDO)
        {
            throw new NotImplementedException();
        }
    }
}
