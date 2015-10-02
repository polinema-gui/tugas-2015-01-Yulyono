<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tugasyul
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
        Me.Buttonberubah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Buttonberubah
        '
        Me.Buttonberubah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Buttonberubah.Location = New System.Drawing.Point(610, 309)
        Me.Buttonberubah.Name = "Buttonberubah"
        Me.Buttonberubah.Size = New System.Drawing.Size(75, 23)
        Me.Buttonberubah.TabIndex = 0
        Me.Buttonberubah.Text = "Berubah"
        Me.Buttonberubah.UseVisualStyleBackColor = True
        '
        'tugasyul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(702, 371)
        Me.Controls.Add(Me.Buttonberubah)
        Me.Name = "tugasyul"
        Me.Text = "Tugas1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Buttonberubah As System.Windows.Forms.Button

End Class
