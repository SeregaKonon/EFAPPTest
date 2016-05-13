using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFApp.DAL
{
    class SomeTableContext:DbContext
    {
        public SomeTableContext()
            :base("DBConnection")
        {

        }
        public DbSet<SomeTable> SomeTables { get; set; }
    }
}
