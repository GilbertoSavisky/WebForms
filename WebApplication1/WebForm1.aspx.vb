Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Response.Write("Olá " + txtMensagem.Text)
        Response.Write("<script>alert('Olá " + txtMensagem.Text + "')</script>")

    End Sub
End Class