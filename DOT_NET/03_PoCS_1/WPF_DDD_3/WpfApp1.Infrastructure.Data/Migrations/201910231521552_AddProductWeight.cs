namespace WpfApp1.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductWeight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Weight", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Weight");
        }
    }
}
