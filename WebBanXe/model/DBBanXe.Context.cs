﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanXe.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBBanXeEntities2 : DbContext
    {
        public DBBanXeEntities2()
            : base("name=DBBanXeEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BLOG> BLOG { get; set; }
        public virtual DbSet<BRAND> BRAND { get; set; }
        public virtual DbSet<CATEGORY_BLOG> CATEGORY_BLOG { get; set; }
        public virtual DbSet<CLASS> CLASS { get; set; }
        public virtual DbSet<CONTACT> CONTACT { get; set; }
        public virtual DbSet<DISCOUNT> DISCOUNT { get; set; }
        public virtual DbSet<IMAGE_CONTENT> IMAGE_CONTENT { get; set; }
        public virtual DbSet<IMG_BLOG> IMG_BLOG { get; set; }
        public virtual DbSet<IMG_PRODUCT> IMG_PRODUCT { get; set; }
        public virtual DbSet<ORDER> ORDER { get; set; }
        public virtual DbSet<ORDER_DETAIL> ORDER_DETAIL { get; set; }
        public virtual DbSet<PRODUCT> PRODUCT { get; set; }
        public virtual DbSet<RENT> RENT { get; set; }
        public virtual DbSet<TYPECAR> TYPECAR { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<USER_ROLE> USER_ROLE { get; set; }
    }
}