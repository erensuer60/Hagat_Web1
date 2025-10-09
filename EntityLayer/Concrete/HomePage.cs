using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class HomePage
	{
		[Key]
		public int HomePageID { get; set; }
		public string Logo { get; set; }
		public string Description { get; set; }
		public string Name { get; set; }
	}
}
