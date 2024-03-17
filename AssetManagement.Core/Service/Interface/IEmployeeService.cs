using AssetManagement.Core.Models.BusinessObject.Emploee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.Service.Interface
{
    public interface IEmployeeService
    {
        /// <summary>
        /// 取得員工資料
        /// </summary>
        /// <param name="employeeGuid">員工GUID</param>
        /// <returns>員工資料</returns>
        EmployeeBO GetEmployee(string employeeGuid);

        /// <summary>
        /// 取得員工資料清單
        /// </summary>
        /// <param name="queryBO">查詢條件</param>
        /// <returns>員工資料清單</returns>
        List<EmployeeBO> GetEmployeeList(EmployeeQueryBO queryBO);

        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="employeeBO">員工資料</param>
        /// <returns>新增結果</returns>
        bool Add(EmployeeBO employeeBO);

        /// <summary>
        /// 編輯員工
        /// </summary>
        /// <param name="employeeBO">員工資料</param>
        /// <returns>編輯結果</returns>
        bool Edit(EmployeeBO employeeBO);

        /// <summary>
        /// 刪除員工
        /// </summary>
        /// <param name="employeeGuid">員工GUID</param>
        /// <returns>刪除結果</returns>
        bool Delete(string employeeGuid);
    }
}
