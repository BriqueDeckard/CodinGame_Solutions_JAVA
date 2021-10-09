namespace WpfApp1.Infrastructure.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initialize : DbMigration
    {
        public override void Down()
        {
            DropForeignKey("dbo.ProductPrices", "ProductId", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Reference" });
            DropIndex("dbo.ProductPrices", new[] { "ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductPrices");
        }

        public override void Up()
        {
            CreateTable(
                "dbo.ProductPrices",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CreatedDate = c.DateTime(nullable: false),
                    PriceExcludingVat = c.Double(nullable: false),
                    ProductId = c.Int(nullable: false),
                    VatId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);

            CreateTable(
                "dbo.Products",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CreatedDate = c.DateTime(nullable: false),
                    Description = c.String(maxLength: 255),
                    IsActivated = c.Boolean(nullable: false),
                    Name = c.String(maxLength: 50),
                    Reference = c.String(maxLength: 10),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Reference);
        }
    }
}