namespace UPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cursuri",
                c => new
                    {
                        IDCurs = c.Int(nullable: false),
                        Titlu = c.String(),
                        Credite = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDCurs);
            
            CreateTable(
                "dbo.inscriere",
                c => new
                    {
                        IDInscriere = c.Int(nullable: false, identity: true),
                        IDCurs = c.Int(nullable: false),
                        IDStudent = c.Int(nullable: false),
                        Nota = c.Int(nullable: false),
                        Student_ID = c.Int(),
                    })
                .PrimaryKey(t => t.IDInscriere)
                .ForeignKey("dbo.cursuri", t => t.IDCurs, cascadeDelete: true)
                .ForeignKey("dbo.studenti", t => t.Student_ID)
                .Index(t => t.IDCurs)
                .Index(t => t.Student_ID);
            
            CreateTable(
                "dbo.studenti",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        Prenume = c.String(),
                        DataInscrierii = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.inscriere", "Student_ID", "dbo.studenti");
            DropForeignKey("dbo.inscriere", "IDCurs", "dbo.cursuri");
            DropIndex("dbo.inscriere", new[] { "Student_ID" });
            DropIndex("dbo.inscriere", new[] { "IDCurs" });
            DropTable("dbo.studenti");
            DropTable("dbo.inscriere");
            DropTable("dbo.cursuri");
        }
    }
}
