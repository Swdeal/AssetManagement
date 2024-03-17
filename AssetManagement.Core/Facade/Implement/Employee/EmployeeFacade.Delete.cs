using AssetManagement.Core.Facade.Interface;
using AssetManagement.Core.Models;
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
        /// 刪除員工
        /// </summary>
        /// <param name="employeeGuid">員工GUID</param>
        /// <returns>執行結果</returns>
        public ExecuteResult Delete(string employeeGuid)
        {
            ExecuteResult result = new ExecuteResult();
            if (result.IsSuccess = _employeeService.Delete(employeeGuid))
            {
                result.Message = ResponseMessage.DELETE_SUCCESS;
            }
            else
            {
                result.Message = ResponseMessage.DELETE_FAIL;
            }

            return result;
        }
    }
}
