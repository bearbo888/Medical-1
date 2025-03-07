﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medical
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MedicalEntities : DbContext
    {
        public MedicalEntities()
            : base("name=MedicalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administarator> Administarators { get; set; }
        public virtual DbSet<Advertise> Advertises { get; set; }
        public virtual DbSet<AdvertiseStatue> AdvertiseStatues { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleComment> ArticleComments { get; set; }
        public virtual DbSet<CaseRecord> CaseRecords { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ClinicDetail> ClinicDetails { get; set; }
        public virtual DbSet<ClinicRoom> ClinicRooms { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentCategory> DepartmentCategories { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Newscategory> Newscategories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Orderstate> Orderstates { get; set; }
        public virtual DbSet<Paytype> Paytypes { get; set; }
        public virtual DbSet<Period> Periods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductBrand> ProductBrands { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductSpecification> ProductSpecifications { get; set; }
        public virtual DbSet<RatingDoctor> RatingDoctors { get; set; }
        public virtual DbSet<RatingType> RatingTypes { get; set; }
        public virtual DbSet<Reserve> Reserves { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<ShipType> ShipTypes { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<TreatmentDetail> TreatmentDetails { get; set; }
    }
}
