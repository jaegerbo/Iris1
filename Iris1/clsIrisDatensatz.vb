Public Class clsIrisDatensatz

   Private _LängeKelchblatt As Double
   Public Property LängeKelchblatt() As Double
      Get
         Return _LängeKelchblatt
      End Get
      Set(ByVal value As Double)
         _LängeKelchblatt = value
      End Set
   End Property

   Private _BreiteKelchblatt As Double
   Public Property BreiteKelchblatt() As Double
      Get
         Return _BreiteKelchblatt
      End Get
      Set(ByVal value As Double)
         _BreiteKelchblatt = value
      End Set
   End Property

   Private _LängeBlütenblatt As Double
   Public Property LängeBlütenblatt() As Double
      Get
         Return _LängeBlütenblatt
      End Get
      Set(ByVal value As Double)
         _LängeBlütenblatt = value
      End Set
   End Property

   Private _BreiteBlütenblatt As Double
   Public Property BreiteBlütenblatt() As Double
      Get
         Return _BreiteBlütenblatt
      End Get
      Set(ByVal value As Double)
         _BreiteBlütenblatt = value
      End Set
   End Property

   Private _Art As String
   Public Property Art() As String
      Get
         Return _Art
      End Get
      Set(ByVal value As String)
         _Art = value
      End Set
   End Property

   Private _LängeKelchblattNormalisiert As Double
   Public Property LängeKelchblattNormalisiert() As Double
      Get
         Return _LängeKelchblattNormalisiert
      End Get
      Set(ByVal value As Double)
         _LängeKelchblattNormalisiert = value
      End Set
   End Property

   Private _BreiteKelchblattNormalisiert As Double
   Public Property BreiteKelchblattNormalisiert() As Double
      Get
         Return _BreiteKelchblattNormalisiert
      End Get
      Set(ByVal value As Double)
         _BreiteKelchblattNormalisiert = value
      End Set
   End Property

   Private _LängeBlütenblattNormalisiert As Double
   Public Property LängeBlütenblattNormalisiert() As Double
      Get
         Return _LängeBlütenblattNormalisiert
      End Get
      Set(ByVal value As Double)
         _LängeBlütenblattNormalisiert = value
      End Set
   End Property

   Private _BreiteBlütenblattNormalisiert As Double
   Public Property BreiteBlütenblattNormalisiert() As Double
      Get
         Return _BreiteBlütenblattNormalisiert
      End Get
      Set(ByVal value As Double)
         _BreiteBlütenblattNormalisiert = value
      End Set
   End Property

   Private _Art1Normalisiert As Double
   Public Property Art1Normalisiert() As Double
      Get
         Return _Art1Normalisiert
      End Get
      Set(ByVal value As Double)
         _Art1Normalisiert = value
      End Set
   End Property

   Private _Art2Normalisiert As Double
   Public Property Art2Normalisiert() As Double
      Get
         Return _Art2Normalisiert
      End Get
      Set(ByVal value As Double)
         _Art2Normalisiert = value
      End Set
   End Property

   Private _Art3Normalisiert As Double
   Public Property Art3Normalisiert() As Double
      Get
         Return _Art3Normalisiert
      End Get
      Set(ByVal value As Double)
         _Art3Normalisiert = value
      End Set
   End Property

End Class
