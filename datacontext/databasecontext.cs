using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.datacontext
{
    public class databasecontext:DbContext
    {
        public databasecontext():base("Data Source=.\\local2;Initial Catalog=addressTest;Integrated Security=True")
        {
            
        }
        public DbSet<Models.album> Albums { get; set; }
    }
}