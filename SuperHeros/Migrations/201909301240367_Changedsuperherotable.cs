namespace SuperHeros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedsuperherotable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SuperHeros", newName: "SuperHeroes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.SuperHeroes", newName: "SuperHeros");
        }
    }
}
