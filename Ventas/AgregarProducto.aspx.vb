Public Class AgregarProducto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub grillaProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grillaProductos.SelectedIndexChanged

        Session("Primera") = 1
        Session("ID_producto") = grillaProductos.SelectedRow.Cells(1).Text
        Session("Nombre") = grillaProductos.SelectedRow.Cells(2).Text
        Session("Precio") = grillaProductos.SelectedRow.Cells(3).Text
        'Response.Redirect("NuevaVenta.aspx")
        'Response.Write("<script type='text/javascript'>
        '                window.close();
        '            </script>")

    End Sub
End Class