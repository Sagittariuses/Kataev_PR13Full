﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddDataToDB.LocalModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirEntities : DbContext
    {
        public AirEntities()
            : base("name=AirEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApplicationForTheConditionOfTheAircraft> ApplicationForTheConditionOfTheAircraft { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientType> ClientType { get; set; }
        public virtual DbSet<Plane> Plane { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Stuff> Stuff { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TicketInfo> TicketInfo { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
