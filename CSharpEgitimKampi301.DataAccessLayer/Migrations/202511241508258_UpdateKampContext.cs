namespace CSharpEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateKampContext : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductDescription", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductDescription", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
