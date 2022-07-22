Public Class SeleccionarProducto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        Response.Redirect("Stock.aspx")
    End Sub

    Protected Sub grillaProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grillaProductos.SelectedIndexChanged

        Session("Nombre") = grillaProductos.SelectedRow.Cells(2).Text
        Session("Precio") = grillaProductos.SelectedRow.Cells(3).Text
        Session("Cantidad") = grillaProductos.SelectedRow.Cells(4).Text
        Session("Categoria") = grillaProductos.SelectedRow.Cells(5).Text


        Response.Redirect("Stock.aspx")

    End Sub
End Class