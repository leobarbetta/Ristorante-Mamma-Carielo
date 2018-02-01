namespace Ristorante.Mamma.Carielo.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        DataCadastro = c.DateTime(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Despesa",
                c => new
                    {
                        DespesaId = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        FormaPagamento = c.Int(nullable: false),
                        Observacao = c.String(),
                        MercadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DespesaId)
                .ForeignKey("dbo.Mercado", t => t.MercadoId)
                .Index(t => t.MercadoId);
            
            CreateTable(
                "dbo.Mercado",
                c => new
                    {
                        MercadoId = c.Int(nullable: false, identity: true),
                        DataCadastro = c.DateTime(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.MercadoId);
            
            CreateTable(
                "dbo.Faturamento",
                c => new
                    {
                        FaturamentoId = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        FormaPagamento = c.Int(nullable: false),
                        Observacao = c.String(),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FaturamentoId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faturamento", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Despesa", "MercadoId", "dbo.Mercado");
            DropIndex("dbo.Faturamento", new[] { "ClienteId" });
            DropIndex("dbo.Despesa", new[] { "MercadoId" });
            DropTable("dbo.Faturamento");
            DropTable("dbo.Mercado");
            DropTable("dbo.Despesa");
            DropTable("dbo.Cliente");
        }
    }
}
