Public Class AgregarProducto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub


    Protected Sub grillaProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grillaProductos.SelectedIndexChanged


        Session("ID_producto") = grillaProductos.SelectedRow.Cells(1).Text
        Session("Nombre") = grillaProductos.SelectedRow.Cells(2).Text
        Session("Precio") = grillaProductos.SelectedRow.Cells(3).Text
        Session("Stock") = grillaProductos.SelectedRow.Cells(4).Text
        'Session("Actualizar") = True
        ' Response.Redirect("NuevaVenta.aspx")
        '  formAgregarProducto.InnerHtml = <script></script>

        Dim sUrl As String = "AgregarProducto.aspx"
        Dim sScript As String = "<script language =javascript> "
        sScript += "window.close('" & sUrl & "',null,'toolbar=0,scrollbars=1,location=0,statusbar=0,menubar=0,resizable=1,width=1000,height=500,left=200,top=200');"
        sScript += "</script> "
        Response.Write(sScript)
    End Sub
End Class