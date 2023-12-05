Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtutilizador.Text = "Utilizador"
        txtutilizador.ForeColor = Color.DarkGray

        txtpassword.Text = "Password"
        txtpassword.ForeColor = Color.DarkGray


        pic_verpw.Visible = False
        pic_esconderpw.Visible = False

    End Sub

    Private Sub txtutilizador_GotFocus(sender As Object, e As EventArgs) Handles txtutilizador.GotFocus
        If txtutilizador.Text = "Utilizador" Then
            txtutilizador.Text = ""
            txtutilizador.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtutilizador_LostFocus(sender As Object, e As EventArgs) Handles txtutilizador.LostFocus
        If txtutilizador.Text = "" Then
            txtutilizador.Text = "Utilizador"
            txtutilizador.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtpassword_GotFocus(sender As Object, e As EventArgs) Handles txtpassword.GotFocus
        If txtpassword.Text = "Password" Then
            txtpassword.Text = ""
            txtpassword.PasswordChar = "•"
            txtpassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpassword_LostFocus(sender As Object, e As EventArgs) Handles txtpassword.LostFocus
        If txtpassword.Text = "" Then
            txtpassword.Text = "Password"
            txtpassword.PasswordChar = ""
            pic_verpw.Visible = False

            txtpassword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        frm_principal.Show()
        Me.Hide()

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Tem a certeza de que deseja sair ?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub pic_verpw_Click(sender As Object, e As EventArgs) Handles pic_verpw.Click
        txtpassword.PasswordChar = ControlChars.NullChar
        pic_verpw.Visible = False
        pic_esconderpw.Visible = True

    End Sub

    Private Sub pic_esconderpw_Click(sender As Object, e As EventArgs) Handles pic_esconderpw.Click
        txtpassword.PasswordChar = "•"
        pic_verpw.Visible = True
        pic_esconderpw.Visible = False

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text.Trim() <> "" Then
            ' Mostra o PictureBox
            pic_verpw.Visible = True
        Else
            ' Esconde o PictureBox
            pic_verpw.Visible = False
        End If
    End Sub
End Class

