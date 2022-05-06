Public Class Ventas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Session("contar") = 0
        'If Session("Primera") = 1 And Session("contar") = 1 Then
        '    Response.Redirect("NuevaVenta.aspx")
        '    Session("contar") = 1
        'End If
        Me.txtProducto.Text = Session("Nombre")
        Me.txtCodigo.Text = Session("ID_producto")
        Me.txtPrecioUnitario.Text = Session("Precio")
    End Sub

    Protected Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click

        Dim sUrl As String = "AgregarProducto.aspx"
        Dim sScript As String = "<script language =javascript> "
        sScript += "window.open('" & sUrl & "',null,'toolbar=0,scrollbars=1,location=0,statusbar=0,menubar=0,resizable=1,width=1000,height=500,left=200,top=200');"
        sScript += "</script> "
        Response.Write(sScript)

    End Sub
End Class