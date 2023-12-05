Public Class Form1

    Private Sub MenuClientes_Click(sender As Object, e As EventArgs) Handles MenuClientes.Click
        Me.Hide()
        frmClientes.Show()
    End Sub

    Private Sub MenuServicos_Click(sender As Object, e As EventArgs) Handles MenuServicos.Click
        Me.Hide()
        frmServiços.Show()
    End Sub

    Private Sub MenuProdutos_Click(sender As Object, e As EventArgs) Handles MenuProdutos.Click
        Me.Hide()
        frmProdutos.Show()
    End Sub

    Private Sub MenuMarcacoes_Click(sender As Object, e As EventArgs) Handles MenuMarcacoes.Click
        Me.Hide()
        frmMarcacoes.Show()
    End Sub
End Class
