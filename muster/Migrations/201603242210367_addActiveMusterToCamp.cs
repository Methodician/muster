namespace muster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addActiveMusterToCamp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MusterEvents", "CampId", "dbo.Camps");
            AddColumn("dbo.Camps", "ActiveMuster_Id", c => c.Int());
            AddColumn("dbo.MusterEvents", "Camp_Id", c => c.Int());
            CreateIndex("dbo.Camps", "ActiveMuster_Id");
            CreateIndex("dbo.MusterEvents", "Camp_Id");
            AddForeignKey("dbo.Camps", "ActiveMuster_Id", "dbo.MusterEvents", "Id");
            AddForeignKey("dbo.MusterEvents", "Camp_Id", "dbo.Camps", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MusterEvents", "Camp_Id", "dbo.Camps");
            DropForeignKey("dbo.Camps", "ActiveMuster_Id", "dbo.MusterEvents");
            DropIndex("dbo.MusterEvents", new[] { "Camp_Id" });
            DropIndex("dbo.Camps", new[] { "ActiveMuster_Id" });
            DropColumn("dbo.MusterEvents", "Camp_Id");
            DropColumn("dbo.Camps", "ActiveMuster_Id");
            AddForeignKey("dbo.MusterEvents", "CampId", "dbo.Camps", "Id", cascadeDelete: true);
        }
    }
}
