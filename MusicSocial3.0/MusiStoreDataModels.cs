namespace MusicSocial3
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using MusicSocial3.Models;


    public class MusiStoreDataModels : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artist { get; set; }
        //public DbSet<Cart> Carts { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        // Your context has been configured to use a 'MusiStoreDataModels' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MusicSocial3.MusiStoreDataModels' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MusiStoreDataModels' 
        // connection string in the application configuration file.
        public MusiStoreDataModels()
            : base("name=MusiStoreDataModels")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    
}