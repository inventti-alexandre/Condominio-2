namespace Condominio.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Residentes",
                c => new
                    {
                        ResidenteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Email = c.String(),
                        Dni = c.Int(nullable: false),
                        Telefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ResidenteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Residentes");
        }
    }
}
