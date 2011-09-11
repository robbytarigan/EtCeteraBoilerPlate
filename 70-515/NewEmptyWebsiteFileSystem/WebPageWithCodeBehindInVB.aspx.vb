
Partial Class WebPageWithCodeBehindInVB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            messageLiteral.Text = "This is a postback"
        End If
    End Sub
End Class
