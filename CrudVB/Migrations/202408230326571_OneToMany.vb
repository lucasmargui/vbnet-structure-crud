Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class OneToMany
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.MaterialMovels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .NomeMaterial = c.String(nullable := False),
                        .TipoMaterial = c.String(),
                        .Descricao = c.String(),
                        .Espessura = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Largura = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Altura = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Cor = c.String(),
                        .Fabricante = c.String(),
                        .CodigoFabricante = c.String(),
                        .Preco = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .DataCadastro = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.MovelPedidoes",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .NumeroPedido = c.String(nullable := False),
                        .Quantidade = c.Int(nullable := False),
                        .DataPedido = c.DateTime(nullable := False),
                        .MaterialMovelId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.MaterialMovels", Function(t) t.MaterialMovelId, cascadeDelete := True) _
                .Index(Function(t) t.MaterialMovelId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.MovelPedidoes", "MaterialMovelId", "dbo.MaterialMovels")
            DropIndex("dbo.MovelPedidoes", New String() { "MaterialMovelId" })
            DropTable("dbo.MovelPedidoes")
            DropTable("dbo.MaterialMovels")
        End Sub
    End Class
End Namespace
