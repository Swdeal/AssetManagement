﻿using AssetManagement.Core.DAO.Interface;
using AssetManagement.Core.Models.DataObject.Employee;
using DB.Entity;
using Lib.Util;
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
        /// 編輯員工資料
        /// </summary>
        /// <param name="employeeDO">員工資料</param>
        /// <returns>編輯結果</returns>
        public bool Edit(EmployeeDO employeeDO)
        {
            EmployeeMain employeeMain = ConvertUtil.ToObject<EmployeeMain>(employeeDO);
            DbContext.Entry(employeeMain).State = EntityState.Modified;
            return DbContext.SaveChanges() == 1;
        }
    }
}
