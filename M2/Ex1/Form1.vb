Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Click
        lblResposta.Text = "?"
    End Sub

    Private Sub BtnAdvinhe_Click(sender As Object, e As EventArgs) Handles btnAdvinhe.Click
        lblResposta.Text = "Clube da robótica"

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        MessageBox.Show("Deseja Sair?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    End Sub
End Class
