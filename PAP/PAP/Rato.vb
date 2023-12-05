Imports MySql.Data.MySqlClient
Public Class Rato
    Dim str As String = "DataSource=localhost;port=3306;username=root;password=;database=PAP;SslMode=none"
    Dim connection As New MySqlConnection(str)
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If marca_ja_existe(Label6.Text) Then
            MessageBox.Show("Não pode usar o mesmo ID!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand
        cmd.CommandText = "insert into ratos(RA_ID, RA_Nome, RA_Interface, RA_Modelo, RA_Marca)values(@id,@nome,@interface,@modelo,@marca);"
        cmd.Parameters.AddWithValue("@id", Label6.Text)
        cmd.Parameters.AddWithValue("@nome", txtnome.Text)
        cmd.Parameters.AddWithValue("@interface", cbxInterface.Text)
        cmd.Parameters.AddWithValue("@modelo", txtmodelo.Text)
        cmd.Parameters.AddWithValue("@marca", cbxmarca.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpa()
        lista()
        codigo()
    End Sub

    Private Sub codigo()
        Dim max As Integer = 0
        Dim ds1 As New DataSet
        Dim dt1 As New DataTable
        ds1.Tables.Add(dt1)
        Dim da1 As New MySqlDataAdapter("SELECT * FROM ratos", connection)
        da1.Fill(dt1)

        For i = 0 To ds1.Tables(0).Rows.Count - 1
            Label6.Text = ds1.Tables(0).Rows(i).Item(0)
            If Val(Label6.Text) > max Then
                max = Val(Label6.Text)
            End If
        Next
        Label6.Text = (max + 1).ToString
    End Sub

    Private Sub limpa()
        txtnome.Text = ""
        cbxInterface.Text = ""
        txtmodelo.Text = ""
        cbxmarca.Text = ""
        codigo()
    End Sub

    Private Sub lista()
        ListView1.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM ratos", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            ListView1.Items.Add(coluna.Item(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
        Next
    End Sub

    Private Sub Rato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxpesquisa.Text = "Nome"
        codigo()
        lista()
        Rato_aberto = True
    End Sub

    Private Sub Rato_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Rato_aberto = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "delete from ratos where RA_ID=@id;"
        cmd.Parameters.AddWithValue("@id", Label6.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpa()
        lista()
        codigo()
    End Sub

    Private Sub listar()
        Label6.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
        txtnome.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
        cbxInterface.Text = ListView1.SelectedItems.Item(0).SubItems(2).Text
        cbxmarca.Text = ListView1.SelectedItems.Item(0).SubItems(3).Text
        txtmodelo.Text = ListView1.SelectedItems.Item(0).SubItems(4).Text
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

    Private Function marca_ja_existe(marca As String) As Boolean
        Dim cmd As MySqlCommand
        cmd = connection.CreateCommand()
        cmd.CommandText = "Select count(*) from ratos where RA_ID = @ID"
        cmd.Parameters.AddWithValue("@ID", marca)

        connection.Open()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        connection.Close()
        Return count > 0
    End Function

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "update ratos set RA_Nome=@nome, RA_Interface=@interface, RA_Modelo=@modelo, RA_Marca=@marca where RA_ID=@id;"
        cmd.Parameters.AddWithValue("@id", Label6.Text)
        cmd.Parameters.AddWithValue("@nome", txtnome.Text)
        cmd.Parameters.AddWithValue("@interface", cbxInterface.Text)
        cmd.Parameters.AddWithValue("@modelo", txtmodelo.Text)
        cmd.Parameters.AddWithValue("@marca", cbxmarca.Text)
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

    Private Sub txtpesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtpesquisa.TextChanged
        If cbxpesquisa.Text = "ID" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM ratos where RA_ID Like '%" & txtpesquisa.Text & "%' Order By RA_ID", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
            Next
        ElseIf cbxpesquisa.Text = "Nome" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM ratos where RA_Nome Like '%" & txtpesquisa.Text & "%' Order By RA_Nome", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
            Next
        ElseIf cbxpesquisa.Text = "Interface" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM ratos where RA_Interface Like '%" & txtpesquisa.Text & "%' Order By RA_Interface", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
            Next
        ElseIf cbxpesquisa.Text = "Marca" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM ratos where RA_Marca Like '%" & txtpesquisa.Text & "%' Order By RA_Marca", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
            Next
        ElseIf cbxpesquisa.Text = "modelo" Then
            ListView1.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM ratos where RA_Modelo Like '%" & txtpesquisa.Text & "%' Order By RA_Modelo", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                ListView1.Items.Add(coluna.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(coluna.Item(4))
            Next
        End If
    End Sub

    Private Sub cbxInterface_Click(sender As Object, e As EventArgs) Handles cbxInterface.Click
        cbxInterface.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM interface", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            cbxInterface.Items.Add(coluna.Item(0))
        Next
    End Sub
End Class