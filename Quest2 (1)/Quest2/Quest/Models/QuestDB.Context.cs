﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuestEntities : DbContext
    {
        public QuestEntities()
            : base("name=QuestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<caroffer> caroffers { get; set; }
        public virtual DbSet<entertainmentPlace> entertainmentPlaces { get; set; }
        public virtual DbSet<entertainType> entertainTypes { get; set; }
        public virtual DbSet<Government> Governments { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }
        public virtual DbSet<TourCompany> TourCompanies { get; set; }
        public virtual DbSet<tourOffer> tourOffers { get; set; }
        public virtual DbSet<userCarReservation> userCarReservations { get; set; }
        public virtual DbSet<userTourReservation> userTourReservations { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
    }
}
