﻿using AssetManagement.Core.Facade.Implement.Employee;
using AssetManagement.Core.Facade.Interface;
using AssetManagement.Core.Models;
using AssetManagement.Core.Models.BusinessObject.Emploee;
using AssetManagement.Models.Employee;
using Lib.Constant;
using Lib.Util;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeFacade _employeeFacade;

        public EmployeeController(IEmployeeFacade employeeFacade)
        {
            _employeeFacade = employeeFacade;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 取得員工清單
        /// </summary>
        /// <param name="queryModel">查詢條件</param>
        /// <returns>JSON</returns>
        [HttpGet]
        public JsonResult Get(EmployeeQueryModel queryModel)
        {
            EmployeeQueryBO queryBO = ConvertUtil.ToObject<EmployeeQueryBO>(queryModel);
            QueryResult<List<EmployeeBO>> queryResult = _employeeFacade.GetEmployeeList(queryBO);
            return Json(new { queryResult });
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(EmployeeViewModel model)
        {
            EmployeeBO employeeBO = ConvertUtil.ToObject<EmployeeBO>(model);

            employeeBO.EmployeeUID = Guid.NewGuid().ToString();
            employeeBO.CreateUser = Constant.DEFAULT_USER;
            employeeBO.CreateTime = DateTimeOffset.Now;
            employeeBO.ModifyUser = Constant.DEFAULT_USER;
            employeeBO.ModifyTime = DateTimeOffset.Now;

            ExecuteResult result = _employeeFacade.Add(employeeBO);

            if (result.IsSuccess)
            {
                ViewData["SuccessMessage"] = result.Message;
            }
            else
            {
                ViewData["FailMessage"] = result.Message;
            }

            return View(model);
        }
    }
}
