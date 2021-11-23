namespace Lab6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ITCompanyDBv1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Manager", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Manager");
        }
    }
}
