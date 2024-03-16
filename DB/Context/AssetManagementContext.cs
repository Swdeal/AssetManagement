using DB.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Context
{
    public class AssetManagementContext : DbContext
    {
        public AssetManagementContext()
        {

        }
        public AssetManagementContext(DbContextOptions<AssetManagementContext> options) : base(options)
        {

        }


        public virtual DbSet<EmployeeMain> EmployeeMain { get; set; }
    }
}
