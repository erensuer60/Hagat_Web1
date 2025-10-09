using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				"server=DESKTOP-JALUFL9\\SQLEXPRESS;database=HagatWebDB;integrated security=true;Encrypt=False;TrustServerCertificate=True");
		}

		public DbSet<Capabilitie> Capabilities { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<HomePage> HomePages { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductDetail> ProductDetails { get; set; }
		public DbSet<WhatWeDo> WhatWeDos { get; set; }
	}
}
