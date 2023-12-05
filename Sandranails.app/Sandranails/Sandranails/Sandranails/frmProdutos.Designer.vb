<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCOD = New System.Windows.Forms.TextBox()
        Me.txtProcura = New System.Windows.Forms.TextBox()
        Me.lblProcurar = New System.Windows.Forms.Label()
        Me.ListProdutos = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Designação = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Marca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Código = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fornecedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Stock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Validade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtDesignacao = New System.Windows.Forms.TextBox()
        Me.lblDesignacao = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblCódigo = New System.Windows.Forms.Label()
        Me.lblCor = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.lblValidade = New System.Windows.Forms.Label()
        Me.DTPValidade = New System.Windows.Forms.DateTimePicker()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.CMBCor = New System.Windows.Forms.ComboBox()
        Me.CMBCodigo_cor = New System.Windows.Forms.ComboBox()
        Me.lblAdicStock = New System.Windows.Forms.Label()
        Me.MTBAdicionar_Stock = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PICAdicionar_Stock = New System.Windows.Forms.PictureBox()
        Me.PicRemover = New System.Windows.Forms.PictureBox()
        Me.PicEditar = New System.Windows.Forms.PictureBox()
        Me.PicAdicionar = New System.Windows.Forms.PictureBox()
        Me.PicLimpar = New System.Windows.Forms.PictureBox()
        Me.PICsair = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICAdicionar_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRemover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAdicionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLimpar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICsair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCOD
        '
        Me.txtCOD.Location = New System.Drawing.Point(748, 73)
        Me.txtCOD.Name = "txtCOD"
        Me.txtCOD.Size = New System.Drawing.Size(100, 20)
        Me.txtCOD.TabIndex = 63
        Me.txtCOD.Visible = False
        '
        'txtProcura
        '
        Me.txtProcura.BackColor = System.Drawing.SystemColors.Menu
        Me.txtProcura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcura.Location = New System.Drawing.Point(311, 362)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.Size = New System.Drawing.Size(462, 24)
        Me.txtProcura.TabIndex = 62
        '
        'lblProcurar
        '
        Me.lblProcurar.AutoSize = True
        Me.lblProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcurar.Location = New System.Drawing.Point(144, 365)
        Me.lblProcurar.Name = "lblProcurar"
        Me.lblProcurar.Size = New System.Drawing.Size(79, 18)
        Me.lblProcurar.TabIndex = 61
        Me.lblProcurar.Text = "Procurar:"
        '
        'ListProdutos
        '
        Me.ListProdutos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Designação, Me.Marca, Me.Cor, Me.Código, Me.Fornecedor, Me.Stock, Me.Validade})
        Me.ListProdutos.FullRowSelect = True
        Me.ListProdutos.GridLines = True
        Me.ListProdutos.HideSelection = False
        Me.ListProdutos.Location = New System.Drawing.Point(147, 408)
        Me.ListProdutos.Name = "ListProdutos"
        Me.ListProdutos.Size = New System.Drawing.Size(664, 226)
        Me.ListProdutos.TabIndex = 60
        Me.ListProdutos.UseCompatibleStateImageBehavior = False
        Me.ListProdutos.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 40
        '
        'Designação
        '
        Me.Designação.Text = "Designação"
        Me.Designação.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Designação.Width = 110
        '
        'Marca
        '
        Me.Marca.Text = "Marca"
        Me.Marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Marca.Width = 110
        '
        'Cor
        '
        Me.Cor.Text = "Cor"
        Me.Cor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cor.Width = 110
        '
        'Código
        '
        Me.Código.Text = "Código"
        Me.Código.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Código.Width = 110
        '
        'Fornecedor
        '
        Me.Fornecedor.Text = "Fornecedor"
        Me.Fornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fornecedor.Width = 110
        '
        'Stock
        '
        Me.Stock.Text = "Stock"
        Me.Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Stock.Width = 110
        '
        'Validade
        '
        Me.Validade.Text = "Validade"
        Me.Validade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Validade.Width = 110
        '
        'txtDesignacao
        '
        Me.txtDesignacao.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDesignacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignacao.ForeColor = System.Drawing.Color.Black
        Me.txtDesignacao.Location = New System.Drawing.Point(354, 150)
        Me.txtDesignacao.Name = "txtDesignacao"
        Me.txtDesignacao.Size = New System.Drawing.Size(161, 24)
        Me.txtDesignacao.TabIndex = 54
        '
        'lblDesignacao
        '
        Me.lblDesignacao.AutoSize = True
        Me.lblDesignacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignacao.Location = New System.Drawing.Point(144, 153)
        Me.lblDesignacao.Name = "lblDesignacao"
        Me.lblDesignacao.Size = New System.Drawing.Size(102, 18)
        Me.lblDesignacao.TabIndex = 52
        Me.lblDesignacao.Text = "Designação:"
        '
        'txtmarca
        '
        Me.txtmarca.BackColor = System.Drawing.SystemColors.Menu
        Me.txtmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarca.Location = New System.Drawing.Point(353, 186)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(161, 24)
        Me.txtmarca.TabIndex = 69
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(144, 189)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(60, 18)
        Me.lblMarca.TabIndex = 68
        Me.lblMarca.Text = "Marca:"
        '
        'lblCódigo
        '
        Me.lblCódigo.AutoSize = True
        Me.lblCódigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCódigo.Location = New System.Drawing.Point(719, 230)
        Me.lblCódigo.Name = "lblCódigo"
        Me.lblCódigo.Size = New System.Drawing.Size(67, 18)
        Me.lblCódigo.TabIndex = 70
        Me.lblCódigo.Text = "Código:"
        '
        'lblCor
        '
        Me.lblCor.AutoSize = True
        Me.lblCor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCor.Location = New System.Drawing.Point(719, 193)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(41, 18)
        Me.lblCor.TabIndex = 72
        Me.lblCor.Text = "Cor:"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.BackColor = System.Drawing.SystemColors.Menu
        Me.txtFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFornecedor.Location = New System.Drawing.Point(354, 229)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(161, 24)
        Me.txtFornecedor.TabIndex = 75
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornecedor.Location = New System.Drawing.Point(144, 232)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(100, 18)
        Me.lblFornecedor.TabIndex = 74
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'lblValidade
        '
        Me.lblValidade.AutoSize = True
        Me.lblValidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidade.Location = New System.Drawing.Point(719, 154)
        Me.lblValidade.Name = "lblValidade"
        Me.lblValidade.Size = New System.Drawing.Size(76, 18)
        Me.lblValidade.TabIndex = 76
        Me.lblValidade.Text = "Validade:"
        '
        'DTPValidade
        '
        Me.DTPValidade.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.DTPValidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPValidade.Location = New System.Drawing.Point(896, 151)
        Me.DTPValidade.Name = "DTPValidade"
        Me.DTPValidade.Size = New System.Drawing.Size(200, 24)
        Me.DTPValidade.TabIndex = 78
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(144, 272)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(57, 18)
        Me.lblStock.TabIndex = 79
        Me.lblStock.Text = "Stock:"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.SystemColors.Menu
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(353, 269)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(161, 24)
        Me.txtStock.TabIndex = 80
        '
        'CMBCor
        '
        Me.CMBCor.BackColor = System.Drawing.SystemColors.Menu
        Me.CMBCor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCor.FormattingEnabled = True
        Me.CMBCor.Location = New System.Drawing.Point(927, 190)
        Me.CMBCor.Name = "CMBCor"
        Me.CMBCor.Size = New System.Drawing.Size(169, 26)
        Me.CMBCor.TabIndex = 81
        '
        'CMBCodigo_cor
        '
        Me.CMBCodigo_cor.BackColor = System.Drawing.SystemColors.Menu
        Me.CMBCodigo_cor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCodigo_cor.FormattingEnabled = True
        Me.CMBCodigo_cor.Location = New System.Drawing.Point(927, 227)
        Me.CMBCodigo_cor.Name = "CMBCodigo_cor"
        Me.CMBCodigo_cor.Size = New System.Drawing.Size(169, 26)
        Me.CMBCodigo_cor.TabIndex = 82
        '
        'lblAdicStock
        '
        Me.lblAdicStock.AutoSize = True
        Me.lblAdicStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdicStock.Location = New System.Drawing.Point(167, 300)
        Me.lblAdicStock.Name = "lblAdicStock"
        Me.lblAdicStock.Size = New System.Drawing.Size(87, 18)
        Me.lblAdicStock.TabIndex = 84
        Me.lblAdicStock.Text = "Adic. Stock:"
        '
        'MTBAdicionar_Stock
        '
        Me.MTBAdicionar_Stock.BackColor = System.Drawing.SystemColors.Menu
        Me.MTBAdicionar_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTBAdicionar_Stock.Location = New System.Drawing.Point(260, 297)
        Me.MTBAdicionar_Stock.Mask = "000"
        Me.MTBAdicionar_Stock.Name = "MTBAdicionar_Stock"
        Me.MTBAdicionar_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MTBAdicionar_Stock.Size = New System.Drawing.Size(27, 24)
        Me.MTBAdicionar_Stock.TabIndex = 85
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Sandranails.My.Resources.Resources.codigo_de_barras_com_simbolo_de_lupa
        Me.PictureBox9.Location = New System.Drawing.Point(681, 227)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 94
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Sandranails.My.Resources.Resources.amostra_de_tinta
        Me.PictureBox8.Location = New System.Drawing.Point(681, 190)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 93
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Sandranails.My.Resources.Resources.expirado
        Me.PictureBox7.Location = New System.Drawing.Point(681, 151)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 92
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Sandranails.My.Resources.Resources.estoque
        Me.PictureBox6.Location = New System.Drawing.Point(106, 269)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 91
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Sandranails.My.Resources.Resources.correio
        Me.PictureBox5.Location = New System.Drawing.Point(106, 229)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 90
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sandranails.My.Resources.Resources.marca
        Me.PictureBox3.Location = New System.Drawing.Point(106, 186)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 89
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Sandranails.My.Resources.Resources.assinatura
        Me.PictureBox4.Location = New System.Drawing.Point(106, 150)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 88
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Sandranails.My.Resources.Resources.botao_excluir
        Me.PictureBox2.Location = New System.Drawing.Point(779, 362)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Sandranails.My.Resources.Resources.lupa
        Me.PictureBox1.Location = New System.Drawing.Point(779, 362)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'PICAdicionar_Stock
        '
        Me.PICAdicionar_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PICAdicionar_Stock.Image = Global.Sandranails.My.Resources.Resources.adicionar
        Me.PICAdicionar_Stock.Location = New System.Drawing.Point(293, 297)
        Me.PICAdicionar_Stock.Name = "PICAdicionar_Stock"
        Me.PICAdicionar_Stock.Size = New System.Drawing.Size(30, 24)
        Me.PICAdicionar_Stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICAdicionar_Stock.TabIndex = 83
        Me.PICAdicionar_Stock.TabStop = False
        '
        'PicRemover
        '
        Me.PicRemover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRemover.Image = Global.Sandranails.My.Resources.Resources.apagar
        Me.PicRemover.Location = New System.Drawing.Point(844, 596)
        Me.PicRemover.Name = "PicRemover"
        Me.PicRemover.Size = New System.Drawing.Size(39, 38)
        Me.PicRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicRemover.TabIndex = 59
        Me.PicRemover.TabStop = False
        '
        'PicEditar
        '
        Me.PicEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicEditar.Image = Global.Sandranails.My.Resources.Resources.editar
        Me.PicEditar.Location = New System.Drawing.Point(844, 500)
        Me.PicEditar.Name = "PicEditar"
        Me.PicEditar.Size = New System.Drawing.Size(39, 38)
        Me.PicEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicEditar.TabIndex = 58
        Me.PicEditar.TabStop = False
        '
        'PicAdicionar
        '
        Me.PicAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicAdicionar.Image = Global.Sandranails.My.Resources.Resources.adicionar
        Me.PicAdicionar.Location = New System.Drawing.Point(844, 408)
        Me.PicAdicionar.Name = "PicAdicionar"
        Me.PicAdicionar.Size = New System.Drawing.Size(39, 38)
        Me.PicAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicAdicionar.TabIndex = 57
        Me.PicAdicionar.TabStop = False
        '
        'PicLimpar
        '
        Me.PicLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLimpar.Image = Global.Sandranails.My.Resources.Resources.limpar
        Me.PicLimpar.Location = New System.Drawing.Point(1057, 259)
        Me.PicLimpar.Name = "PicLimpar"
        Me.PicLimpar.Size = New System.Drawing.Size(39, 38)
        Me.PicLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLimpar.TabIndex = 56
        Me.PicLimpar.TabStop = False
        '
        'PICsair
        '
        Me.PICsair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PICsair.Image = Global.Sandranails.My.Resources.Resources.sair
        Me.PICsair.Location = New System.Drawing.Point(69, 44)
        Me.PICsair.Name = "PICsair"
        Me.PICsair.Size = New System.Drawing.Size(39, 38)
        Me.PICsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICsair.TabIndex = 55
        Me.PICsair.TabStop = False
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 749)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MTBAdicionar_Stock)
        Me.Controls.Add(Me.lblAdicStock)
        Me.Controls.Add(Me.PICAdicionar_Stock)
        Me.Controls.Add(Me.CMBCodigo_cor)
        Me.Controls.Add(Me.CMBCor)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.DTPValidade)
        Me.Controls.Add(Me.lblValidade)
        Me.Controls.Add(Me.txtFornecedor)
        Me.Controls.Add(Me.lblFornecedor)
        Me.Controls.Add(Me.lblCor)
        Me.Controls.Add(Me.lblCódigo)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.txtCOD)
        Me.Controls.Add(Me.txtProcura)
        Me.Controls.Add(Me.lblProcurar)
        Me.Controls.Add(Me.ListProdutos)
        Me.Controls.Add(Me.PicRemover)
        Me.Controls.Add(Me.PicEditar)
        Me.Controls.Add(Me.PicAdicionar)
        Me.Controls.Add(Me.PicLimpar)
        Me.Controls.Add(Me.PICsair)
        Me.Controls.Add(Me.txtDesignacao)
        Me.Controls.Add(Me.lblDesignacao)
        Me.Name = "frmProdutos"
        Me.Text = "frmProdutos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICAdicionar_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRemover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAdicionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLimpar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICsair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCOD As TextBox
    Friend WithEvents txtProcura As TextBox
    Friend WithEvents lblProcurar As Label
    Friend WithEvents ListProdutos As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Marca As ColumnHeader
    Friend WithEvents PicRemover As PictureBox
    Friend WithEvents PicEditar As PictureBox
    Friend WithEvents PicAdicionar As PictureBox
    Friend WithEvents PicLimpar As PictureBox
    Friend WithEvents PICsair As PictureBox
    Friend WithEvents txtDesignacao As TextBox
    Friend WithEvents lblDesignacao As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents Designação As ColumnHeader
    Friend WithEvents lblCódigo As Label
    Friend WithEvents lblCor As Label
    Friend WithEvents txtFornecedor As TextBox
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents lblValidade As Label
    Friend WithEvents Código As ColumnHeader
    Friend WithEvents Cor As ColumnHeader
    Friend WithEvents Fornecedor As ColumnHeader
    Friend WithEvents Validade As ColumnHeader
    Friend WithEvents DTPValidade As DateTimePicker
    Friend WithEvents Stock As ColumnHeader
    Friend WithEvents lblStock As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents CMBCor As ComboBox
    Friend WithEvents CMBCodigo_cor As ComboBox
    Friend WithEvents PICAdicionar_Stock As PictureBox
    Friend WithEvents lblAdicStock As Label
    Friend WithEvents MTBAdicionar_Stock As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
End Class
