﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace carsAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class rentcarsEntities : DbContext
    {
        public rentcarsEntities()
            : base("name=rentcarsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<branch> branches { get; set; }
        public virtual DbSet<carRentalDetail> carRentalDetails { get; set; }
        public virtual DbSet<carType> carTypes { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<car> cars { get; set; }
    }
}
