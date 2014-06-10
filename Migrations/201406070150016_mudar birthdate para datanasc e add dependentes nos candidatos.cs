namespace it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mudarbirthdateparadatanasceadddependentesnoscandidatos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidatos", "Dependentes", c => c.String());
            AddColumn("dbo.Candidatos", "DataNasc", c => c.DateTime(nullable: false));
            DropColumn("dbo.Candidatos", "BirthDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Candidatos", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Candidatos", "DataNasc");
            DropColumn("dbo.Candidatos", "Dependentes");
        }
    }
}
