﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbEntityUrunEntities : DbContext
    {
        public DbEntityUrunEntities()
            : base("name=DbEntityUrunEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLKATEGORI> TBLKATEGORIs { get; set; }
        public virtual DbSet<TBLMUSTERI> TBLMUSTERIs { get; set; }
        public virtual DbSet<TBLSATI> TBLSATIS { get; set; }
        public virtual DbSet<TBLURUN> TBLURUNs { get; set; }
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
    
        public virtual ObjectResult<string> MARKAGETIR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("MARKAGETIR");
        }
    }
}
