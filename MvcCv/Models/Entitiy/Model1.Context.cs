﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities : DbContext
    {
        public DbCvEntities()
            : base("name=DbCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        internal object TblYeteneklerim1Set()
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblDeneyimlerim> TblDeneyimlerim { get; set; }
        public virtual DbSet<TblEgitimlerim> TblEgitimlerim { get; set; }
        public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }
        public virtual DbSet<TblHobilerim> TblHobilerim { get; set; }
        public virtual DbSet<TblIletisim> TblIletisim { get; set; }
        public virtual DbSet<TblSertifikalar> TblSertifikalar { get; set; }
        public virtual DbSet<TblYeteneklerim1> TblYeteneklerim1Set { get; set; }
        public object TblYeteneklerim1 { get; internal set; }
    }
}