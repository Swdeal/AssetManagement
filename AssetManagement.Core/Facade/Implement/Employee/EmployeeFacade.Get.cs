using AssetManagement.Core.Facade.Interface;
using AssetManagement.Core.Models;
using AssetManagement.Core.Models.BusinessObject.Emploee;
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

        /// <summary>
        /// 取得員工資料
        /// </summary>
        /// <param name="employeeGuid">員工GUID</param>
        /// <returns>查詢結果</returns>
        public QueryResult<EmployeeBO> GetEmployee(string employeeGuid)
        {
            QueryResult<EmployeeBO> result = new QueryResult<EmployeeBO>();
            EmployeeBO employeeBO = _employeeService.GetEmployee(employeeGuid);

            if (employeeBO != null)
            {
                result.Data = employeeBO;
                result.IsSuccess = true;
            }

            return result;

        }

        /// <summary>
        /// 取得員工資料清單
        /// </summary>
        /// <param name="queryBO">查詢條件</param>
        /// <returns>查詢結果</returns>
        public QueryResult<List<EmployeeBO>> GetEmployeeList(EmployeeQueryBO queryBO)
        {
            QueryResult<List<EmployeeBO>> result = new QueryResult<List<EmployeeBO>>();
            List<EmployeeBO> employeeBOList = _employeeService.GetEmployeeList(queryBO);
            result.Data = employeeBOList;
            result.IsSuccess = true;
            return result;
        }
    }
}
