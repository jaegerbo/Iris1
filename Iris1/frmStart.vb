Public Class frmStart

   Private _Testdaten As clsIrisDatensatzListe

   Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      btnDatenEinlesen_Click(Nothing, Nothing)
      btnMischen_Click(Nothing, Nothing)
   End Sub

   Private Sub btnDatenEinlesen_Click(sender As Object, e As EventArgs) Handles btnDatenEinlesen.Click
      Try
         Application.CurrentCulture = New Globalization.CultureInfo("en-en")

         Dim Fi As New IO.FileInfo("Irisdaten.csv")
         If Fi.Exists = False Then
            MsgBox("Keine Daten gefunden.")
            Exit Sub
         End If

         Dim Werteliste As New clsIrisDatensatzListe
         Dim maxLängeKelchblatt As Double = Double.MinValue
         Dim minLängeKelchblatt As Double = Double.MaxValue
         Dim maxBreiteKelchblatt As Double = Double.MinValue
         Dim minBreiteKelchblatt As Double = Double.MaxValue
         Dim maxLängeBlütenblatt As Double = Double.MinValue
         Dim minLängeBlütenblatt As Double = Double.MaxValue
         Dim maxBreiteBlütenblatt As Double = Double.MinValue
         Dim minBreiteBlütenblatt As Double = Double.MaxValue

         Dim fs As IO.StreamReader = Fi.OpenText

         ' 1. Zeile lesen
         Dim Zeile As String = fs.ReadLine
         While Zeile IsNot Nothing

            Dim Datensatz As New clsIrisDatensatz
            With Datensatz

               ' Zeile in Werte aufsplitten, und dabei die Maximal- und Minimalwerte ermitteln
               Dim Werte() As String = Zeile.Split(",")
               If Werte.Length = 5 Then
                  .LängeKelchblatt = CDbl(Werte(0))
                  If .LängeKelchblatt > maxLängeKelchblatt Then maxLängeKelchblatt = .LängeKelchblatt
                  If .LängeKelchblatt < minLängeKelchblatt Then minLängeKelchblatt = .LängeKelchblatt

                  .BreiteKelchblatt = CDbl(Werte(1))
                  If .BreiteKelchblatt > maxBreiteKelchblatt Then maxBreiteKelchblatt = .BreiteKelchblatt
                  If .BreiteKelchblatt < minBreiteKelchblatt Then minBreiteKelchblatt = .BreiteKelchblatt

                  .LängeBlütenblatt = CDbl(Werte(2))
                  If .LängeBlütenblatt > maxLängeBlütenblatt Then maxLängeBlütenblatt = .LängeBlütenblatt
                  If .LängeBlütenblatt < minLängeBlütenblatt Then minLängeBlütenblatt = .LängeBlütenblatt

                  .BreiteBlütenblatt = CDbl(Werte(3))
                  If .BreiteBlütenblatt > maxBreiteBlütenblatt Then maxBreiteBlütenblatt = .BreiteBlütenblatt
                  If .BreiteBlütenblatt < minBreiteBlütenblatt Then minBreiteBlütenblatt = .BreiteBlütenblatt

                  .Art = Werte(4)

                  Werteliste.Add(Datensatz)
               End If

            End With

            ' nächste Zeile lesen
            Zeile = fs.ReadLine
         End While

         ' normaliserte Werte erzeugen.
         ' Die Längenangaben werden auf Werte zwischen +1 und -1 normalisert.
         ' Dazu wird die Steigung berechnet als 2 geteilt durch die Differenz aus Maxwert - Minwert
         ' Der Schnittpunkt ergibt sich aus 1 - (Steigung + maxWert)
         Dim SteigungLängeKelchblatt As Double = 2 / (maxLängeKelchblatt - minLängeKelchblatt)
         Dim SchnittpunktLängeKelchblatt As Double = 1 - (SteigungLängeKelchblatt * maxLängeKelchblatt)

         Dim SteigungBreiteKelchblatt As Double = 2 / (maxBreiteKelchblatt - minBreiteKelchblatt)
         Dim SchnittpunktBreiteKelchblatt As Double = 1 - (SteigungBreiteKelchblatt * maxBreiteKelchblatt)

         Dim SteigungLängeBlütenblatt As Double = 2 / (maxLängeBlütenblatt - minLängeBlütenblatt)
         Dim SchnittpunktLängeBlütenblatt As Double = 1 - (SteigungLängeBlütenblatt * maxLängeBlütenblatt)

         Dim SteigungBreiteBlütenblatt As Double = 2 / (maxBreiteBlütenblatt - minBreiteBlütenblatt)
         Dim SchnittpunktBreiteBlütenblatt As Double = 1 - (SteigungBreiteBlütenblatt * maxBreiteBlütenblatt)

         For Each Datensatz As clsIrisDatensatz In Werteliste
            Datensatz.LängeKelchblattNormalisiert = Datensatz.LängeKelchblatt * SteigungLängeKelchblatt + SchnittpunktLängeKelchblatt
            Datensatz.BreiteKelchblattNormalisiert = Datensatz.BreiteKelchblatt * SteigungBreiteKelchblatt + SchnittpunktBreiteKelchblatt
            Datensatz.LängeBlütenblattNormalisiert = Datensatz.LängeBlütenblatt * SteigungLängeBlütenblatt + SchnittpunktLängeBlütenblatt
            Datensatz.BreiteBlütenblattNormalisiert = Datensatz.BreiteBlütenblatt * SteigungBreiteBlütenblatt + SchnittpunktBreiteBlütenblatt

            ' die Art wird mit einer 1-von-N codierung normalisiert. Da es 3 Arten gibt, wird ein dreidimensionaler Vektor gebildet, bei dem jede Ziffer
            ' für eine Art steht. 
            Select Case Datensatz.Art
               Case "Iris-setosa"
                  Datensatz.Art1Normalisiert = 1
                  Datensatz.Art2Normalisiert = 0
                  Datensatz.Art3Normalisiert = 0
               Case "Iris-versicolor"
                  Datensatz.Art1Normalisiert = 0
                  Datensatz.Art2Normalisiert = 1
                  Datensatz.Art3Normalisiert = 0
               Case "Iris-virginica"
                  Datensatz.Art1Normalisiert = 0
                  Datensatz.Art2Normalisiert = 0
                  Datensatz.Art3Normalisiert = 1
            End Select

         Next

         gridIrisDaten.DataSource = Werteliste
         gridIrisTestdaten.DataSource = Nothing

      Catch ex As Exception
         Stop
      Finally
         Application.CurrentCulture = New Globalization.CultureInfo("de-de")
      End Try
   End Sub

   Private Sub btnMischen_Click(sender As Object, e As EventArgs) Handles btnMischen.Click
      ' Zweck:    Die Daten mischen, und 10% der Daten als Testdaten ermitteln
      Try
         ' Zufallsgenerator initialisieren
         Dim Zufall As New Random(Now.Millisecond)

         ' mischen
         Dim Werteliste As clsIrisDatensatzListe = gridIrisDaten.DataSource
         Dim NeueWerteliste As New clsIrisDatensatzListe
         Dim Anzahl As Integer = Werteliste.Count

         Do While Werteliste.Count > 0

            Dim Datensatznummer As Integer = Zufall.Next(Werteliste.Count - 1)
            Dim Datensatz As clsIrisDatensatz = Werteliste(Datensatznummer)
            NeueWerteliste.Add(Datensatz)
            Werteliste.Remove(Datensatz)

         Loop

         ' die ersten 10% der neuen Werteliste als Testdaten extrahieren
         _Testdaten = New clsIrisDatensatzListe
         Dim TestdatenAnzahl As Integer = CInt(NeueWerteliste.Count * 0.1)
         For i As Integer = 0 To TestdatenAnzahl - 1

            Dim Datensatz As clsIrisDatensatz = NeueWerteliste(i)
            _Testdaten.Add(Datensatz)
            NeueWerteliste.Remove(Datensatz)

         Next

         gridIrisDaten.DataSource = NeueWerteliste
         gridIrisTestdaten.DataSource = _Testdaten

      Catch ex As Exception
         Stop
      End Try
   End Sub

   Private Sub btnNetzAnzeigen_Click(sender As Object, e As EventArgs) Handles btnNetzAnzeigen.Click
      Try
         Dim Schichtenliste As New Generic.List(Of Integer)
         Schichtenliste.Add(4)
         Schichtenliste.Add(5)
         Schichtenliste.Add(3)

         Dim Netz As New clsNeuronalesNetz(Schichtenliste)

         Dim frm As New frmNeuronalesNetz
         frm.erstelleNetz(Netz, _Testdaten)
         frm.Show()

      Catch ex As Exception
         Stop
      End Try
   End Sub

End Class
