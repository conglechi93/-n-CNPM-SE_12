﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPM_SE_12.DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SE_12Entities : DbContext
    {
        public SE_12Entities()
            : base("name=SE_12Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Detail_Order> Detail_Order { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<QL_WDay> QL_WDay { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Type_Account> Type_Account { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
