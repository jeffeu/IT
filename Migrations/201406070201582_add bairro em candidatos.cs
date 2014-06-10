namespace it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbairroemcandidatos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidatos", "Bairro", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Candidatos", "Bairro");
        }
    }
}
