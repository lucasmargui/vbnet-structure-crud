Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class CreateManyToManyRelationshipFornecedores
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Fornecedors",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .NomeFornecedor = c.String(nullable := False),
                        .Endereco = c.String(),
                        .Telefone = c.String(),
                        .Email = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.MaterialMovelFornecedor",
                Function(c) New With
                    {
                        .MaterialMovelId = c.Int(nullable := False),
                        .FornecedorId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.MaterialMovelId, t.FornecedorId }) _
                .ForeignKey("dbo.MaterialMovels", Function(t) t.MaterialMovelId, cascadeDelete := True) _
                .ForeignKey("dbo.Fornecedors", Function(t) t.FornecedorId, cascadeDelete := True) _
                .Index(Function(t) t.MaterialMovelId) _
                .Index(Function(t) t.FornecedorId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.MaterialMovelFornecedor", "FornecedorId", "dbo.Fornecedors")
            DropForeignKey("dbo.MaterialMovelFornecedor", "MaterialMovelId", "dbo.MaterialMovels")
            DropIndex("dbo.MaterialMovelFornecedor", New String() { "FornecedorId" })
            DropIndex("dbo.MaterialMovelFornecedor", New String() { "MaterialMovelId" })
            DropTable("dbo.MaterialMovelFornecedor")
            DropTable("dbo.Fornecedors")
        End Sub
    End Class
End Namespace
