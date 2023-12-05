Imports System.Runtime.InteropServices
Public Class frm_principal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fechar_submenu()

    End Sub

    Private Sub fechar_submenu()
        painel_emprestimo_submenu.Visible = False
        painel_ferramentas_submenu.Visible = False
        painel_submenu_leitor.Visible = False
    End Sub
    Private Sub mostrar_submenu(submenu As Panel)
        If submenu.Visible = False Then
            fechar_submenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btn_emprestimo_Click(sender As Object, e As EventArgs) Handles btn_emprestimo.Click
        mostrar_submenu(painel_emprestimo_submenu)
    End Sub







    Private Sub btn_perda_Click(sender As Object, e As EventArgs) Handles btn_perda.Click

        'codigo
        fechar_submenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

        'codigo
        fechar_submenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        openChildForm(New frm_add_livro())
        'codigo
        fechar_submenu()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

        'codigo
        fechar_submenu()
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(chilForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = chilForm
        chilForm.TopLevel = False
        chilForm.FormBorderStyle = FormBorderStyle.None
        chilForm.Dock = DockStyle.Fill
        painel_conteudo.Controls.Add(chilForm)
        painel_conteudo.Tag = chilForm
        chilForm.BringToFront()
        chilForm.Show()

    End Sub
    Private Sub painel_menufechar_MouseMove(sender As Object, e As MouseEventArgs) Handles painel_menufechar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Application.Exit()
    End Sub
    Private Sub btn_restaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click
        btn_maximizar.Visible = True
        btn_restaurar.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click
        btn_restaurar.Visible = True
        btn_maximizar.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_renovar_Click(sender As Object, e As EventArgs) Handles btn_renovar.Click

        'codigo
        fechar_submenu()
    End Sub

    Private Sub btn_entrada_Click(sender As Object, e As EventArgs) Handles btn_entrada.Click

        'codigo
        fechar_submenu()
    End Sub

    Private Sub btn_saida_Click(sender As Object, e As EventArgs) Handles btn_saida.Click
        'codigo
        fechar_submenu()
    End Sub

    Private Sub btn_venda_Click(sender As Object, e As EventArgs) Handles btn_venda.Click

        'codigo
        fechar_submenu()
    End Sub

    Private Sub btn_ferramentas_Click(sender As Object, e As EventArgs) Handles btn_ferramentas.Click
        mostrar_submenu(painel_ferramentas_submenu)
    End Sub

    Private Sub btn_add_leitor_Click(sender As Object, e As EventArgs) Handles btn_add_leitor.Click

    End Sub

    Private Sub btn_leitor_Click(sender As Object, e As EventArgs) Handles btn_leitor.Click
        mostrar_submenu(painel_submenu_leitor)
    End Sub
End Class