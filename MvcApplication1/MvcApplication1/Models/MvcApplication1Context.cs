﻿using System.Data.Entity;

namespace MvcApplication1.Models
{
    public class MvcApplication1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MvcApplication1.Models.MvcApplication1Context>());

        public MvcApplication1Context() : base("name=MvcApplication1Context")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<MvcApplication1Context, Migrations.Configuration>());
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
