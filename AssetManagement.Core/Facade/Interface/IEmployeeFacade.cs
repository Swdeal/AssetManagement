using AssetManagement.Core.Models;
using AssetManagement.Core.Models.BusinessObject.Emploee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.Facade.Interface
{
    public interface IEmployeeFacade
    {
        /// <summary>
        /// 取得員工資料
        /// </summary>
        /// <param name="employeeGuid">員工GUID</param>
        /// <returns>查詢結果</returns>
        QueryResult<EmployeeBO> GetEmployee(string employeeGuid);

        /// <summary>
        /// 取得員工資料清單
        /// </summary>
        /// <param name="queryBO">查詢條件</param>
        /// <returns>查詢結果</returns>
        QueryResult<List<EmployeeBO>> GetEmployeeList(EmployeeQueryBO queryBO);

        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="employeeBO">員工資料</param>
        /// <returns>執行結果</returns>
        ExecuteResult Add(EmployeeBO employeeBO);

        /// <summary>
        /// 編輯員工
        /// </summary>
        /// <param name="employeeBO">員工資料</param>
        /// <returns>執行結果</returns>
        ExecuteResult Edit(EmployeeBO employeeBO);

        /// <summary>
        /// 刪除員工
        /// </summary>
        /// <param name="employeeBO">員工GUID</param>
        /// <returns>執行結果</returns>
        ExecuteResult Delete(string employeeGuid);
    }
}
