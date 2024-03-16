using AssetManagement.Core.Models.DataObject.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.DAO.Interface
{
    public interface IEmployeeDAO
    {
        bool Add(EmployeeDO employeeDO);
    }
}
