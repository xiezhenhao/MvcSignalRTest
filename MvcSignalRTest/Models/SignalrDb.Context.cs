﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcSignalRTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SignalrDbEntities : DbContext
    {
        public SignalrDbEntities()
            : base("name=SignalrDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Canvas> Canvas { get; set; }
        public DbSet<ChatContents> ChatContents { get; set; }
        public DbSet<ChatGroups> ChatGroups { get; set; }
        public DbSet<ChatUsers> ChatUsers { get; set; }
        public DbSet<User> User { get; set; }
    }
}
