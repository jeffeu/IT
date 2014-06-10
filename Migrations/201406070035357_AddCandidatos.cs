namespace it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCandidatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidatos",
                c => new
                    {
                        CandidatoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sexo = c.String(),
                        CNH = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        EstadoCivil = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Email = c.String(),
                        Endereco = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.CandidatoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Candidatos");
        }
    }
}
