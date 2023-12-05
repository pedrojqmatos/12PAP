Public Class Form1
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim janela As New PC
        janela.MdiParent = Me
        If pc_aberto = True Then
            MessageBox.Show("A janela já está aberta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            janela.Show()
        End If
    End Sub

    Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem.Click
        Dim janela As New Status
        janela.MdiParent = Me
        If status_aberto = True Then
            MessageBox.Show("A janela já está aberta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            janela.Show()
        End If
    End Sub

    Private Sub ReparaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReparaçãoToolStripMenuItem.Click
        Dim janela As New Reparação
        janela.MdiParent = Me
        If reparacao_aberto = True Then
            MessageBox.Show("A janela já está aberta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            janela.Show()
        End If
    End Sub

    Private Sub PortasDeVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortasDeVideoToolStripMenuItem.Click
        Dim janela As New Form3
        janela.MdiParent = Me
        If portasdevideo_aberto = True Then
            MessageBox.Show("A janela já está aberta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            janela.Show()
        End If
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        Dim janela As New Marca
        janela.MdiParent = Me
        If Marca_aberto = True Then
            MessageBox.Show("A janela já está aberta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            janela.Show()
        End If
    End Sub

    Private Sub LocalizaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalizaçãoToolStripMenuItem.Click
        Dim janela As New Localização
        janela.MdiParent = Me
        If localizacao_aberto = True Then
            MessageBox.Show("A janela já está aberta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            janela.Show()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim janela As New Rato
        janela.MdiParent = Me
        If Rato_aberto = True Then
            MessageBox.Show("A janela já está aberta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            janela.Show()
        End If
    End Sub

    Private Sub InterfaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterfaceToolStripMenuItem.Click
        Dim janela As New Form2
        janela.MdiParent = Me
        If Interface_aberto = True Then
            MessageBox.Show("A janela já está aberta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            janela.Show()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim janela As New trclados
        janela.MdiParent = Me
        If teclados_aberto = True Then
            MessageBox.Show("A janela já está aberta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            janela.Show()
        End If
    End Sub
End Class