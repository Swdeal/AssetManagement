using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssetManagement.Core.Service.Implement.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagement.Core.Service.Interface;
using AssetManagement.Core.Models.BusinessObject.Emploee;
using AssetManagement.Core.DAO.Interface;
using AssetManagement.CoreTests.Fake;
using System.ComponentModel;
using AssetManagement.Core.Models.DataObject.Employee;

namespace AssetManagement.Core.Service.Implement.Employee.Test
{
    [TestClass()]
    public class EmployeeServiceTests
    {
        private IEmployeeService _employeeService;
        private IEmployeeDAO _employeeDAO;

        [TestInitialize]
        public void Initialize()
        {
            _employeeDAO = new FakeEmployeeDAO();
            _employeeService = new EmployeeService(_employeeDAO);
        }

        [TestMethod()]
        [DisplayName("測試新增失敗")]
        public void AddTest_False()
        {
            // Arrange
            EmployeeBO employeeBO = new EmployeeBO();


            // Act
            var act = _employeeService.Add(employeeBO);


            // Assert
            Assert.IsFalse(act);
        }

        [TestMethod()]
        [DisplayName("測試新增成功")]
        public void AddTest_True()
        {
            // Arrange
            EmployeeBO employeeBO = new EmployeeBO
            {
                EmployeeID = "Test",
                EmployeePWD = "1234",
                EmployeeName = "Test",
                EmployeeEmail = "Test@gmail.com"
            };

            // Act
            var act = _employeeService.Add(employeeBO);


            // Assert
            Assert.IsTrue(act);
        }


        [TestMethod()]
        [DisplayName("測試刪除失敗")]
        public void DeleteTest_False()
        {
            // Arrange
            string employeeGuid = string.Empty;


            // Act
            var act = _employeeService.Delete(employeeGuid);


            // Assert
            Assert.IsFalse(act);
        }

        [TestMethod()]
        [DisplayName("測試刪除成功")]
        public void DeleteTest_True()
        {
            // Arrange
            string employeeGuid = Guid.NewGuid().ToString();

            // Act
            var act = _employeeService.Delete(employeeGuid);


            // Assert
            Assert.IsTrue(act);
        }
    }
}