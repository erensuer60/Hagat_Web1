using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Capabilitie
	{
		[Key]
		public int CapabilitieID { get; set; }
		public string ImageUrl { get; set; }
		public string CapabilitieName { get; set; }
		public string Description { get; set; }
	}
}
