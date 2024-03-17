using AssetManagement.Core.Facade.Interface;
using AssetManagement.Core.Models;
using AssetManagement.Core.Models.BusinessObject.Emploee;
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
        /// 編輯員工
        /// </summary>
        /// <param name="employeeBO">員工資料</param>
        /// <returns>執行結果</returns>
        public ExecuteResult Edit(EmployeeBO employeeBO)
        {
            ExecuteResult result = new ExecuteResult();
            if (result.IsSuccess = _employeeService.Edit(employeeBO))
            {
                result.Message = ResponseMessage.EDIT_SUCCESS;
            }
            else
            {
                result.Message = ResponseMessage.EDIT_FAIL;
            }

            return result;
        }
    }
}
