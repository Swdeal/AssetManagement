using AssetManagement.Core.DAO.Interface;
using AssetManagement.Core.Models.BusinessObject.Emploee;
using AssetManagement.Core.Models.DataObject.Employee;
using AssetManagement.Core.Service.Interface;
using Lib.Util;
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

        /// <summary>
        /// 取得員工資料
        /// </summary>
        /// <param name="employeeGuid">員工GUID</param>
        /// <returns>員工資料</returns>
        public EmployeeBO GetEmployee(string employeeGuid)
        {
            EmployeeDO employeeDO = _employeeDAO.GetEmployee(employeeGuid);

            return ConvertUtil.ToObject<EmployeeBO>(employeeDO);
        }

        /// <summary>
        /// 取得員工資料清單
        /// </summary>
        /// <param name="queryBO">查詢條件</param>
        /// <returns>員工資料清單</returns>
        public List<EmployeeBO> GetEmployeeList(EmployeeQueryBO queryBO)
        {
            EmployeeQueryDO queryDO = ConvertUtil.ToObject<EmployeeQueryDO>(queryBO);
            List<EmployeeDO> employeeDOList = _employeeDAO.GetEmployeeList(queryDO);
            List<EmployeeBO> employeeBOList = employeeDOList.ConvertAll(x =>
            {
                return ConvertUtil.ToObject<EmployeeBO>(x);
            });

            return employeeBOList;
        }
    }
}
