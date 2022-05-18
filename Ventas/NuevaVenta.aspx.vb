Public Class Ventas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.txtDNI.Text = Session("DNI")
        Me.txtNombre.Text = Session("NombreCliente")

        Me.txtProducto.Text = Session("Nombre")
        Me.txtCodigo.Text = Session("ID_producto")
        Me.txtPrecioUnitario.Text = Session("Precio")

    End Sub

    Protected Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click

        Response.Redirect("AgregarProducto.aspx")

    End Sub

    Protected Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Response.Redirect("~/ABM/Clientes/ABM_clientesCargar.aspx")
    End Sub

    Protected Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Response.Redirect("AgregarCliente.aspx")
    End Sub
End Class