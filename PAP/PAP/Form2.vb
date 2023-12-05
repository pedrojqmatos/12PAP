Imports MySql.Data.MySqlClient
Public Class Form2
    Dim str As String = "DataSource=localhost;port=3306;username=root;password=;database=PAP;SslMode=none"
    Dim connection As New MySqlConnection(str)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lista()
        Interface_aberto = True
    End Sub

    Private Sub lista()
        ListView1.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM interface", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            ListView1.Items.Add(coluna.Item(0))
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If marca_ja_existe(TextBox1.Text) Then
            MessageBox.Show("Essa interface já existe na tabela!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim cmd As MySqlCommand
        connection.Open()

        cmd = connection.CreateCommand
        cmd.CommandText = "insert into interface(Co_Rato)values(@rato);"
        cmd.Parameters.AddWithValue("@rato", TextBox1.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        lista()
        TextBox1.Text = ""
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "delete from interface where Co_Rato=@rato;"
        cmd.Parameters.AddWithValue("@rato", TextBox1.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        lista()
        TextBox1.Text = ""
    End Sub

    Private Function marca_ja_existe(marca As String) As Boolean
        Dim cmd As MySqlCommand
        cmd = connection.CreateCommand()
        cmd.CommandText = "Select count(*) from interface where Co_Rato = @rato"
        cmd.Parameters.AddWithValue("@rato", marca)

        connection.Open()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        connection.Close()
        Return count > 0
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ListView1.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("Select * FROM interface where Co_Rato Like '%" & TextBox2.Text & "%' Order By Co_Rato", connection)
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

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Interface_aberto = False
    End Sub
End Class