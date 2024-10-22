﻿Imports System.Data.Entity
Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin

' You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
Public Class ApplicationUser
    Inherits IdentityUser
    Public Async Function GenerateUserIdentityAsync(manager As UserManager(Of ApplicationUser)) As Task(Of ClaimsIdentity)
        ' Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        Dim userIdentity = Await manager.CreateIdentityAsync(Me, DefaultAuthenticationTypes.ApplicationCookie)
        ' Add custom user claims here
        Return userIdentity
    End Function
End Class

Public Class ApplicationDbContext
    Inherits IdentityDbContext(Of ApplicationUser)
    Public Sub New()
        MyBase.New("DefaultConnection", throwIfV1Schema:=False)
    End Sub

    Public Shared Function Create() As ApplicationDbContext
        Return New ApplicationDbContext()
    End Function
End Class


Public Class CustomDbContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ConnectProjetoDB")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        ' Configuração para a relação many-to-many entre MaterialMovel e Fornecedor
        modelBuilder.Entity(Of MaterialMovel)() _
            .HasMany(Function(m) m.Fornecedores) _
            .WithMany(Function(f) f.Materials) _
            .Map(Sub(mp)
                     mp.MapLeftKey("MaterialMovelId")
                     mp.MapRightKey("FornecedorId")
                     mp.ToTable("MaterialMovelFornecedor")
                 End Sub)


    End Sub

    Public Property MaterialMovels As DbSet(Of MaterialMovel)
    Public Property MovelPedidoes As DbSet(Of MovelPedido)
    Public Property Fornecedores As DbSet(Of Fornecedor)


End Class


