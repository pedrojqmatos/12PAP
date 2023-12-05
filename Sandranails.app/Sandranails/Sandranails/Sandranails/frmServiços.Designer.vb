<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiços
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
        Me.ListServicos = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Duracao_do_servico = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Preço = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtdesignacao = New System.Windows.Forms.TextBox()
        Me.lblDuracao_servico = New System.Windows.Forms.Label()
        Me.lblDesignacao = New System.Windows.Forms.Label()
        Me.MTBDuracao = New System.Windows.Forms.MaskedTextBox()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.MTBpreco = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicRemover = New System.Windows.Forms.PictureBox()
        Me.PicEditar = New System.Windows.Forms.PictureBox()
        Me.PicAdicionar = New System.Windows.Forms.PictureBox()
        Me.PicLimpar = New System.Windows.Forms.PictureBox()
        Me.PICsair = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRemover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAdicionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLimpar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICsair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCOD
        '
        Me.txtCOD.Location = New System.Drawing.Point(700, 59)
        Me.txtCOD.Name = "txtCOD"
        Me.txtCOD.Size = New System.Drawing.Size(100, 20)
        Me.txtCOD.TabIndex = 45
        Me.txtCOD.Visible = False
        '
        'txtProcura
        '
        Me.txtProcura.BackColor = System.Drawing.SystemColors.Menu
        Me.txtProcura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcura.Location = New System.Drawing.Point(833, 178)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.Size = New System.Drawing.Size(259, 24)
        Me.txtProcura.TabIndex = 44
        '
        'lblProcurar
        '
        Me.lblProcurar.AutoSize = True
        Me.lblProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcurar.Location = New System.Drawing.Point(697, 181)
        Me.lblProcurar.Name = "lblProcurar"
        Me.lblProcurar.Size = New System.Drawing.Size(79, 18)
        Me.lblProcurar.TabIndex = 43
        Me.lblProcurar.Text = "Procurar:"
        '
        'ListServicos
        '
        Me.ListServicos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nome, Me.Duracao_do_servico, Me.Preço})
        Me.ListServicos.FullRowSelect = True
        Me.ListServicos.GridLines = True
        Me.ListServicos.HideSelection = False
        Me.ListServicos.Location = New System.Drawing.Point(700, 225)
        Me.ListServicos.Name = "ListServicos"
        Me.ListServicos.Size = New System.Drawing.Size(430, 241)
        Me.ListServicos.TabIndex = 42
        Me.ListServicos.UseCompatibleStateImageBehavior = False
        Me.ListServicos.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 40
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nome.Width = 200
        '
        'Duracao_do_servico
        '
        Me.Duracao_do_servico.Text = "Duração do Serviço"
        Me.Duracao_do_servico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Duracao_do_servico.Width = 90
        '
        'Preço
        '
        Me.Preço.Text = "Preço"
        Me.Preço.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Preço.Width = 90
        '
        'txtdesignacao
        '
        Me.txtdesignacao.BackColor = System.Drawing.SystemColors.Menu
        Me.txtdesignacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesignacao.Location = New System.Drawing.Point(291, 186)
        Me.txtdesignacao.Name = "txtdesignacao"
        Me.txtdesignacao.Size = New System.Drawing.Size(228, 24)
        Me.txtdesignacao.TabIndex = 30
        '
        'lblDuracao_servico
        '
        Me.lblDuracao_servico.AutoSize = True
        Me.lblDuracao_servico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracao_servico.Location = New System.Drawing.Point(148, 228)
        Me.lblDuracao_servico.Name = "lblDuracao_servico"
        Me.lblDuracao_servico.Size = New System.Drawing.Size(163, 18)
        Me.lblDuracao_servico.TabIndex = 24
        Me.lblDuracao_servico.Text = "Duração do Serviço:"
        '
        'lblDesignacao
        '
        Me.lblDesignacao.AutoSize = True
        Me.lblDesignacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignacao.Location = New System.Drawing.Point(148, 189)
        Me.lblDesignacao.Name = "lblDesignacao"
        Me.lblDesignacao.Size = New System.Drawing.Size(102, 18)
        Me.lblDesignacao.TabIndex = 23
        Me.lblDesignacao.Text = "Designação:"
        '
        'MTBDuracao
        '
        Me.MTBDuracao.BackColor = System.Drawing.SystemColors.Menu
        Me.MTBDuracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTBDuracao.Location = New System.Drawing.Point(474, 225)
        Me.MTBDuracao.Mask = "00:00"
        Me.MTBDuracao.Name = "MTBDuracao"
        Me.MTBDuracao.Size = New System.Drawing.Size(45, 24)
        Me.MTBDuracao.TabIndex = 46
        Me.MTBDuracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MTBDuracao.ValidatingType = GetType(Date)
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreco.Location = New System.Drawing.Point(153, 272)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(58, 18)
        Me.lblPreco.TabIndex = 47
        Me.lblPreco.Text = "Preço:"
        '
        'MTBpreco
        '
        Me.MTBpreco.BackColor = System.Drawing.SystemColors.Menu
        Me.MTBpreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTBpreco.Location = New System.Drawing.Point(458, 266)
        Me.MTBpreco.Mask = "000.00€"
        Me.MTBpreco.Name = "MTBpreco"
        Me.MTBpreco.Size = New System.Drawing.Size(61, 24)
        Me.MTBpreco.TabIndex = 51
        Me.MTBpreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Sandranails.My.Resources.Resources.assinatura
        Me.PictureBox4.Location = New System.Drawing.Point(110, 186)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 56
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sandranails.My.Resources.Resources.euro
        Me.PictureBox3.Location = New System.Drawing.Point(110, 269)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Sandranails.My.Resources.Resources.ampulheta
        Me.PictureBox6.Location = New System.Drawing.Point(110, 225)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 54
        Me.PictureBox6.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Sandranails.My.Resources.Resources.botao_excluir
        Me.PictureBox2.Location = New System.Drawing.Point(1098, 178)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Sandranails.My.Resources.Resources.lupa
        Me.PictureBox1.Location = New System.Drawing.Point(1098, 178)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'PicRemover
        '
        Me.PicRemover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRemover.Image = Global.Sandranails.My.Resources.Resources.apagar
        Me.PicRemover.Location = New System.Drawing.Point(1157, 428)
        Me.PicRemover.Name = "PicRemover"
        Me.PicRemover.Size = New System.Drawing.Size(39, 38)
        Me.PicRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicRemover.TabIndex = 41
        Me.PicRemover.TabStop = False
        '
        'PicEditar
        '
        Me.PicEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicEditar.Image = Global.Sandranails.My.Resources.Resources.editar
        Me.PicEditar.Location = New System.Drawing.Point(1157, 323)
        Me.PicEditar.Name = "PicEditar"
        Me.PicEditar.Size = New System.Drawing.Size(39, 38)
        Me.PicEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicEditar.TabIndex = 40
        Me.PicEditar.TabStop = False
        '
        'PicAdicionar
        '
        Me.PicAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicAdicionar.Image = Global.Sandranails.My.Resources.Resources.adicionar
        Me.PicAdicionar.Location = New System.Drawing.Point(1157, 225)
        Me.PicAdicionar.Name = "PicAdicionar"
        Me.PicAdicionar.Size = New System.Drawing.Size(39, 38)
        Me.PicAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicAdicionar.TabIndex = 39
        Me.PicAdicionar.TabStop = False
        '
        'PicLimpar
        '
        Me.PicLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLimpar.Image = Global.Sandranails.My.Resources.Resources.limpar
        Me.PicLimpar.Location = New System.Drawing.Point(480, 308)
        Me.PicLimpar.Name = "PicLimpar"
        Me.PicLimpar.Size = New System.Drawing.Size(39, 38)
        Me.PicLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLimpar.TabIndex = 38
        Me.PicLimpar.TabStop = False
        '
        'PICsair
        '
        Me.PICsair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PICsair.Image = Global.Sandranails.My.Resources.Resources.sair
        Me.PICsair.Location = New System.Drawing.Point(64, 41)
        Me.PICsair.Name = "PICsair"
        Me.PICsair.Size = New System.Drawing.Size(39, 38)
        Me.PICsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICsair.TabIndex = 37
        Me.PICsair.TabStop = False
        '
        'frmServiços
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 749)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MTBpreco)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.MTBDuracao)
        Me.Controls.Add(Me.txtCOD)
        Me.Controls.Add(Me.txtProcura)
        Me.Controls.Add(Me.lblProcurar)
        Me.Controls.Add(Me.ListServicos)
        Me.Controls.Add(Me.PicRemover)
        Me.Controls.Add(Me.PicEditar)
        Me.Controls.Add(Me.PicAdicionar)
        Me.Controls.Add(Me.PicLimpar)
        Me.Controls.Add(Me.PICsair)
        Me.Controls.Add(Me.txtdesignacao)
        Me.Controls.Add(Me.lblDuracao_servico)
        Me.Controls.Add(Me.lblDesignacao)
        Me.Name = "frmServiços"
        Me.Text = "frmServiços"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ListServicos As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents PicRemover As PictureBox
    Friend WithEvents PicEditar As PictureBox
    Friend WithEvents PicAdicionar As PictureBox
    Friend WithEvents PicLimpar As PictureBox
    Friend WithEvents PICsair As PictureBox
    Friend WithEvents txtdesignacao As TextBox
    Friend WithEvents lblDuracao_servico As Label
    Friend WithEvents lblDesignacao As Label
    Friend WithEvents Duracao_do_servico As ColumnHeader
    Friend WithEvents MTBDuracao As MaskedTextBox
    Friend WithEvents Preço As ColumnHeader
    Friend WithEvents lblPreco As Label
    Friend WithEvents MTBpreco As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
