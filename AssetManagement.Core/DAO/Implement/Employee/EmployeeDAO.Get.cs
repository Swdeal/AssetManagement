using AssetManagement.Core.DAO.Interface;
using AssetManagement.Core.Models.DataObject.Employee;
using Microsoft.EntityFrameworkCore;
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
        /// 取得員工資料
        /// </summary>
        /// <param name="employeeGuid">員工GUID</param>
        /// <returns>員工資料</returns>
        public EmployeeDO GetEmployee(string employeeGuid)
        {
            var query = GetEmployeeMainQuery();
            return query.Where(x => x.EmployeeUID == employeeGuid).First();
        }

        /// <summary>
        /// 取得員工資料清單
        /// </summary>
        /// <param name="queryDO">查詢條件</param>
        /// <returns>員工資料清單</returns>
        public List<EmployeeDO> GetEmployeeList(EmployeeQueryDO queryDO)
        {
            var query = GetEmployeeMainQuery();

            if (string.IsNullOrEmpty(queryDO.EmployeeId) == false)
            {
                query = query.Where(x => x.EmployeeID!.Contains(queryDO.EmployeeId));
            }

            if (string.IsNullOrEmpty(queryDO.EmployeeName) == false)
            {
                query = query.Where(x => x.EmployeeName!.Contains(queryDO.EmployeeName));
            }

            return query.ToList();
        }


        private IQueryable<EmployeeDO> GetEmployeeMainQuery()
        {
            return (from e in DbContext.EmployeeMain
                    select new EmployeeDO
                    {
                        EmployeeUID = e.EmployeeUID,
                        EmployeeID = e.EmployeeID,
                        EmployeePWD = e.EmployeePWD,
                        EmployeeName = e.EmployeeName,
                        EmployeeEmail = e.EmployeeEmail,
                        CreateUser = e.CreateUser,
                        CreateTime = e.CreateTime,
                        ModifyUser = e.ModifyUser,
                        ModifyTime = e.ModifyTime,
                    }).AsNoTracking();
        }
    }
}
