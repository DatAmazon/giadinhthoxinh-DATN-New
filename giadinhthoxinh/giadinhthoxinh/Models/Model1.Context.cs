﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace giadinhthoxinh.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class giadinhthoxinhEntities : DbContext
    {
        public giadinhthoxinhEntities()
            : base("name=giadinhthoxinhEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblCheckinDetail> tblCheckinDetails { get; set; }
        public virtual DbSet<tblCheckoutDetail> tblCheckoutDetails { get; set; }
        public virtual DbSet<tblImage> tblImages { get; set; }
        public virtual DbSet<tblImportMaterial> tblImportMaterials { get; set; }
        public virtual DbSet<tblImportOrder> tblImportOrders { get; set; }
        public virtual DbSet<tblMaterColor> tblMaterColors { get; set; }
        public virtual DbSet<tblMaterial> tblMaterials { get; set; }
        public virtual DbSet<tblMaterPriceImport> tblMaterPriceImports { get; set; }
        public virtual DbSet<tblMaterSize> tblMaterSizes { get; set; }
        public virtual DbSet<tblOrder> tblOrders { get; set; }
        public virtual DbSet<tblPermission> tblPermissions { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblProductColor> tblProductColors { get; set; }
        public virtual DbSet<tblProductPrice> tblProductPrices { get; set; }
        public virtual DbSet<tblProductSize> tblProductSizes { get; set; }
        public virtual DbSet<tblPromote> tblPromotes { get; set; }
        public virtual DbSet<tblReview> tblReviews { get; set; }
        public virtual DbSet<tblSupplier> tblSuppliers { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    }
}
