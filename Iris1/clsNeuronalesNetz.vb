Public Class clsNeuronalesNetz

   Public Sub New(Topologie As Generic.List(Of Integer))
      ' Zweck: über die Topologieliste wird definiert, aus wieviel Schichten das Netz besteht, und wie groß jede Schicht ist
      Try
         _Topologie = Topologie

         ' Eingangsschicht erstellen
         _Eingangsneuronen = New Generic.List(Of clsNeuron)
         For i As Integer = 1 To Topologie(0)
            Dim Neuron As New clsNeuron($"E-{i.ToString}")
            _Eingangsneuronen.Add(Neuron)
            _NeuronListe.Add(Neuron)
         Next

         ' Zwischenschichten erstellen
         _Zwischenschichten = New Generic.List(Of Generic.List(Of clsNeuron))
         For s As Integer = 1 To _Topologie.Count - 2
            Dim Schicht As New Generic.List(Of clsNeuron)
            For i As Integer = 1 To Topologie(s)
               Dim Neuron As New clsNeuron($"Z-{s.ToString}-{i.ToString}")
               Schicht.Add(Neuron)
               _NeuronListe.Add(Neuron)
            Next
            _Zwischenschichten.Add(Schicht)
         Next

         ' Ausgangsschicht erstellen
         _Ausgangsneuronen = New Generic.List(Of clsNeuron)
         For i As Integer = 1 To Topologie(_Topologie.Count - 1)
            Dim Neuron As New clsNeuron($"A-{i.ToString}")
            _Ausgangsneuronen.Add(Neuron)
            _NeuronListe.Add(Neuron)
         Next

      Catch ex As Exception
         Stop
      End Try
   End Sub

   Private _Topologie As Generic.List(Of Integer)
   Public Property Topologie() As Generic.List(Of Integer)
      Get
         Return _Topologie
      End Get
      Set(ByVal value As Generic.List(Of Integer))
         _Topologie = value
      End Set
   End Property

   Private _Eingangsneuronen As Generic.List(Of clsNeuron)
   Public Property Eingangsneuronen() As Generic.List(Of clsNeuron)
      Get
         Return _Eingangsneuronen
      End Get
      Set(ByVal value As Generic.List(Of clsNeuron))
         _Eingangsneuronen = value
      End Set
   End Property

   Private _Ausgangsneuronen As Generic.List(Of clsNeuron)
   Public Property Ausgangsneuronen() As Generic.List(Of clsNeuron)
      Get
         Return _Ausgangsneuronen
      End Get
      Set(ByVal value As Generic.List(Of clsNeuron))
         _Ausgangsneuronen = value
      End Set
   End Property

   Private _Zwischenschichten As Generic.List(Of Generic.List(Of clsNeuron))
   Public Property Zwischenschichten() As Generic.List(Of Generic.List(Of clsNeuron))
      Get
         Return _Zwischenschichten
      End Get
      Set(ByVal value As Generic.List(Of Generic.List(Of clsNeuron)))
         _Zwischenschichten = value
      End Set
   End Property

   Private _NeuronListe As New Generic.List(Of clsNeuron)
   Public ReadOnly Property Neuronliste() As Generic.List(Of clsNeuron)
      Get
         Return _NeuronListe
      End Get
   End Property

   Public Sub calculateOnce(Eingangswerte As Double())
      ' Zweck:    Das Netz einmal rechnen lassen
      Try

      Catch ex As Exception
         Stop
      End Try
   End Sub

End Class
