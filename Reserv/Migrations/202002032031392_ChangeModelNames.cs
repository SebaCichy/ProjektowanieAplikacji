namespace Reserv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeModelNames : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "Users_UserID", "dbo.Student");
            DropIndex("dbo.Reservations", new[] { "Users_UserID" });
            AddColumn("dbo.Reservations", "User_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Reservations", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "User_Id");
            AddForeignKey("dbo.Reservations", "User_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Reservations", "Users_UserID");
            DropTable("dbo.Student");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            AddColumn("dbo.Reservations", "Users_UserID", c => c.Int());
            DropForeignKey("dbo.Reservations", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Reservations", new[] { "User_Id" });
            AlterColumn("dbo.Reservations", "UserID", c => c.String());
            DropColumn("dbo.Reservations", "User_Id");
            CreateIndex("dbo.Reservations", "Users_UserID");
            AddForeignKey("dbo.Reservations", "Users_UserID", "dbo.Student", "UserID");
        }
    }
}
