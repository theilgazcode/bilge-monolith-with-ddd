using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
            :base("name=ProjectEntities")
        {

        }
    }
}
