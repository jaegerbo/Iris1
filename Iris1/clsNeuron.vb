Public Class clsNeuron

   Private _gewichteterEingang As Double = 0

   Public Sub New(Name As String)
      _Name = Name
   End Sub

   Private _Id As Guid = Guid.NewGuid
   Public ReadOnly Property Id() As Guid
      Get
         Return _Id
      End Get
   End Property

   Private _Name As String = String.Empty
   Public Property Name() As String
      Get
         Return _Name
      End Get
      Set(ByVal value As String)
         _Name = value
      End Set
   End Property

   Private _Eingangswerte As Generic.List(Of Double)
   Public Property Eingangswerte() As Generic.List(Of Double)
      Get
         Return _Eingangswerte
      End Get
      Set(ByVal value As Generic.List(Of Double))
         _Eingangswerte = value
      End Set
   End Property
   Private _EingangswerteString As String
   Public ReadOnly Property EingangswerteString() As String
      Get
         _EingangswerteString = Nothing

         If _Eingangswerte IsNot Nothing Then
            For Each Wert As Double In _Eingangswerte
               If _EingangswerteString IsNot Nothing Then
                  _EingangswerteString &= $", "
               End If
               _EingangswerteString &= $"( {Format(Wert, "0.00")} )"
            Next
         End If

         Return _EingangswerteString
      End Get
   End Property

   Private _Gewichtungen As Generic.List(Of Double)
   Public Property Gewichtungen() As Generic.List(Of Double)
      Get
         Return _Gewichtungen
      End Get
      Set(ByVal value As Generic.List(Of Double))
         _Gewichtungen = value
      End Set
   End Property

   Private _Schwellenwert As Double = 0
   Public Property Schwellenwert() As Double
      Get
         Return _Schwellenwert
      End Get
      Set(ByVal value As Double)
         _Schwellenwert = value
      End Set
   End Property

   Private _Ausgangswert As Double = 0
   Public Property Ausgangswert() As Double
      Get
         _Ausgangswert = Aktivierungsfunktion()
         Return _Ausgangswert
      End Get
      Set(ByVal value As Double)
         _Ausgangswert = value
      End Set
   End Property

   Private Sub Übertragungsfunktion()
      ' Zweck:    Die Eingabewerte unter berücksichtigung der Gewichtungen zusammenfassen
      Try
         _gewichteterEingang = 0
         For i As Integer = 0 To _Eingangswerte.Count - 1
            _gewichteterEingang += _Eingangswerte(i) * _Gewichtungen(i)
         Next
      Catch ex As Exception
         Stop
      End Try
   End Sub

   Private Function Aktivierungsfunktion() As Double
      ' Zweck:    den gewichteten Eingang verarbeiten und einen Ausgabewert erzeugen
      Dim Ausgangswert As Double = 0
      Try
         Ausgangswert = sigmoid(_gewichteterEingang) + _Schwellenwert
      Catch ex As Exception
         Stop
      End Try
      Return Ausgangswert
   End Function

   Private Function sigmoid(x As Double) As Double
      Return 1 / (1 + Math.Exp(-x))
   End Function

End Class
