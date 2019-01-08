namespace UPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexDataModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cabinete",
                c => new
                    {
                        IDProfesor = c.Int(nullable: false),
                        LocatieCabinet = c.String(),
                    })
                .PrimaryKey(t => t.IDProfesor)
                .ForeignKey("dbo.profesori", t => t.IDProfesor)
                .Index(t => t.IDProfesor);
            
            CreateTable(
                "dbo.profesori",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nume = c.String(nullable: false),
                        Prenume = c.String(nullable: false),
                        DataAngajarii = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.departamente",
                c => new
                    {
                        IDDepartament = c.Int(nullable: false, identity: true),
                        Nume = c.String(maxLength: 50),
                        Buget = c.Decimal(nullable: false, storeType: "money"),
                        DataInceperii = c.DateTime(nullable: false),
                        IDProfesor = c.Int(),
                        Administrator_ID = c.Int(),
                    })
                .PrimaryKey(t => t.IDDepartament)
                .ForeignKey("dbo.profesori", t => t.Administrator_ID)
                .Index(t => t.Administrator_ID);
            
            CreateTable(
                "dbo.ProfesorCurs",
                c => new
                    {
                        IDCurs = c.Int(nullable: false),
                        IDProfesor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IDCurs, t.IDProfesor })
                .ForeignKey("dbo.cursuri", t => t.IDCurs, cascadeDelete: true)
                .ForeignKey("dbo.profesori", t => t.IDProfesor, cascadeDelete: true)
                .Index(t => t.IDCurs)
                .Index(t => t.IDProfesor);
            
            Sql("INSERT INTO dbo.departamente (Nume, Buget, DataInceperii) VALUES ('Temp', 0.00, GETDATE())");
            AddColumn("dbo.cursuri", "IDDepartament", c => c.Int(nullable: false, defaultValue: 0));
          

          //  AddColumn("dbo.cursuri", "IDDepartament", c => c.Int(nullable: false));
            CreateIndex("dbo.cursuri", "IDDepartament");
            AddForeignKey("dbo.cursuri", "IDDepartament", "dbo.departamente", "IDDepartament", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.cabinete", "IDProfesor", "dbo.profesori");
            DropForeignKey("dbo.ProfesorCurs", "IDProfesor", "dbo.profesori");
            DropForeignKey("dbo.ProfesorCurs", "IDCurs", "dbo.cursuri");
            DropForeignKey("dbo.cursuri", "IDDepartament", "dbo.departamente");
            DropForeignKey("dbo.departamente", "Administrator_ID", "dbo.profesori");
            DropIndex("dbo.ProfesorCurs", new[] { "IDProfesor" });
            DropIndex("dbo.ProfesorCurs", new[] { "IDCurs" });
            DropIndex("dbo.departamente", new[] { "Administrator_ID" });
            DropIndex("dbo.cursuri", new[] { "IDDepartament" });
            DropIndex("dbo.cabinete", new[] { "IDProfesor" });
            DropColumn("dbo.cursuri", "IDDepartament");
            DropTable("dbo.ProfesorCurs");
            DropTable("dbo.departamente");
            DropTable("dbo.profesori");
            DropTable("dbo.cabinete");
        }
    }
}
