namespace Lab6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Role = c.String(),
                        Project_ProjectID = c.Int(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectID)
                .Index(t => t.Project_ProjectID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        CustomerName = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Project_ProjectID", "dbo.Projects");
            DropIndex("dbo.People", new[] { "Project_ProjectID" });
            DropTable("dbo.Projects");
            DropTable("dbo.People");
        }
    }
}
