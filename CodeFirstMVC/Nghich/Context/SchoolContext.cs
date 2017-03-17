using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Nghich.Entities;

namespace Nghich.Context
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base("SchoolContext")
        {

        }

        public DbSet<Student> Students { set; get; }
    }
}