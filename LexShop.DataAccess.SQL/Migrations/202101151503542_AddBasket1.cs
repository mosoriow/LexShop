namespace LexShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBasket1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BasketItems", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BasketItems", "Quantity");
        }
    }
}
