﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KursEntities : DbContext
    {
        public KursEntities()
            : base("name=KursEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<InfoService> InfoService { get; set; }
        public virtual DbSet<NameService> NameService { get; set; }
        public virtual DbSet<ServiceClent> ServiceClent { get; set; }
    }
}
