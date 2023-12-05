Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUtilizador.Text = "Utilizador"
        txtUtilizador.ForeColor = Color.DimGray

        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.DimGray
        btnEscondePassword.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUtilizador.Text = "admin" AndAlso txtPassword.Text = "admin" Then
            MessageBox.Show("Login bem-sucedido!")
            Form1.Show()
        Else
            MessageBox.Show(" O Utilizador ou palavra-passe estão inválidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If txtUtilizador.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Por favor preencha todos os espaços!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub txtUtilizador_GotFocus(sender As Object, e As EventArgs) Handles txtUtilizador.GotFocus
        If txtUtilizador.Text = "Utilizador" Then
            txtUtilizador.Text = ""
            txtUtilizador.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUtilizador_LostFocus(sender As Object, e As EventArgs) Handles txtUtilizador.LostFocus
        If txtUtilizador.Text = "" Then
            txtUtilizador.Text = "Utilizador"
            txtUtilizador.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "•"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click

    End Sub

    Private Sub btnEscondePassword_Click(sender As Object, e As EventArgs) Handles btnEscondePassword.Click

    End Sub
End Class

