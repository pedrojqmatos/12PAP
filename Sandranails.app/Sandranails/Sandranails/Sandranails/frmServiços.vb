Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class frmServiços
    Dim str As String = "server = localhost; port = 3306; username = root; password =; database = sandranails; SslMode = none"
    Dim connection As New MySqlConnection(str)
    Dim itemcoll(100) As String

    Private Sub frmServiços_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaServicos()
        txtProcura.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub PicAdicionar_Click(sender As Object, e As EventArgs) Handles PicAdicionar.Click
        Try
            Dim timeText As String = MTBDuracao.Text
            Dim validTime As Boolean = ValidateTime(timeText)
            connection.Open()

            If Not validTime Then
                MessageBox.Show("Hora inválida. Por favor, insira uma hora válida no formato HH:mm.")
                MTBDuracao.Text = "00:00"
                Return
            End If

            If ja_existe_designacao(txtdesignacao.Text) Then
                MessageBox.Show("O nome do serviço já existe. Por favor insira um nome diferente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim cmd As MySqlCommand
            cmd = connection.CreateCommand
            cmd.CommandText = "Insert into tabela_dos_servicos (SV_DESIGNACAO, SV_DURACAO, SV_PRECO) values (@sv_designacao, @sv_duracao, @sv_preco);"
            cmd.Parameters.AddWithValue("@sv_designacao", txtdesignacao.Text)
            cmd.Parameters.AddWithValue("@sv_duracao", MTBDuracao.Text)
            cmd.Parameters.AddWithValue("@sv_preco", MTBpreco.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao adicionar o serviço: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        limpacampos()
        ListaServicos()
    End Sub

    Private Sub PicRemover_Click(sender As Object, e As EventArgs) Handles PicRemover.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "delete from tabela_dos_servicos where ID_DO_SERVICO = @id_servico;"
        cmd.Parameters.AddWithValue("@id_servico", txtCOD.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpacampos()
        ListaServicos()
    End Sub

    Private Sub PicEditar_Click(sender As Object, e As EventArgs) Handles PicEditar.Click
        Dim timeText As String = MTBDuracao.Text
        Dim validTime As Boolean = ValidateTime(timeText)
        If validTime Then
            Dim cmd As MySqlCommand
            connection.Open()
            cmd = connection.CreateCommand()
            cmd.CommandText = "update tabela_dos_servicos set SV_DESIGNACAO = @sv_designacao, SV_DURACAO = @sv_duracao, SV_PRECO = @sv_preco where ID_DO_SERVICO = @sv_cod;"
            cmd.Parameters.AddWithValue("@sv_cod", txtCOD.Text)
            cmd.Parameters.AddWithValue("@sv_designacao", txtdesignacao.Text)
            cmd.Parameters.AddWithValue("@sv_duracao", MTBDuracao.Text)
            cmd.Parameters.AddWithValue("@sv_preco", MTBpreco.Text)
            cmd.ExecuteNonQuery()
            connection.Close()
            limpacampos()
            ListaServicos()
        Else
            MessageBox.Show("Hora inválida. Por favor, insira uma hora válida no formato HH:mm.")
        End If
    End Sub

    Private Sub PicLimpar_Click(sender As Object, e As EventArgs) Handles PicLimpar.Click
        limpacampos()
    End Sub

    Private Sub limpacampos()
        txtdesignacao.Text = ""
        MTBDuracao.Text = ""
        MTBpreco.Text = ""
        txtCOD.Text = ""
    End Sub

    Private Sub ListaServicos()
        Dim cmd As MySqlCommand
        Dim ds As DataSet
        Dim da As MySqlDataAdapter
        ListServicos.Items.Clear()
        connection = New MySqlConnection("server = localhost; port = 3306; username = root; password =; database = sandranails; SslMode = none")
        Dim strQ As String = String.Empty
        strQ = "SELECT * FROM tabela_dos_servicos"
        cmd = New MySqlCommand(strQ, connection)
        da = New MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Table")
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListServicos.Items.Add(lvi)
        Next
    End Sub

    Private Sub PICsair_Click(sender As Object, e As EventArgs) Handles PICsair.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Listar_Dados()
        txtCOD.Text = ListServicos.SelectedItems.Item(0).SubItems(0).Text
        txtdesignacao.Text = ListServicos.SelectedItems.Item(0).SubItems(1).Text
        MTBDuracao.Text = ListServicos.SelectedItems.Item(0).SubItems(2).Text
        MTBpreco.Text = ListServicos().SelectedItems.Item(0).SubItems(3).Text
    End Sub

    Private Sub ListServicos_Click(sender As Object, e As EventArgs) Handles ListServicos.Click
        Listar_Dados()
    End Sub

    Private Sub txtProcura_TextChanged(sender As Object, e As EventArgs) Handles txtProcura.TextChanged
        ListServicos.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * from tabela_dos_servicos where SV_DESIGNACAO LIKE  '%" & txtProcura.Text & "%' Order By ID_DO_SERVICO", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            ListServicos.Items.Add(coluna.Item(0))
            ListServicos.Items(ListServicos.Items.Count - 1).SubItems.Add(coluna.Item(1))
            ListServicos.Items(ListServicos.Items.Count - 1).SubItems.Add(coluna.Item(2))
            ListServicos.Items(ListServicos.Items.Count - 1).SubItems.Add(coluna.Item(3))
        Next
    End Sub

    Private Function ValidateTime(timeText As String) As Boolean
        Dim regexPattern As String = "^([0-1][0-9]|2[0-3]):[0-5][0-9]$"
        Dim regexMatch As Match = Regex.Match(timeText, regexPattern)

        If regexMatch.Success Then
            Dim parts As String() = timeText.Split(":")
            Dim hours As Integer = Integer.Parse(parts(0))
            Dim minutes As Integer = Integer.Parse(parts(1))

            If hours <= 23 AndAlso minutes <= 59 Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdesignacao.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function ja_existe_designacao(designacao As String) As Boolean
        Dim cmd As MySqlCommand
        cmd = connection.CreateCommand()
        cmd.CommandText = "SELECT COUNT(*) FROM tabela_dos_servicos WHERE SV_DESIGNACAO = @designacao"
        cmd.Parameters.AddWithValue("@designacao", designacao)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Hide()
        txtProcura.Show()
        PictureBox2.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.Show()
        txtProcura.Hide()
        PictureBox2.Hide()
    End Sub
End Class