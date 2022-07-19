Public Class Stock
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtProducto.Text = Session("Nombre")
        txtPrecio.Text = Session("Precio")
        txtStock.Text = Session("Cantidad")
        txtCategoria.Text = Session("Categoria")

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Response.Redirect("SeleccionarProducto.aspx")
    End Sub
End Class