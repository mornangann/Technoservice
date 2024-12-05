﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ОООТехносервис.model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBConnectRequest : DbContext
    {
        public DBConnectRequest()
            : base("name=DBConnectRequest")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Defect> Defect { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Priory> Priory { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> User { get; set; }
    
        public virtual ObjectResult<GetRequestMasterId_Result> GetRequestMasterId(Nullable<int> masterId)
        {
            var masterIdParameter = masterId.HasValue ?
                new ObjectParameter("MasterId", masterId) :
                new ObjectParameter("MasterId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRequestMasterId_Result>("GetRequestMasterId", masterIdParameter);
        }
    }
}
