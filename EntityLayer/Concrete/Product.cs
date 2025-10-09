using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Product
	{
		[Key]
		public int ProductID { get; set; }
		public string Header { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public string ProductHeader { get; set; }
		public string ProductDescription { get; set; }
	}
}
