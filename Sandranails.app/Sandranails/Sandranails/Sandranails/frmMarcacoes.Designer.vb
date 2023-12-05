<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMarcacoes
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblData = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.lblServico = New System.Windows.Forms.Label()
        Me.txtServico = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.txtCOD = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(498, 285)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(498, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(227, 165)
        Me.DataGridView1.TabIndex = 1
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Location = New System.Drawing.Point(382, 120)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(92, 42)
        Me.btnAdicionar.TabIndex = 2
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(382, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Remover"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(382, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 42)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(119, 120)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(41, 15)
        Me.lblData.TabIndex = 7
        Me.lblData.Text = "Data:"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(174, 119)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(100, 20)
        Me.txtData.TabIndex = 8
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServico.Location = New System.Drawing.Point(119, 161)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(58, 15)
        Me.lblServico.TabIndex = 9
        Me.lblServico.Text = "Serviço:"
        '
        'txtServico
        '
        Me.txtServico.Location = New System.Drawing.Point(183, 160)
        Me.txtServico.Name = "txtServico"
        Me.txtServico.Size = New System.Drawing.Size(91, 20)
        Me.txtServico.TabIndex = 10
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(119, 194)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(56, 15)
        Me.lblCliente.TabIndex = 11
        Me.lblCliente.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(183, 193)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(91, 20)
        Me.txtCliente.TabIndex = 12
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacto.Location = New System.Drawing.Point(119, 229)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(67, 15)
        Me.lblContacto.TabIndex = 13
        Me.lblContacto.Text = "Contacto:"
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(192, 228)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(82, 20)
        Me.txtContacto.TabIndex = 14
        '
        'txtCOD
        '
        Me.txtCOD.Location = New System.Drawing.Point(790, 31)
        Me.txtCOD.Name = "txtCOD"
        Me.txtCOD.Size = New System.Drawing.Size(100, 20)
        Me.txtCOD.TabIndex = 46
        Me.txtCOD.Visible = False
        '
        'frmMarcacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 618)
        Me.Controls.Add(Me.txtCOD)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.lblContacto)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtServico)
        Me.Controls.Add(Me.lblServico)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "frmMarcacoes"
        Me.Text = "frmMarcacoes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblData As Label
    Friend WithEvents txtData As TextBox
    Friend WithEvents lblServico As Label
    Friend WithEvents txtServico As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblContacto As Label
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents txtCOD As TextBox
End Class
