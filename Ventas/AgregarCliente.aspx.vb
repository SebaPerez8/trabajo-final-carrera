Public Class AgregarCliente
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Response.Redirect("NuevaVenta.aspx")
    End Sub

    Protected Sub grillaProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grillaProductos.SelectedIndexChanged

        Session("DNI") = grillaProductos.SelectedRow.Cells(1).Text
        Session("NombreCliente") = grillaProductos.SelectedRow.Cells(2).Text

        Response.Redirect("NuevaVenta.aspx")
    End Sub
End Class