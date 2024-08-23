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
    Public Class MovelPedidosController
        Inherits System.Web.Mvc.Controller

        Private db As New CustomDbContext

        ' GET: MovelPedidos
        Function Index() As ActionResult
            Dim movelPedidoes = db.MovelPedidoes.Include(Function(m) m.MaterialMovel)
            Return View(movelPedidoes.ToList())
        End Function

        ' GET: MovelPedidos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim movelPedido As MovelPedido = db.MovelPedidoes.Find(id)
            If IsNothing(movelPedido) Then
                Return HttpNotFound()
            End If
            Return View(movelPedido)
        End Function

        ' GET: MovelPedidos/Create
        Function Create() As ActionResult
            ViewBag.MaterialMovelId = New SelectList(db.MaterialMovels, "Id", "NomeMaterial")
            Return View()
        End Function

        ' POST: MovelPedidos/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,NumeroPedido,Quantidade,DataPedido,MaterialMovelId")> ByVal movelPedido As MovelPedido) As ActionResult
            If ModelState.IsValid Then
                db.MovelPedidoes.Add(movelPedido)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.MaterialMovelId = New SelectList(db.MaterialMovels, "Id", "NomeMaterial", movelPedido.MaterialMovelId)
            Return View(movelPedido)
        End Function

        ' GET: MovelPedidos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim movelPedido As MovelPedido = db.MovelPedidoes.Find(id)
            If IsNothing(movelPedido) Then
                Return HttpNotFound()
            End If
            ViewBag.MaterialMovelId = New SelectList(db.MaterialMovels, "Id", "NomeMaterial", movelPedido.MaterialMovelId)
            Return View(movelPedido)
        End Function

        ' POST: MovelPedidos/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,NumeroPedido,Quantidade,DataPedido,MaterialMovelId")> ByVal movelPedido As MovelPedido) As ActionResult
            If ModelState.IsValid Then
                db.Entry(movelPedido).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.MaterialMovelId = New SelectList(db.MaterialMovels, "Id", "NomeMaterial", movelPedido.MaterialMovelId)
            Return View(movelPedido)
        End Function

        ' GET: MovelPedidos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim movelPedido As MovelPedido = db.MovelPedidoes.Find(id)
            If IsNothing(movelPedido) Then
                Return HttpNotFound()
            End If
            Return View(movelPedido)
        End Function

        ' POST: MovelPedidos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim movelPedido As MovelPedido = db.MovelPedidoes.Find(id)
            db.MovelPedidoes.Remove(movelPedido)
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
