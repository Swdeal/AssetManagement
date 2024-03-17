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
        /// <summary>
        /// 取得員工資料
        /// </summary>
        /// <param name="employeeGuid">員工GUID</param>
        /// <returns>員工資料</returns>
        EmployeeDO GetEmployee(string employeeGuid);

        /// <summary>
        /// 取得員工資料清單
        /// </summary>
        /// <param name="queryDO">查詢條件</param>
        /// <returns>員工資料清單</returns>
        List<EmployeeDO> GetEmployeeList(EmployeeQueryDO queryDO);

        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="employeeDO">員工資料</param>
        /// <returns>新增結果</returns>
        bool Add(EmployeeDO employeeDO);

        /// <summary>
        /// 編輯員工
        /// </summary>
        /// <param name="employeeDO">員工資料</param>
        /// <returns>編輯結果</returns>

        bool Edit(EmployeeDO employeeDO);

        /// <summary>
        /// 刪除員工
        /// </summary>
        /// <param name="employeeDO">員工資料</param>
        /// <returns>刪除結果</returns>

        bool Delete(EmployeeDO employeeDO);

    }
}
