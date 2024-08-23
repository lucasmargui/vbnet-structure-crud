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
    Public Class FornecedorsController
        Inherits System.Web.Mvc.Controller

        Private db As New CustomDbContext

        ' GET: Fornecedors
        Function Index() As ActionResult
            Return View(db.Fornecedores.ToList())
        End Function

        ' GET: Fornecedors/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim fornecedor As Fornecedor = db.Fornecedores.Find(id)
            If IsNothing(fornecedor) Then
                Return HttpNotFound()
            End If
            Return View(fornecedor)
        End Function

        ' GET: Fornecedors/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Fornecedors/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,NomeFornecedor,Endereco,Telefone,Email")> ByVal fornecedor As Fornecedor) As ActionResult
            If ModelState.IsValid Then
                db.Fornecedores.Add(fornecedor)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(fornecedor)
        End Function

        ' GET: Fornecedors/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim fornecedor As Fornecedor = db.Fornecedores.Find(id)
            If IsNothing(fornecedor) Then
                Return HttpNotFound()
            End If
            Return View(fornecedor)
        End Function

        ' POST: Fornecedors/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,NomeFornecedor,Endereco,Telefone,Email")> ByVal fornecedor As Fornecedor) As ActionResult
            If ModelState.IsValid Then
                db.Entry(fornecedor).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(fornecedor)
        End Function

        ' GET: Fornecedors/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim fornecedor As Fornecedor = db.Fornecedores.Find(id)
            If IsNothing(fornecedor) Then
                Return HttpNotFound()
            End If
            Return View(fornecedor)
        End Function

        ' POST: Fornecedors/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim fornecedor As Fornecedor = db.Fornecedores.Find(id)
            db.Fornecedores.Remove(fornecedor)
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
