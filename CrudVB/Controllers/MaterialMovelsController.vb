Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports CrudVB

Namespace Controllers
    Public Class MaterialMovelsController
        Inherits System.Web.Mvc.Controller

        Private db As New CustomDbContext

        ' GET: MaterialMovels
        Function Index() As ActionResult
            Return View(db.MaterialMovels.ToList())
        End Function

        ' GET: MaterialMovels/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim materialMovel As MaterialMovel = db.MaterialMovels.Find(id)
            If IsNothing(materialMovel) Then
                Return HttpNotFound()
            End If
            Return View(materialMovel)
        End Function

        ' GET: MaterialMovels/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: MaterialMovels/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,NomeMaterial,TipoMaterial,Descricao,Espessura,Largura,Altura,Cor,Fabricante,CodigoFabricante,Preco,DataCadastro")> ByVal materialMovel As MaterialMovel) As ActionResult
            If ModelState.IsValid Then
                db.MaterialMovels.Add(materialMovel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(materialMovel)
        End Function

        ' GET: MaterialMovels/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim materialMovel As MaterialMovel = db.MaterialMovels.Find(id)
            If IsNothing(materialMovel) Then
                Return HttpNotFound()
            End If
            Return View(materialMovel)
        End Function

        ' POST: MaterialMovels/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,NomeMaterial,TipoMaterial,Descricao,Espessura,Largura,Altura,Cor,Fabricante,CodigoFabricante,Preco,DataCadastro")> ByVal materialMovel As MaterialMovel) As ActionResult
            If ModelState.IsValid Then
                db.Entry(materialMovel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(materialMovel)
        End Function

        ' GET: MaterialMovels/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim materialMovel As MaterialMovel = db.MaterialMovels.Find(id)
            If IsNothing(materialMovel) Then
                Return HttpNotFound()
            End If
            Return View(materialMovel)
        End Function

        ' POST: MaterialMovels/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim materialMovel As MaterialMovel = db.MaterialMovels.Find(id)
            db.MaterialMovels.Remove(materialMovel)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
