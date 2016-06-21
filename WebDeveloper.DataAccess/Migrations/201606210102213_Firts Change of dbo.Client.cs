namespace WebDeveloper.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirtsChangeofdboClient : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Client", "Apellidos", c => c.String(nullable: false));
            //DropColumn("dbo.Client", "LastName");
            RenameColumn("dbo.Client", "Apellidos", "LastName");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Client", "LastName", c => c.String(nullable: false));
            //DropColumn("dbo.Client", "Apellidos");
            RenameColumn("dbo.Client", "LastName", "Apellidos");
        }
    }
}
