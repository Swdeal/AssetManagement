using AssetManagement.Core.DAO.Interface;
using AssetManagement.Core.Models.DataObject.Employee;
using DB.Entity;
using Lib.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.DAO.Implement.Employee
{
    public sealed partial class EmployeeDAO : BaseDAO, IEmployeeDAO
    {
        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="employeeDO">員工資料</param>
        /// <returns>新增結果</returns>
        public bool Add(EmployeeDO employeeDO)
        {
            EmployeeMain employeeMain = ConvertUtil.ToObject<EmployeeMain>(employeeDO);
            DbContext.EmployeeMain.Add(employeeMain);
            return DbContext.SaveChanges() == 1;
        }
    }
}
