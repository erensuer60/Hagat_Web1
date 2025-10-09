using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class ProductDetail
	{
		[Key]
		public int ProductDetailID { get; set; }
		public string Description { get; set; }
		public string Header { get; set; }
		public string ScopeOfWork { get; set; }
		public string Industry { get; set; }
		public string Raised { get; set; }
		public string Website { get; set; }
		public string UnderDescription { get; set; }
		public string ImageUrl1 { get; set; }
		public string ImageUrl2 { get; set; }
		public string ImageUrl3 { get; set; }
	}
}
