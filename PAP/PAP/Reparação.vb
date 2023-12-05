Imports MySql.Data.MySqlClient
Public Class Reparação
    Dim str As String = "DataSource=localhost;port=3306;username=root;password=;database=PAP;SslMode=none"
    Dim connection As New MySqlConnection(str)
    Private Sub lista()
        ListView1.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM tiporeparacao", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            ListView1.Items.Add(coluna.Item(0))
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lista()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If marca_ja_existe(TextBox1.Text) Then
            MessageBox.Show("Esse tipo de reparação já existe na tabela!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand
        cmd.CommandText = "insert into tiporeparacao(TR_TipoReparacao)values(@reparacao);"
        cmd.Parameters.AddWithValue("@reparacao", TextBox1.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        lista()
        TextBox1.Text = ""
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "delete from tiporeparacao where TR_TipoReparacao=@reparacao;"
        cmd.Parameters.AddWithValue("@reparacao", TextBox1.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        lista()
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ListView1.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM tiporeparacao where TR_TipoReparacao Like '%" & TextBox2.Text & "%' Order By TR_TipoReparacao", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            ListView1.Items.Add(coluna.Item(0))
        Next
    End Sub

    Private Sub listar()
        TextBox1.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        listar()
    End Sub
    Private Function marca_ja_existe(marca As String) As Boolean
        Dim cmd As MySqlCommand
        cmd = connection.CreateCommand()
        cmd.CommandText = "Select count(*) from tiporeparacao where TR_TipoReparacao = @tiporeparacao"
        cmd.Parameters.AddWithValue("@tiporeparacao", marca)

        connection.Open()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        connection.Close()
        Return count > 0
    End Function
End Class