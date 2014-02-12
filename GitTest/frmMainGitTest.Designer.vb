<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainGitTest
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
        Me.btnSaludar = New System.Windows.Forms.Button()
        Me.btnPresentarse = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaludar
        '
        Me.btnSaludar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaludar.Location = New System.Drawing.Point(12, 12)
        Me.btnSaludar.Name = "btnSaludar"
        Me.btnSaludar.Size = New System.Drawing.Size(248, 36)
        Me.btnSaludar.TabIndex = 0
        Me.btnSaludar.Text = "Saludar"
        Me.btnSaludar.UseVisualStyleBackColor = True
        '
        'btnPresentarse
        '
        Me.btnPresentarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresentarse.Location = New System.Drawing.Point(12, 54)
        Me.btnPresentarse.Name = "btnPresentarse"
        Me.btnPresentarse.Size = New System.Drawing.Size(248, 36)
        Me.btnPresentarse.TabIndex = 1
        Me.btnPresentarse.Text = "Presentarse"
        Me.btnPresentarse.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(12, 96)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(248, 36)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmMainGitTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 141)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPresentarse)
        Me.Controls.Add(Me.btnSaludar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainGitTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GitTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaludar As System.Windows.Forms.Button
    Friend WithEvents btnPresentarse As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
