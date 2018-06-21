using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
	public class Vehicle {
		public int Id { get; set; }
		public int VIN { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public int OwnerId { get; set; }

		public virtual Owner owner { get; set; }

		public Vehicle(){}
	}
}