using AssetManagement.Core.Facade.Interface;
using AssetManagement.Core.Models;
using AssetManagement.Core.Models.BusinessObject.Emploee;
using AssetManagement.Core.Service.Interface;
using Lib.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.Facade.Implement.Employee
{
    public sealed partial class EmployeeFacade : BaseFacade, IEmployeeFacade
    {
        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="employeeBO">員工資料</param>
        /// <returns>執行結果</returns>
        public ExecuteResult Add(EmployeeBO employeeBO)
        {
            bool isSuccess = _employeeService.Add(employeeBO);

            return new ExecuteResult
            {
                IsSuccess = isSuccess,
                Message = isSuccess ? ResponseMessage.ADD_SUCCESS : ResponseMessage.ADD_FAIL
            };
        }
    }
}
