<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdicionarMarcacao
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
        Me.lblData_Marcacao = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblServico = New System.Windows.Forms.Label()
        Me.txtServico = New System.Windows.Forms.TextBox()
        Me.txtCLiente = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.lblhora_marcacao = New System.Windows.Forms.Label()
        Me.CMBHora_Inicio = New System.Windows.Forms.ComboBox()
        Me.CMBHora_Fim = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblData_Marcacao
        '
        Me.lblData_Marcacao.AutoSize = True
        Me.lblData_Marcacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData_Marcacao.Location = New System.Drawing.Point(22, 43)
        Me.lblData_Marcacao.Name = "lblData_Marcacao"
        Me.lblData_Marcacao.Size = New System.Drawing.Size(183, 24)
        Me.lblData_Marcacao.TabIndex = 0
        Me.lblData_Marcacao.Text = "Data da marcação:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(226, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(246, 29)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServico.Location = New System.Drawing.Point(22, 85)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(86, 24)
        Me.lblServico.TabIndex = 2
        Me.lblServico.Text = "Serviço:"
        '
        'txtServico
        '
        Me.txtServico.BackColor = System.Drawing.SystemColors.Menu
        Me.txtServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServico.Location = New System.Drawing.Point(226, 85)
        Me.txtServico.Name = "txtServico"
        Me.txtServico.Size = New System.Drawing.Size(246, 29)
        Me.txtServico.TabIndex = 3
        '
        'txtCLiente
        '
        Me.txtCLiente.BackColor = System.Drawing.SystemColors.Menu
        Me.txtCLiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCLiente.Location = New System.Drawing.Point(226, 129)
        Me.txtCLiente.Name = "txtCLiente"
        Me.txtCLiente.Size = New System.Drawing.Size(246, 29)
        Me.txtCLiente.TabIndex = 5
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(22, 129)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(81, 24)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente:"
        '
        'txtContacto
        '
        Me.txtContacto.BackColor = System.Drawing.SystemColors.Menu
        Me.txtContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.Location = New System.Drawing.Point(226, 170)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(246, 29)
        Me.txtContacto.TabIndex = 7
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacto.Location = New System.Drawing.Point(22, 173)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(98, 24)
        Me.lblContacto.TabIndex = 6
        Me.lblContacto.Text = "Contacto:"
        '
        'lblhora_marcacao
        '
        Me.lblhora_marcacao.AutoSize = True
        Me.lblhora_marcacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora_marcacao.Location = New System.Drawing.Point(22, 240)
        Me.lblhora_marcacao.Name = "lblhora_marcacao"
        Me.lblhora_marcacao.Size = New System.Drawing.Size(187, 24)
        Me.lblhora_marcacao.TabIndex = 8
        Me.lblhora_marcacao.Text = "Hora da Marcação:"
        '
        'CMBHora_Inicio
        '
        Me.CMBHora_Inicio.BackColor = System.Drawing.SystemColors.Menu
        Me.CMBHora_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBHora_Inicio.FormattingEnabled = True
        Me.CMBHora_Inicio.Location = New System.Drawing.Point(250, 240)
        Me.CMBHora_Inicio.Name = "CMBHora_Inicio"
        Me.CMBHora_Inicio.Size = New System.Drawing.Size(85, 32)
        Me.CMBHora_Inicio.TabIndex = 9
        '
        'CMBHora_Fim
        '
        Me.CMBHora_Fim.BackColor = System.Drawing.SystemColors.Menu
        Me.CMBHora_Fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBHora_Fim.FormattingEnabled = True
        Me.CMBHora_Fim.Location = New System.Drawing.Point(383, 240)
        Me.CMBHora_Fim.Name = "CMBHora_Fim"
        Me.CMBHora_Fim.Size = New System.Drawing.Size(85, 32)
        Me.CMBHora_Fim.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fim"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sandranails.My.Resources.Resources.certo_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(383, 291)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'AdicionarMarcacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 375)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMBHora_Fim)
        Me.Controls.Add(Me.CMBHora_Inicio)
        Me.Controls.Add(Me.lblhora_marcacao)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.lblContacto)
        Me.Controls.Add(Me.txtCLiente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtServico)
        Me.Controls.Add(Me.lblServico)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblData_Marcacao)
        Me.Name = "AdicionarMarcacao"
        Me.Text = "AdicionarMarcacao"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblData_Marcacao As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblServico As Label
    Friend WithEvents txtServico As TextBox
    Friend WithEvents txtCLiente As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents lblContacto As Label
    Friend WithEvents lblhora_marcacao As Label
    Friend WithEvents CMBHora_Inicio As ComboBox
    Friend WithEvents CMBHora_Fim As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
