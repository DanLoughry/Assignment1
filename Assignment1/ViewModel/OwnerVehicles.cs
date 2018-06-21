using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.ViewModel
{
	public class OwnerVehicles	{

		public Owner Owner { get; set; }
		public IEnumerable<Vehicle> Vehicles { get; set; }

		public OwnerVehicles() { }
	}
}