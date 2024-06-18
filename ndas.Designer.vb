<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ndas
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
        Me.components = New System.ComponentModel.Container()
        Me.ChromiumWebBrowser1 = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.SuspendLayout()
        '
        'ChromiumWebBrowser1
        '
        Me.ChromiumWebBrowser1.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChromiumWebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.ChromiumWebBrowser1.Name = "ChromiumWebBrowser1"
        Me.ChromiumWebBrowser1.Size = New System.Drawing.Size(800, 450)
        Me.ChromiumWebBrowser1.TabIndex = 0
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 1
        '
        'ndas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ChromiumWebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ndas"
        Me.Text = "ndas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChromiumWebBrowser1 As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
End Class
