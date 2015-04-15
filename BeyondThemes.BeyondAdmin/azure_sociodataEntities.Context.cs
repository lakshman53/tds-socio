﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeyondThemes.BeyondAdmin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class azure_sociodataEntities1 : DbContext
    {
        public azure_sociodataEntities1()
            : base("name=azure_sociodataEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<EmpGroup> EmpGroups { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<OfferGroup> OfferGroups { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
    
        public virtual int usp_AddArea(Nullable<int> level2id, Nullable<int> level3id, string entityName)
        {
            var level2idParameter = level2id.HasValue ?
                new ObjectParameter("level2id", level2id) :
                new ObjectParameter("level2id", typeof(int));
    
            var level3idParameter = level3id.HasValue ?
                new ObjectParameter("level3id", level3id) :
                new ObjectParameter("level3id", typeof(int));
    
            var entityNameParameter = entityName != null ?
                new ObjectParameter("EntityName", entityName) :
                new ObjectParameter("EntityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddArea", level2idParameter, level3idParameter, entityNameParameter);
        }
    
        public virtual int usp_AddCity(Nullable<int> level1id, Nullable<int> level2id, string entityName)
        {
            var level1idParameter = level1id.HasValue ?
                new ObjectParameter("level1id", level1id) :
                new ObjectParameter("level1id", typeof(int));
    
            var level2idParameter = level2id.HasValue ?
                new ObjectParameter("level2id", level2id) :
                new ObjectParameter("level2id", typeof(int));
    
            var entityNameParameter = entityName != null ?
                new ObjectParameter("EntityName", entityName) :
                new ObjectParameter("EntityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddCity", level1idParameter, level2idParameter, entityNameParameter);
        }
    
        public virtual int usp_AddRegion(Nullable<int> regionid, string entityName)
        {
            var regionidParameter = regionid.HasValue ?
                new ObjectParameter("regionid", regionid) :
                new ObjectParameter("regionid", typeof(int));
    
            var entityNameParameter = entityName != null ?
                new ObjectParameter("EntityName", entityName) :
                new ObjectParameter("EntityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddRegion", regionidParameter, entityNameParameter);
        }
    
        public virtual int usp_AddStore(Nullable<int> level3id, Nullable<int> level4id, string entityName)
        {
            var level3idParameter = level3id.HasValue ?
                new ObjectParameter("level3id", level3id) :
                new ObjectParameter("level3id", typeof(int));
    
            var level4idParameter = level4id.HasValue ?
                new ObjectParameter("level4id", level4id) :
                new ObjectParameter("level4id", typeof(int));
    
            var entityNameParameter = entityName != null ?
                new ObjectParameter("EntityName", entityName) :
                new ObjectParameter("EntityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddStore", level3idParameter, level4idParameter, entityNameParameter);
        }
    
        public virtual ObjectResult<usp_getArea_Result> usp_getArea(Nullable<int> thisHId)
        {
            var thisHIdParameter = thisHId.HasValue ?
                new ObjectParameter("thisHId", thisHId) :
                new ObjectParameter("thisHId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_getArea_Result>("usp_getArea", thisHIdParameter);
        }
    
        public virtual ObjectResult<usp_getCities_Result> usp_getCities(Nullable<int> thisHId)
        {
            var thisHIdParameter = thisHId.HasValue ?
                new ObjectParameter("thisHId", thisHId) :
                new ObjectParameter("thisHId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_getCities_Result>("usp_getCities", thisHIdParameter);
        }
    
        public virtual ObjectResult<usp_getRegion_Result> usp_getRegion(Nullable<int> thisHId)
        {
            var thisHIdParameter = thisHId.HasValue ?
                new ObjectParameter("thisHId", thisHId) :
                new ObjectParameter("thisHId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_getRegion_Result>("usp_getRegion", thisHIdParameter);
        }
    
        public virtual ObjectResult<usp_getStores_Result> usp_getStores(Nullable<int> thisHId)
        {
            var thisHIdParameter = thisHId.HasValue ?
                new ObjectParameter("thisHId", thisHId) :
                new ObjectParameter("thisHId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_getStores_Result>("usp_getStores", thisHIdParameter);
        }
    }
}
