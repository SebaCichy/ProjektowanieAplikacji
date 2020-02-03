namespace Reserv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserIdType2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Reservations", new[] { "User_Id" });
            DropColumn("dbo.Reservations", "UserID");
            RenameColumn(table: "dbo.Reservations", name: "User_Id", newName: "UserID");
            AlterColumn("dbo.Reservations", "UserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Reservations", "UserID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Reservations", new[] { "UserID" });
            AlterColumn("dbo.Reservations", "UserID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Reservations", name: "UserID", newName: "User_Id");
            AddColumn("dbo.Reservations", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "User_Id");
        }
    }
}
