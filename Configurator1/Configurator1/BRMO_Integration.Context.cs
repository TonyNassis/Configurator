﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Configurator1 {
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;

	public partial class BRMO_Integration_Context : DbContext {
		public BRMO_Integration_Context()
			 : base("name=BRMO_Integration_Context") {
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			throw new UnintentionalCodeFirstException();
		}

		public virtual DbSet<product> products { get; set; }
		public virtual DbSet<Stockpile> Stockpiles { get; set; }
	}
}
