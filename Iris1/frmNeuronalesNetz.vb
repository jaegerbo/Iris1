Public Class frmNeuronalesNetz

   Private _NeuronHeight As Integer = 60
   Private _NeuronWidth As Integer = 180
   Private _Schichtabstand As Integer = 40
   Private _TestdatenPointer As Integer = 0

   Private _Netz As clsNeuronalesNetz
   Private _Testdaten As clsIrisDatensatzListe

   Public Sub erstelleNetz(Netz As clsNeuronalesNetz, Testdaten As clsIrisDatensatzListe)
      ' Zweck:    Das gegebene Netz anzeigen
      Try
         _Netz = Netz
         _Testdaten = Testdaten

         NetzAufbauen()

      Catch ex As Exception
         Stop
      End Try
   End Sub
   Private Sub NetzAufbauen()
      ' Zweck:    Das gegebene Netz anzeigen
      Try
         Dim leftOffset As Integer = 40
         Dim topOffset As Integer = 100

         ' Eingangsschicht erstellen
         Dim Nr As Integer = 0
         For Each Neuron As clsNeuron In _Netz.Eingangsneuronen
            Dim txtControl As TextBox = createNeuron(Neuron, leftOffset + (Nr * _NeuronWidth), topOffset)
            Me.Controls.Add(txtControl)
            Nr += 1
         Next

         ' Zwischenschichten erstellen
         Nr = 0
         Dim Schichtnummer As Integer = 1
         For Each Schicht As Generic.List(Of clsNeuron) In _Netz.Zwischenschichten
            topOffset += Schichtnummer * _NeuronHeight + _Schichtabstand

            For Each Neuron As clsNeuron In Schicht
               Dim txtControl As TextBox = createNeuron(Neuron, leftOffset + (Nr * _NeuronWidth), topOffset)
               Me.Controls.Add(txtControl)
               Nr += 1
            Next

            Schichtnummer += 1
         Next

         ' Ausgangsschicht erstellen
         Nr = 0
         topOffset += _NeuronHeight + _Schichtabstand
         For Each Neuron As clsNeuron In _Netz.Ausgangsneuronen
            Dim txtControl As TextBox = createNeuron(Neuron, leftOffset + (Nr * _NeuronWidth), topOffset)
            Me.Controls.Add(txtControl)
            Nr += 1
         Next

      Catch ex As Exception
         Stop
      End Try
   End Sub

   Private Function createNeuron(Neuron As clsNeuron, left As Integer, top As Integer) As TextBox
      ' Zweck:    Für das gegebene Neuron eine Textbox erzeugen
      Dim txtControl As TextBox
      Try
         ' prüfen, ob das Control bereits vorhanden ist
         If Me.Controls.ContainsKey(Neuron.Name) = True Then
            txtControl = Me.Controls.Item(Neuron.Name)
         Else
            txtControl = New TextBox
         End If

         With txtControl
            .Name = Neuron.Name
            .Multiline = True
            .Text = Neuron.Name & vbNewLine &
                    Neuron.EingangswerteString
            .Height = _NeuronHeight
            .Width = _NeuronWidth
            .Top = top
            .Left = left
         End With

      Catch ex As Exception
         Stop
      End Try
      Return txtControl
   End Function

   Private Sub btnEinenSchrittAusführen_Click(sender As Object, e As EventArgs) Handles btnEinenSchrittAusführen.Click
      ' Zweck:    Einen Berechnungsschritt ausführen
      Try
         ' Testdatensatz ermitteln und die Eingangswerte des Neuron füllen
         Dim IrisDatensatz As clsIrisDatensatz = _Testdaten(_TestdatenPointer)
         _Netz.Eingangsneuronen(0).Eingangswerte = New Generic.List(Of Double)({IrisDatensatz.BreiteBlütenblatt})
         _Netz.Eingangsneuronen(1).Eingangswerte = New Generic.List(Of Double)({IrisDatensatz.LängeBlütenblatt})
         _Netz.Eingangsneuronen(2).Eingangswerte = New Generic.List(Of Double)({IrisDatensatz.BreiteKelchblatt})
         _Netz.Eingangsneuronen(3).Eingangswerte = New Generic.List(Of Double)({IrisDatensatz.LängeKelchblatt})

         NetzAufbauen()

         _TestdatenPointer += 1
      Catch ex As Exception
         Stop
      End Try
   End Sub

End Class