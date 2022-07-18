Public Class SeleccionarProveedor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Response.Redirect("Proveedores.aspx")
    End Sub

    Protected Sub grillaProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grillaProveedores.SelectedIndexChanged


        Session("Razon_Social") = grillaProveedores.SelectedRow.Cells(1).Text

        Response.Redirect("Proveedores.aspx")

    End Sub
End Class