Imports MySql.Data.MySqlClient
Public Class PC
    Dim str As String = "DataSource=localhost;port=3306;username=root;password=;database=PAP;SslMode=none"
    Dim connection As New MySqlConnection(str)
    Private Sub lista()
        ListView1.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM pc", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            ListView1.Items.Add(coluna.Item(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(5))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(6))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(7))
        Next
    End Sub
    Private Sub codigo()
        Dim max As Integer = 0
        Dim ds1 As New DataSet
        Dim dt1 As New DataTable
        ds1.Tables.Add(dt1)
        Dim da1 As New MySqlDataAdapter("SELECT * FROM pc", connection)
        da1.Fill(dt1)

        For i = 0 To ds1.Tables(0).Rows.Count - 1
            Label8.Text = ds1.Tables(0).Rows(i).Item(0)
            If Val(Label8.Text) > max Then
                max = Val(Label8.Text)
            End If
        Next
        Label8.Text = (max + 1).ToString
    End Sub

    Private Sub limpa()
        txtnome.Text = ""
        txtmodelo.Text = ""
        cbxlocalizacao.Text = ""
        cbxmarca.Text = ""
        cbxrato.Text = ""
        cbxstatus.Text = ""
        cbxteclado.Text = ""
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxpesquisar.Text = "Nome"
        codigo()
        lista()
        pc_aberto = True
        Label10.Hide()
        Label11.Hide()
        cbxteclado.Hide()
        cbxrato.Hide()
    End Sub

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        pc_aberto = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If marca_ja_existe(label8.Text) Then
            MessageBox.Show("Não pode usar o mesmo ID!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand
        cmd.CommandText = "insert into pc(PC_ID,PC_Nome,PC_Modelo,PC_Localizacao,PC_Status,PC_Marca,PC_Rato,PC_Teclado)values(@id,@nome,@modelo,@localizacao,@status,@marca,@rato,@teclado);"
        cmd.Parameters.AddWithValue("@id", Label8.Text)
        cmd.Parameters.AddWithValue("@nome", txtnome.Text)
        cmd.Parameters.AddWithValue("@modelo", txtmodelo.Text)
        cmd.Parameters.AddWithValue("@localizacao", cbxlocalizacao.Text)
        cmd.Parameters.AddWithValue("@status", cbxstatus.Text)
        cmd.Parameters.AddWithValue("@marca", cbxmarca.Text)
        cmd.Parameters.AddWithValue("@rato", cbxrato.Text)
        cmd.Parameters.AddWithValue("@teclado", cbxteclado.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpa()
        lista()
        codigo()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "delete from pc where PC_ID=@id;"
        cmd.Parameters.AddWithValue("@id", Label8.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpa()
        lista()
        codigo()
    End Sub

    Private Sub listar()
        Label8.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
        txtnome.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
        cbxmarca.Text = ListView1.SelectedItems.Item(0).SubItems(2).Text
        txtmodelo.Text = ListView1.SelectedItems.Item(0).SubItems(3).Text
        cbxlocalizacao.Text = ListView1.SelectedItems.Item(0).SubItems(4).Text
        cbxstatus.Text = ListView1.SelectedItems.Item(0).SubItems(5).Text
        cbxrato.Text = ListView1.SelectedItems.Item(0).SubItems(6).Text
        cbxteclado.Text = ListView1.SelectedItems.Item(0).SubItems(7).Text
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        listar()
    End Sub

    Private Sub cbxmarca_Click(sender As Object, e As EventArgs) Handles cbxmarca.Click
        cbxmarca.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM marca", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            cbxmarca.Items.Add(coluna.Item(0))
        Next
    End Sub

    Private Sub cbxlocalizacao_Click(sender As Object, e As EventArgs) Handles cbxlocalizacao.Click
        cbxlocalizacao.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM localizacao", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            cbxlocalizacao.Items.Add(coluna.Item(0))
        Next
    End Sub

    Private Sub cbxstatus_Click(sender As Object, e As EventArgs) Handles cbxstatus.Click
        cbxstatus.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM status", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            cbxstatus.Items.Add(coluna.Item(0))
        Next
    End Sub
    Private Function marca_ja_existe(marca As String) As Boolean
        Dim cmd As MySqlCommand
        cmd = connection.CreateCommand()
        cmd.CommandText = "Select count(*) from portasdevideo where PE_PortaDeVideo = @portasdevideo"
        cmd.Parameters.AddWithValue("@portasdevideo", marca)

        connection.Open()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        connection.Close()
        Return count > 0
    End Function

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "update pc set PC_Nome=@nome, PC_Modelo=@modelo, PC_Localizacao=@localizacao, PC_Status=@status, PC_Marca=@marca, PC_Rato=@rato, PC_Teclado=@teclado  where PC_ID=@id;"
        cmd.Parameters.AddWithValue("@id", Label8.Text)
        cmd.Parameters.AddWithValue("@nome", txtnome.Text)
        cmd.Parameters.AddWithValue("@modelo", txtmodelo.Text)
        cmd.Parameters.AddWithValue("@localizacao", cbxlocalizacao.Text)
        cmd.Parameters.AddWithValue("@status", cbxstatus.Text)
        cmd.Parameters.AddWithValue("@marca", cbxmarca.Text)
        cmd.Parameters.AddWithValue("@rato", cbxrato.Text)
        cmd.Parameters.AddWithValue("@teclado", cbxteclado.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpa()
        lista()
        codigo()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        codigo()
        limpa()
    End Sub

    Private Sub txtpesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtpesquisar.TextChanged
        If cbxpesquisar.Text = "ID" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM pc where PC_ID Like '%" & txtpesquisar.Text & "%' Order By PC_ID", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(5))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(7))
            Next
        ElseIf cbxpesquisar.Text = "Nome" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM pc where PC_Nome Like '%" & txtpesquisar.Text & "%' Order By PC_Nome", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(5))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(7))
            Next
        ElseIf cbxpesquisar.Text = "Modelo" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM pc where PC_Modelo Like '%" & txtpesquisar.Text & "%' Order By PC_Modelo", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(5))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(7))
            Next
        ElseIf cbxpesquisar.Text = "Localização" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM pc where PC_Localizacao Like '%" & txtpesquisar.Text & "%' Order By PC_Localizacao", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(5))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(7))
            Next
        ElseIf cbxpesquisar.Text = "Status" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM pc where PC_Status Like '%" & txtpesquisar.Text & "%' Order By PC_Status", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(5))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(7))
            Next
        ElseIf cbxpesquisar.Text = "Marca" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM pc where PC_Marca Like '%" & txtpesquisar.Text & "%' Order By PC_Marca", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(5))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(7))
            Next
        ElseIf cbxpesquisar.Text = "Rato" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM pc where PC_Rato Like '%" & txtpesquisar.Text & "%' Order By PC_Rato", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(5))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(7))
            Next
        ElseIf cbxpesquisar.Text = "Teclado" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM pc where PC_Teclado Like '%" & txtpesquisar.Text & "%' Order By PC_Teclado", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(5))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(7))
            Next
        End If
    End Sub

    Private Sub cbxstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxstatus.SelectedIndexChanged
        If cbxstatus.Text = "Utilização" Then
            cbxrato.Show()
            cbxteclado.Show()
            Label10.Show()
            Label11.Show()
        Else
            cbxrato.Hide()
            cbxteclado.Hide()
            Label10.Hide()
            Label11.Hide()
        End If
    End Sub
End Class