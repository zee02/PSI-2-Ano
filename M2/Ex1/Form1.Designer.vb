<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResposta = New System.Windows.Forms.Label()
        Me.btnAdvinhe = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "O meu clube"
        '
        'lblResposta
        '
        Me.lblResposta.AutoSize = True
        Me.lblResposta.Cursor = System.Windows.Forms.Cursors.No
        Me.lblResposta.Location = New System.Drawing.Point(207, 42)
        Me.lblResposta.Name = "lblResposta"
        Me.lblResposta.Size = New System.Drawing.Size(13, 13)
        Me.lblResposta.TabIndex = 1
        Me.lblResposta.Text = "?"
        '
        'btnAdvinhe
        '
        Me.btnAdvinhe.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnAdvinhe.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAdvinhe.Location = New System.Drawing.Point(130, 106)
        Me.btnAdvinhe.Name = "btnAdvinhe"
        Me.btnAdvinhe.Size = New System.Drawing.Size(90, 21)
        Me.btnAdvinhe.TabIndex = 2
        Me.btnAdvinhe.Text = "Qual é?"
        Me.btnAdvinhe.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(291, 9)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(48, 22)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnAdvinhe)
        Me.Controls.Add(Me.lblResposta)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Adivinhar o clube"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResposta As Label
    Friend WithEvents btnAdvinhe As Button
    Friend WithEvents btnSair As Button
End Class
