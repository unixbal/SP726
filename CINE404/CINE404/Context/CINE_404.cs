namespace CINE404
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CINE_404 : DbContext
    {
        // Your context has been configured to use a 'CINE_404' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CINE404.CINE_404' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CINE_404' 
        // connection string in the application configuration file.
        public CINE_404()
            : base("name=CINE_404")
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Oyuncu> Oyuncus { get; set; }
        public DbSet<Yonetmen> Yonetmens { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}