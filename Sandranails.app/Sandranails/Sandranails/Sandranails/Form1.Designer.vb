<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Menu = New System.Windows.Forms.ToolStrip()
        Me.MenuClientes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuServicos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuProdutos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuMarcacoes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.AutoSize = False
        Me.Menu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuClientes, Me.ToolStripSeparator1, Me.MenuServicos, Me.ToolStripSeparator2, Me.MenuProdutos, Me.ToolStripSeparator3, Me.MenuMarcacoes, Me.ToolStripSeparator4})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(111, 541)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "ToolStrip1"
        '
        'MenuClientes
        '
        Me.MenuClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuClientes.Image = Global.Sandranails.My.Resources.Resources.Clientes
        Me.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MenuClientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuClientes.Name = "MenuClientes"
        Me.MenuClientes.Size = New System.Drawing.Size(109, 74)
        Me.MenuClientes.Text = "Clientes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'MenuServicos
        '
        Me.MenuServicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuServicos.Image = Global.Sandranails.My.Resources.Resources.Serviços
        Me.MenuServicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MenuServicos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuServicos.Name = "MenuServicos"
        Me.MenuServicos.Size = New System.Drawing.Size(109, 78)
        Me.MenuServicos.Text = "Serviços"
        Me.MenuServicos.ToolTipText = "Serviços"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(109, 6)
        '
        'MenuProdutos
        '
        Me.MenuProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuProdutos.Image = Global.Sandranails.My.Resources.Resources.Produtos_v6
        Me.MenuProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MenuProdutos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuProdutos.Name = "MenuProdutos"
        Me.MenuProdutos.Size = New System.Drawing.Size(109, 77)
        Me.MenuProdutos.Text = "Produtos"
        Me.MenuProdutos.ToolTipText = "Produtos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(109, 6)
        '
        'MenuMarcacoes
        '
        Me.MenuMarcacoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuMarcacoes.Image = Global.Sandranails.My.Resources.Resources.marcacoesv1
        Me.MenuMarcacoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MenuMarcacoes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuMarcacoes.Name = "MenuMarcacoes"
        Me.MenuMarcacoes.Size = New System.Drawing.Size(109, 84)
        Me.MenuMarcacoes.Text = "Marcações"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(109, 6)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 541)
        Me.Controls.Add(Me.Menu)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Menu As ToolStrip
    Friend WithEvents MenuClientes As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MenuServicos As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MenuProdutos As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MenuMarcacoes As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
