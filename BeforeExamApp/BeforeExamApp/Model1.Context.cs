﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeforeExamApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BeforeExamsEntities : DbContext
    {
        public BeforeExamsEntities()
            : base("name=BeforeExamsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Lessons> Lessons { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    
        public virtual ObjectResult<NotListesi_Result> NotListesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NotListesi_Result>("NotListesi");
        }
    }
}