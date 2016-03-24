namespace muster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Camp_and_Musters : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Camps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mustering = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MusterEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CampId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Camps", t => t.CampId, cascadeDelete: true)
                .Index(t => t.CampId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MusterEvents", "CampId", "dbo.Camps");
            DropIndex("dbo.MusterEvents", new[] { "CampId" });
            DropTable("dbo.MusterEvents");
            DropTable("dbo.Camps");
        }
    }
}
