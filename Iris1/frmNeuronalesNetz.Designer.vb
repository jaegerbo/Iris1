<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNeuronalesNetz
   Inherits System.Windows.Forms.Form

   'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

   'Wird vom Windows Form-Designer benötigt.
   Private components As System.ComponentModel.IContainer

   'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
   'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
   'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.btnEinenSchrittAusführen = New Infragistics.Win.Misc.UltraButton()
      Me.SuspendLayout()
      '
      'btnEinenSchrittAusführen
      '
      Me.btnEinenSchrittAusführen.Location = New System.Drawing.Point(14, 6)
      Me.btnEinenSchrittAusführen.Name = "btnEinenSchrittAusführen"
      Me.btnEinenSchrittAusführen.Size = New System.Drawing.Size(180, 35)
      Me.btnEinenSchrittAusführen.TabIndex = 0
      Me.btnEinenSchrittAusführen.Text = "einen Schritt ausführen"
      '
      'frmNeuronalesNetz
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1460, 705)
      Me.Controls.Add(Me.btnEinenSchrittAusführen)
      Me.Name = "frmNeuronalesNetz"
      Me.Text = "frmNeuronalesNetz"
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents btnEinenSchrittAusführen As Infragistics.Win.Misc.UltraButton
End Class
