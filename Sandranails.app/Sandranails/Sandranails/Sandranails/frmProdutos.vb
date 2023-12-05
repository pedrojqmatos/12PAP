Imports MySql.Data.MySqlClient
Public Class frmProdutos
    Dim str As String = "server = localhost; port = 3306; username = root; password =; database = sandranails; SslMode = none"
    Dim connection As New MySqlConnection(str)
    Dim itemcoll(100) As String

    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaProdutos()
        txtProcura.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub PicAdicionar_Click(sender As Object, e As EventArgs) Handles PicAdicionar.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand
        cmd.CommandText = "Insert into tabela_dos_produtos (PR_DESIGNACAO, PR_MARCA, PR_COR, PR_CODIGO, PR_FORNECEDOR, PR_STOCK, PR_VALIDADE) values (@pr_designacao, @pr_marca, @pr_cor, @pr_codigo, @pr_fornecedor, @pr_stock, @pr_validade);"
        cmd.Parameters.AddWithValue("@pr_designacao", txtDesignacao.Text)
        cmd.Parameters.AddWithValue("@pr_marca", txtmarca.Text)
        cmd.Parameters.AddWithValue("@pr_cor", CMBCor.Text)
        cmd.Parameters.AddWithValue("@pr_codigo", CMBCodigo_cor.Text)
        cmd.Parameters.AddWithValue("@pr_fornecedor", txtFornecedor.Text)
        cmd.Parameters.AddWithValue("@pr_stock", txtStock.Text)
        cmd.Parameters.AddWithValue("@pr_validade", DTPValidade.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpacampos()
        ListaProdutos()
    End Sub

    Private Sub PicRemover_Click(sender As Object, e As EventArgs) Handles PicRemover.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "delete from tabela_dos_produtos where ID_DO_PRODUTO = @id_produto;"
        cmd.Parameters.AddWithValue("@id_produto", txtCOD.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpacampos()
        ListaProdutos()
    End Sub

    Private Sub PicEditar_Click(sender As Object, e As EventArgs) Handles PicEditar.Click
        Dim cmd As MySqlCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandText = "update tabela_dos_produtos set PR_DESIGNACAO = @pr_designacao, PR_MARCA = @pr_marca, PR_COR = @pr_cor, PR_CODIGO = @pr_codigo, PR_FORNECEDOR = @pr_fornecedor, PR_STOCK = @pr_stock, PR_VALIDADE = @pr_validade where ID_DO_PRODUTO = @pr_cod;"
        cmd.Parameters.AddWithValue("@pr_cod", txtCOD.Text)
        cmd.Parameters.AddWithValue("@pr_designacao", txtDesignacao.Text)
        cmd.Parameters.AddWithValue("@pr_marca", txtmarca.Text)
        cmd.Parameters.AddWithValue("@pr_cor", CMBCor.Text)
        cmd.Parameters.AddWithValue("@pr_codigo", CMBCodigo_cor.Text)
        cmd.Parameters.AddWithValue("@pr_fornecedor", txtFornecedor.Text)
        cmd.Parameters.AddWithValue("@pr_stock", txtStock.Text)
        cmd.Parameters.AddWithValue("@pr_validade", DTPValidade.Text)
        cmd.ExecuteNonQuery()
        connection.Close()
        limpacampos()
        ListaProdutos()
    End Sub
    Private Sub PicLimpar_Click(sender As Object, e As EventArgs) Handles PicLimpar.Click
        limpacampos()
    End Sub

    Private Sub limpacampos()
        txtDesignacao.Text = ""
        txtmarca.Text = ""
        CMBCodigo_cor.Text = ""
        CMBCor.Text = ""
        txtCOD.Text = ""
        txtFornecedor.Text = ""
        txtStock.Text = ""
        DTPValidade.Text = ""
        MTBAdicionar_Stock.Text = ""
    End Sub
    Private Sub ListaProdutos()
        Dim cmd As MySqlCommand
        Dim ds As DataSet
        Dim da As MySqlDataAdapter
        ListProdutos.Items.Clear()
        connection = New MySqlConnection("server = localhost; port = 3306; username = root; password =; database = sandranails; SslMode = none")
        Dim strQ As String = String.Empty
        strQ = "SELECT * FROM tabela_dos_produtos"
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
            Me.ListProdutos.Items.Add(lvi)
        Next
    End Sub
    Private Sub PICsair_Click(sender As Object, e As EventArgs) Handles PICsair.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Listar_Dados()
        txtCOD.Text = ListProdutos.SelectedItems.Item(0).SubItems(0).Text
        txtDesignacao.Text = ListProdutos.SelectedItems.Item(0).SubItems(1).Text
        txtmarca.Text = ListProdutos.SelectedItems.Item(0).SubItems(2).Text
        CMBCor.Text = ListProdutos.SelectedItems.Item(0).SubItems(3).Text
        CMBCodigo_cor.Text = ListProdutos.SelectedItems.Item(0).SubItems(4).Text
        txtFornecedor.Text = ListProdutos.SelectedItems.Item(0).SubItems(5).Text
        txtStock.Text = ListProdutos.SelectedItems.Item(0).SubItems(6).Text
        DTPValidade.Text = ListProdutos.SelectedItems.Item(0).SubItems(7).Text
    End Sub
    Private Sub ListProdutos_Click(sender As Object, e As EventArgs) Handles ListProdutos.Click
        Listar_Dados()
    End Sub

    Private Sub txtProcura_TextChanged(sender As Object, e As EventArgs) Handles txtProcura.TextChanged
        ListProdutos.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * from tabela_dos_produtos where PR_DESIGNACAO LIKE  '%" & txtProcura.Text & "%' Order By ID_DO_PRODUTO", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            ListProdutos.Items.Add(coluna.Item(0))
            ListProdutos.Items(ListProdutos.Items.Count - 1).SubItems.Add(coluna.Item(1))
            ListProdutos.Items(ListProdutos.Items.Count - 1).SubItems.Add(coluna.Item(2))
            ListProdutos.Items(ListProdutos.Items.Count - 1).SubItems.Add(coluna.Item(3))
            ListProdutos.Items(ListProdutos.Items.Count - 1).SubItems.Add(coluna.Item(4))
            ListProdutos.Items(ListProdutos.Items.Count - 1).SubItems.Add(coluna.Item(5))
            ListProdutos.Items(ListProdutos.Items.Count - 1).SubItems.Add(coluna.Item(6))
            ListProdutos.Items(ListProdutos.Items.Count - 1).SubItems.Add(coluna.Item(7))
        Next
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs)
        If IsNumeric(CMBCodigo_cor.Text) = False And CMBCodigo_cor.Text <> "" Then
            CMBCodigo_cor.Text = ""
            MsgBox("Só aceita números!")
        End If
    End Sub
    Private Sub txtDesignacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesignacao.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CMBCor_Click(sender As Object, e As EventArgs) Handles CMBCor.Click
        Dim coresUnicas As New List(Of String)
        CMBCor.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New MySqlDataAdapter("SELECT * FROM tabela_dos_produtos", connection)
        da.Fill(dt)
        Dim coluna As DataRow
        For Each coluna In dt.Rows
            Dim cor As String = coluna.Item(3).ToString()
            If Not coresUnicas.Contains(cor) Then
                CMBCor.Items.Add(cor)
                coresUnicas.Add(cor)
            End If
        Next
    End Sub

    Private Sub CMBCor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBCor.SelectedIndexChanged
        Dim corSelecionada As String = CMBCor.SelectedItem.ToString()
        CMBCodigo_cor.Items.Clear()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim query As String = "SELECT PR_CODIGO FROM tabela_dos_produtos WHERE PR_COR = @cor"
        Dim da As New MySqlDataAdapter(query, connection)
        da.SelectCommand.Parameters.AddWithValue("@cor", corSelecionada)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                CMBCodigo_cor.Items.Add(row("PR_CODIGO").ToString())
            Next
            CMBCor.Text = corSelecionada
        End If
    End Sub

    Private Sub CMBCodigo_cor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBCodigo_cor.SelectedIndexChanged
        Dim selectedCodigo As String = CMBCodigo_cor.SelectedItem.ToString()
        Dim connectionString As String = "server = localhost; port = 3306; username = root; password =; database = sandranails; SslMode = none"
        Using connection As New MySqlConnection("server = localhost; port = 3306; username = root; password =; database = sandranails; SslMode = none")
            connection.Open()
            Dim query As String = "SELECT PR_COR FROM tabela_dos_produtos WHERE PR_CODIGO = @Codigo"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Codigo", selectedCodigo)
                Dim cor As String = TryCast(cmd.ExecuteScalar(), String)
                CMBCor.Text = cor
            End Using
        End Using
    End Sub

    Private Sub CMBCodigo_cor_Click(sender As Object, e As EventArgs) Handles CMBCodigo_cor.Click
        If CMBCor.Text = "" Then
            CMBCodigo_cor.Items.Clear()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New MySqlDataAdapter("SELECT * FROM tabela_dos_produtos", connection)
            da.Fill(dt)
            Dim coluna As DataRow
            For Each coluna In dt.Rows
                CMBCodigo_cor.Items.Add(coluna.Item(4))
            Next
        End If
    End Sub

    Private Sub PICAdicionar_Stock_Click(sender As Object, e As EventArgs) Handles PICAdicionar_Stock.Click
        Dim connectionString As String = "server = localhost; port = 3306; username = root; password =; database = sandranails; SslMode = none"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT PR_STOCK FROM tabela_dos_produtos WHERE ID_DO_PRODUTO = @pr_id"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@pr_id", txtCOD.Text)
                Dim currentStock As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Dim stockToAdd As Integer
                If Integer.TryParse(MTBAdicionar_Stock.Text, stockToAdd) Then
                    Dim newStock As Integer = currentStock + stockToAdd
                    query = "UPDATE tabela_dos_produtos SET PR_STOCK = @NewStock WHERE ID_DO_PRODUTO = @pr_id"
                    Using updateCmd As New MySqlCommand(query, connection)
                        updateCmd.Parameters.AddWithValue("@NewStock", newStock)
                        updateCmd.Parameters.AddWithValue("@pr_id", txtCOD.Text)
                        updateCmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Stock atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpacampos()
                    ListaProdutos()
                Else
                    MessageBox.Show("O valor a ser adicionado não é um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Hide()
        txtProcura.Show()
        PictureBox2.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Hide()
        PictureBox1.Show()
        txtProcura.Hide()
    End Sub
End Class