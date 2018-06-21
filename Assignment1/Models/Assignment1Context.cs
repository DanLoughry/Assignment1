using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Assignment1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Assignment1Context() : base("name=Assignment1Context")
        {
        }

		public System.Data.Entity.DbSet<Assignment1.Models.Owner> Owners { get; set; }

		public System.Data.Entity.DbSet<Assignment1.Models.Vehicle> Vehicles { get; set; }
	}
}
