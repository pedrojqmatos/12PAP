Imports MySql.Data.MySqlClient
Public Class frmClientes
    Dim str As String = "server = localhost; port = 3306; username = root; password =; database = sandranails; SslMode = none"
    Dim connection As New MySqlConnection(str)
    Dim itemcoll(100) As String

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaClientes()
        txtProcura.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PicAdicionar_Click(sender As Object, e As EventArgs) Handles PicAdicionar.Click
        Dim cmd As MySqlCommand
        connection.Open()
        If Not txtEmail.Text.Contains("@") Then
            MessageBox.Show(" O e-mail inserido é inválido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ListaClientes()
            connection.Close()
            Return
        End If

        If ja_existe_email(txtEmail.Text) Then
            MessageBox.Show("O e-mail já existe. Por favor insira um e-mail diferente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            connection.Close()
            Return
        End If

        If ja_existe_telemóvel(MTB_Telemovel.Text) Then
            MessageBox.Show("O número de telemóvel inserido já existe. Por favor insira um número diferente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            connection.Close()
            Return
        End If

        If ja_existe_nif(MTBnif.Text) Then
            MessageBox.Show("O nif inserido já existe. Por favor insira um nif válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            connection.Close()
            Return
        End If

        cmd = connection.CreateCommand
        cmd.CommandText = "Insert into tabela_dos_clientes (CL_NOME, CL_ENDERECO_DE_EMAIL, CL_NUMERO_TELEMOVEL, CL_GENERO, CL_DATA_NASCIMENTO, CL_NIF) values (@cl_nome, @cl_email, @cl_telemovel, @cl_genero, @cl_data_nascimento, @cl_nif);"
        cmd.Parameters.AddWithValue("@cl_nome", txtNome.Text)
        cmd.Parameters.AddWithValue("@cl_email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@cl_telemovel", MTB_Telemovel.Text)
        cmd.Parameters.AddWithValue("@cl_genero", CMBGenero.Text)
        cmd.Parameters.AddWithValue("@cl_data_nascimento", DTPdata.Text)
        cmd.Parameters.AddWithValue("@cl_nif", MTBnif.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpacampos()
        ListaClientes()
    End Sub

    Private Sub PicRemover_Click(sender As Object, e As EventArgs) Handles PicRemover.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "delete from tabela_dos_clientes where ID_CLIENTE = @id_cliente;"
        cmd.Parameters.AddWithValue("@id_cliente", txtCOD.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpacampos()
        ListaClientes()
    End Sub

    Private Sub PicEditar_Click(sender As Object, e As EventArgs) Handles PicEditar.Click
        Dim cmd As MySqlCommand
        connection.Open()
        If Not txtEmail.Text.Contains("@") Then
            MessageBox.Show(" O e-mail inserido é inválido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ListaClientes()
            Return
        End If

        cmd = connection.CreateCommand()
        cmd.CommandText = "update tabela_dos_clientes set CL_NOME = @cl_nome, CL_ENDERECO_DE_EMAIL = @cl_email, CL_NUMERO_TELEMOVEL = @cl_telemovel, CL_GENERO = @cl_genero, CL_DATA_NASCIMENTO = @cl_data_nascimento, CL_NIF = @cl_nif where ID_CLIENTE = @cl_cod;"
        cmd.Parameters.AddWithValue("@cl_cod", txtCOD.Text)
        cmd.Parameters.AddWithValue("@cl_nome", txtNome.Text)
        cmd.Parameters.AddWithValue("@cl_email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@cl_telemovel", MTB_Telemovel.Text)
        cmd.Parameters.AddWithValue("@cl_genero", CMBGenero.Text)
        cmd.Parameters.AddWithValue("@cl_data_nascimento", DTPdata.Text)
        cmd.Parameters.AddWithValue("@cl_nif", MTBnif.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpacampos()
        ListaClientes()
    End Sub
    Private Sub PicLimpar_Click(sender As Object, e As EventArgs) Handles PicLimpar.Click
        limpacampos()
    End Sub

    Private Sub limpacampos()
        txtNome.Text = ""
        txtEmail.Text = ""
        MTB_Telemovel.Text = ""
        CMBGenero.Text = ""
        DTPdata.Text = ""
        MTBnif.Text = ""
        txtCOD.Text = ""
    End Sub

    Private Sub ListaClientes()
        Dim cmd As MySqlCommand
        Dim ds As DataSet
        Dim da As MySqlDataAdapter
        ListCLientes.Items.Clear()
        connection = New MySqlConnection("server = localhost; port = 3306; username = root; password =; database = sandranails; SslMode = none")
        Dim strQ As String = String.Empty
        strQ = "SELECT * FROM tabela_dos_clientes"
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
            Me.ListCLientes.Items.Add(lvi)
        Next
    End Sub

    Private Sub PICsair_Click(sender As Object, e As EventArgs) Handles PICsair.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub Listar_Dados()
        txtCOD.Text = ListCLientes.SelectedItems.Item(0).SubItems(0).Text
        txtNome.Text = ListCLientes.SelectedItems.Item(0).SubItems(1).Text
        txtEmail.Text = ListCLientes().SelectedItems.Item(0).SubItems(2).Text
        MTB_Telemovel.Text = ListCLientes.SelectedItems.Item(0).SubItems(3).Text
        CMBGenero.Text = ListCLientes.SelectedItems.Item(0).SubItems(4).Text
        DTPdata.Text = ListCLientes.SelectedItems.Item(0).SubItems(5).Text
        MTBnif.Text = ListCLientes.SelectedItems.Item(0).SubItems(6).Text
    End Sub

    Private Sub ListClientes_Click(sender As Object, e As EventArgs) Handles ListCLientes.Click
        Listar_Dados()
    End Sub

    Private Sub CMBGenero_Click(sender As Object, e As EventArgs) Handles CMBGenero.Click
        CMBGenero.Items.Clear()
        CMBGenero.Items.Add("Male")
        CMBGenero.Items.Add("Female")
        CMBGenero.Items.Add("Outros")
    End Sub

    Private Sub txtProcura_TextChanged(sender As Object, e As EventArgs) Handles txtProcura.TextChanged
        ListCLientes.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * from tabela_dos_clientes where CL_NOME LIKE  '%" & txtProcura.Text & "%' Order By ID_CLIENTE", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            ListCLientes.Items.Add(coluna.Item(0))
            ListCLientes.Items(ListCLientes.Items.Count - 1).SubItems.Add(coluna.Item(1))
            ListCLientes.Items(ListCLientes.Items.Count - 1).SubItems.Add(coluna.Item(2))
            ListCLientes.Items(ListCLientes.Items.Count - 1).SubItems.Add(coluna.Item(3))
            ListCLientes.Items(ListCLientes.Items.Count - 1).SubItems.Add(coluna.Item(4))
            ListCLientes.Items(ListCLientes.Items.Count - 1).SubItems.Add(coluna.Item(5))
            ListCLientes.Items(ListCLientes.Items.Count - 1).SubItems.Add(coluna.Item(6))
        Next
    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function ja_existe_email(email As String) As Boolean
        Dim cmd As MySqlCommand
        cmd = connection.CreateCommand()
        cmd.CommandText = "SELECT COUNT(*) FROM tabela_dos_clientes WHERE CL_ENDERECO_DE_EMAIL = @email"
        cmd.Parameters.AddWithValue("@email", email)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Function ja_existe_telemóvel(telemovel As String) As Boolean
        Dim cmd As MySqlCommand
        cmd = connection.CreateCommand()
        cmd.CommandText = "SELECT COUNT(*) FROM tabela_dos_clientes WHERE CL_NUMERO_TELEMOVEL = @telemóvel"
        cmd.Parameters.AddWithValue("@telemóvel", telemovel)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Function ja_existe_nif(nif As String) As Boolean
        Dim cmd As MySqlCommand
        cmd = connection.CreateCommand()
        cmd.CommandText = "SELECT COUNT(*) FROM tabela_dos_clientes WHERE CL_NIF = @nif"
        cmd.Parameters.AddWithValue("@nif", nif)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.Hide()
        txtProcura.Show()
        PictureBox8.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox7.Show()
        txtProcura.Hide()
        PictureBox8.Hide()
    End Sub
End Class
