<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelemovel = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblData_Nascimento = New System.Windows.Forms.Label()
        Me.lblNIF = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.MTB_Telemovel = New System.Windows.Forms.MaskedTextBox()
        Me.CMBGenero = New System.Windows.Forms.ComboBox()
        Me.DTPdata = New System.Windows.Forms.DateTimePicker()
        Me.MTBnif = New System.Windows.Forms.MaskedTextBox()
        Me.ListCLientes = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Telemóvel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Género = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data_Nascimento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NIF = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtProcura = New System.Windows.Forms.TextBox()
        Me.lblProcurar = New System.Windows.Forms.Label()
        Me.txtCOD = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicRemover = New System.Windows.Forms.PictureBox()
        Me.PicEditar = New System.Windows.Forms.PictureBox()
        Me.PicAdicionar = New System.Windows.Forms.PictureBox()
        Me.PicLimpar = New System.Windows.Forms.PictureBox()
        Me.PICsair = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRemover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAdicionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLimpar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICsair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(134, 143)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(58, 18)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(137, 186)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(55, 18)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email:"
        '
        'lblTelemovel
        '
        Me.lblTelemovel.AutoSize = True
        Me.lblTelemovel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelemovel.Location = New System.Drawing.Point(134, 225)
        Me.lblTelemovel.Name = "lblTelemovel"
        Me.lblTelemovel.Size = New System.Drawing.Size(90, 18)
        Me.lblTelemovel.TabIndex = 3
        Me.lblTelemovel.Text = "Telemóvel:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.Location = New System.Drawing.Point(628, 143)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(69, 18)
        Me.lblGenero.TabIndex = 4
        Me.lblGenero.Text = "Género:"
        '
        'lblData_Nascimento
        '
        Me.lblData_Nascimento.AutoSize = True
        Me.lblData_Nascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData_Nascimento.Location = New System.Drawing.Point(628, 185)
        Me.lblData_Nascimento.Name = "lblData_Nascimento"
        Me.lblData_Nascimento.Size = New System.Drawing.Size(166, 18)
        Me.lblData_Nascimento.TabIndex = 5
        Me.lblData_Nascimento.Text = "Data de Nascimento:"
        '
        'lblNIF
        '
        Me.lblNIF.AutoSize = True
        Me.lblNIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIF.Location = New System.Drawing.Point(628, 222)
        Me.lblNIF.Name = "lblNIF"
        Me.lblNIF.Size = New System.Drawing.Size(39, 18)
        Me.lblNIF.TabIndex = 6
        Me.lblNIF.Text = "NIF:"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(344, 140)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(161, 24)
        Me.txtNome.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Menu
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(304, 183)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 24)
        Me.txtEmail.TabIndex = 9
        '
        'MTB_Telemovel
        '
        Me.MTB_Telemovel.BackColor = System.Drawing.SystemColors.Menu
        Me.MTB_Telemovel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTB_Telemovel.Location = New System.Drawing.Point(412, 222)
        Me.MTB_Telemovel.Mask = " 000 000 000"
        Me.MTB_Telemovel.Name = "MTB_Telemovel"
        Me.MTB_Telemovel.Size = New System.Drawing.Size(93, 24)
        Me.MTB_Telemovel.TabIndex = 10
        Me.MTB_Telemovel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMBGenero
        '
        Me.CMBGenero.BackColor = System.Drawing.SystemColors.Menu
        Me.CMBGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBGenero.FormattingEnabled = True
        Me.CMBGenero.Location = New System.Drawing.Point(829, 140)
        Me.CMBGenero.Name = "CMBGenero"
        Me.CMBGenero.Size = New System.Drawing.Size(170, 26)
        Me.CMBGenero.TabIndex = 11
        '
        'DTPdata
        '
        Me.DTPdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPdata.Location = New System.Drawing.Point(799, 182)
        Me.DTPdata.Name = "DTPdata"
        Me.DTPdata.Size = New System.Drawing.Size(200, 24)
        Me.DTPdata.TabIndex = 12
        '
        'MTBnif
        '
        Me.MTBnif.BackColor = System.Drawing.SystemColors.Menu
        Me.MTBnif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTBnif.Location = New System.Drawing.Point(906, 219)
        Me.MTBnif.Mask = "000 000 000"
        Me.MTBnif.Name = "MTBnif"
        Me.MTBnif.Size = New System.Drawing.Size(93, 24)
        Me.MTBnif.TabIndex = 13
        Me.MTBnif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListCLientes
        '
        Me.ListCLientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nome, Me.Email, Me.Telemóvel, Me.Género, Me.Data_Nascimento, Me.NIF})
        Me.ListCLientes.FullRowSelect = True
        Me.ListCLientes.GridLines = True
        Me.ListCLientes.HideSelection = False
        Me.ListCLientes.Location = New System.Drawing.Point(140, 370)
        Me.ListCLientes.Name = "ListCLientes"
        Me.ListCLientes.Size = New System.Drawing.Size(696, 220)
        Me.ListCLientes.TabIndex = 19
        Me.ListCLientes.UseCompatibleStateImageBehavior = False
        Me.ListCLientes.View = System.Windows.Forms.View.Details
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
        Me.Nome.Width = 110
        '
        'Email
        '
        Me.Email.Text = "Email"
        Me.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Email.Width = 110
        '
        'Telemóvel
        '
        Me.Telemóvel.Text = "Telemóvel"
        Me.Telemóvel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Telemóvel.Width = 110
        '
        'Género
        '
        Me.Género.Text = "Género"
        Me.Género.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Género.Width = 110
        '
        'Data_Nascimento
        '
        Me.Data_Nascimento.Text = "Data de Nascimento"
        Me.Data_Nascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Data_Nascimento.Width = 110
        '
        'NIF
        '
        Me.NIF.Text = "NIF"
        Me.NIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NIF.Width = 110
        '
        'txtProcura
        '
        Me.txtProcura.BackColor = System.Drawing.SystemColors.Menu
        Me.txtProcura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcura.Location = New System.Drawing.Point(304, 328)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.Size = New System.Drawing.Size(494, 24)
        Me.txtProcura.TabIndex = 21
        '
        'lblProcurar
        '
        Me.lblProcurar.AutoSize = True
        Me.lblProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcurar.Location = New System.Drawing.Point(137, 331)
        Me.lblProcurar.Name = "lblProcurar"
        Me.lblProcurar.Size = New System.Drawing.Size(79, 18)
        Me.lblProcurar.TabIndex = 20
        Me.lblProcurar.Text = "Procurar:"
        '
        'txtCOD
        '
        Me.txtCOD.Location = New System.Drawing.Point(723, 40)
        Me.txtCOD.Name = "txtCOD"
        Me.txtCOD.Size = New System.Drawing.Size(100, 20)
        Me.txtCOD.TabIndex = 22
        Me.txtCOD.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Sandranails.My.Resources.Resources.nif
        Me.PictureBox6.Location = New System.Drawing.Point(590, 219)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 28
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Sandranails.My.Resources.Resources.bolo_de_aniversario
        Me.PictureBox5.Location = New System.Drawing.Point(590, 182)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 27
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Sandranails.My.Resources.Resources.genero
        Me.PictureBox4.Location = New System.Drawing.Point(590, 140)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sandranails.My.Resources.Resources.contact_us
        Me.PictureBox3.Location = New System.Drawing.Point(96, 222)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sandranails.My.Resources.Resources.email
        Me.PictureBox2.Location = New System.Drawing.Point(96, 183)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sandranails.My.Resources.Resources.cliente__1_
        Me.PictureBox1.Location = New System.Drawing.Point(96, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PicRemover
        '
        Me.PicRemover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRemover.Image = Global.Sandranails.My.Resources.Resources.remover
        Me.PicRemover.Location = New System.Drawing.Point(864, 552)
        Me.PicRemover.Name = "PicRemover"
        Me.PicRemover.Size = New System.Drawing.Size(39, 38)
        Me.PicRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicRemover.TabIndex = 18
        Me.PicRemover.TabStop = False
        '
        'PicEditar
        '
        Me.PicEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicEditar.Image = Global.Sandranails.My.Resources.Resources.editar
        Me.PicEditar.Location = New System.Drawing.Point(864, 459)
        Me.PicEditar.Name = "PicEditar"
        Me.PicEditar.Size = New System.Drawing.Size(39, 38)
        Me.PicEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicEditar.TabIndex = 17
        Me.PicEditar.TabStop = False
        '
        'PicAdicionar
        '
        Me.PicAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicAdicionar.Image = Global.Sandranails.My.Resources.Resources.adicionar
        Me.PicAdicionar.Location = New System.Drawing.Point(864, 370)
        Me.PicAdicionar.Name = "PicAdicionar"
        Me.PicAdicionar.Size = New System.Drawing.Size(39, 38)
        Me.PicAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicAdicionar.TabIndex = 16
        Me.PicAdicionar.TabStop = False
        '
        'PicLimpar
        '
        Me.PicLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLimpar.Image = Global.Sandranails.My.Resources.Resources.limpar
        Me.PicLimpar.Location = New System.Drawing.Point(960, 251)
        Me.PicLimpar.Name = "PicLimpar"
        Me.PicLimpar.Size = New System.Drawing.Size(39, 38)
        Me.PicLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLimpar.TabIndex = 15
        Me.PicLimpar.TabStop = False
        '
        'PICsair
        '
        Me.PICsair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PICsair.Image = Global.Sandranails.My.Resources.Resources.sair
        Me.PICsair.Location = New System.Drawing.Point(49, 40)
        Me.PICsair.Name = "PICsair"
        Me.PICsair.Size = New System.Drawing.Size(39, 38)
        Me.PICsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICsair.TabIndex = 14
        Me.PICsair.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.Sandranails.My.Resources.Resources.lupa
        Me.PictureBox7.Location = New System.Drawing.Point(804, 328)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 29
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = Global.Sandranails.My.Resources.Resources.botao_excluir
        Me.PictureBox8.Location = New System.Drawing.Point(804, 328)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 30
        Me.PictureBox8.TabStop = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 749)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCOD)
        Me.Controls.Add(Me.txtProcura)
        Me.Controls.Add(Me.lblProcurar)
        Me.Controls.Add(Me.ListCLientes)
        Me.Controls.Add(Me.PicRemover)
        Me.Controls.Add(Me.PicEditar)
        Me.Controls.Add(Me.PicAdicionar)
        Me.Controls.Add(Me.PicLimpar)
        Me.Controls.Add(Me.PICsair)
        Me.Controls.Add(Me.MTBnif)
        Me.Controls.Add(Me.DTPdata)
        Me.Controls.Add(Me.CMBGenero)
        Me.Controls.Add(Me.MTB_Telemovel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNIF)
        Me.Controls.Add(Me.lblData_Nascimento)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lblTelemovel)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "frmClientes"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRemover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAdicionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLimpar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICsair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelemovel As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblData_Nascimento As Label
    Friend WithEvents lblNIF As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents MTB_Telemovel As MaskedTextBox
    Friend WithEvents CMBGenero As ComboBox
    Friend WithEvents DTPdata As DateTimePicker
    Friend WithEvents MTBnif As MaskedTextBox
    Friend WithEvents PICsair As PictureBox
    Friend WithEvents PicLimpar As PictureBox
    Friend WithEvents PicAdicionar As PictureBox
    Friend WithEvents PicEditar As PictureBox
    Friend WithEvents PicRemover As PictureBox
    Friend WithEvents ListCLientes As ListView
    Friend WithEvents txtProcura As TextBox
    Friend WithEvents lblProcurar As Label
    Friend WithEvents txtCOD As TextBox
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents Telemóvel As ColumnHeader
    Friend WithEvents Género As ColumnHeader
    Friend WithEvents Data_Nascimento As ColumnHeader
    Friend WithEvents NIF As ColumnHeader
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
