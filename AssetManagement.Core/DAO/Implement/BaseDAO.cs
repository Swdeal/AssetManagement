using AssetManagement.Core.DAO.Interface;
using DB.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Core.DAO.Implement
{
    public class BaseDAO : IBaseDAO
    {
        public AssetManagementContext DbContext { get; set; }
    }
}
