<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
      Me.components = New System.ComponentModel.Container()
      Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("clsIrisDatensatz", -1)
      Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LängeKelchblatt")
      Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BreiteKelchblatt")
      Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LängeBlütenblatt")
      Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BreiteBlütenblatt")
      Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Art")
      Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LängeKelchblattNormalisiert")
      Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BreiteKelchblattNormalisiert")
      Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LängeBlütenblattNormalisiert")
      Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BreiteBlütenblattNormalisiert")
      Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Art1Normalisiert")
      Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Art2Normalisiert")
      Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Art3Normalisiert")
      Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("clsIrisDatensatz", -1)
      Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LängeKelchblatt")
      Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BreiteKelchblatt")
      Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LängeBlütenblatt")
      Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BreiteBlütenblatt")
      Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Art")
      Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LängeKelchblattNormalisiert")
      Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BreiteKelchblattNormalisiert")
      Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LängeBlütenblattNormalisiert")
      Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BreiteBlütenblattNormalisiert")
      Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Art1Normalisiert")
      Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Art2Normalisiert")
      Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Art3Normalisiert")
      Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
      Me.btnDatenEinlesen = New Infragistics.Win.Misc.UltraButton()
      Me.gridIrisDaten = New Infragistics.Win.UltraWinGrid.UltraGrid()
      Me.btnMischen = New Infragistics.Win.Misc.UltraButton()
      Me.gridIrisTestdaten = New Infragistics.Win.UltraWinGrid.UltraGrid()
      Me.btnNetzAnzeigen = New Infragistics.Win.Misc.UltraButton()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.bsIrisDatensatz = New System.Windows.Forms.BindingSource(Me.components)
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.PictureBox2 = New System.Windows.Forms.PictureBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.PictureBox3 = New System.Windows.Forms.PictureBox()
      CType(Me.gridIrisDaten, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.gridIrisTestdaten, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bsIrisDatensatz, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnDatenEinlesen
      '
      Me.btnDatenEinlesen.Location = New System.Drawing.Point(7, 11)
      Me.btnDatenEinlesen.Name = "btnDatenEinlesen"
      Me.btnDatenEinlesen.Size = New System.Drawing.Size(160, 40)
      Me.btnDatenEinlesen.TabIndex = 0
      Me.btnDatenEinlesen.Text = "Daten einlesen"
      '
      'gridIrisDaten
      '
      Me.gridIrisDaten.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.gridIrisDaten.DataSource = Me.bsIrisDatensatz
      Appearance1.BackColor = System.Drawing.SystemColors.Window
      Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
      Me.gridIrisDaten.DisplayLayout.Appearance = Appearance1
      UltraGridColumn1.Header.VisiblePosition = 0
      UltraGridColumn1.Width = 89
      UltraGridColumn2.Header.VisiblePosition = 1
      UltraGridColumn2.Width = 90
      UltraGridColumn3.Header.VisiblePosition = 2
      UltraGridColumn3.Width = 94
      UltraGridColumn4.Header.VisiblePosition = 3
      UltraGridColumn4.Width = 95
      UltraGridColumn5.Header.VisiblePosition = 4
      UltraGridColumn6.Format = "F2"
      UltraGridColumn6.Header.VisiblePosition = 5
      UltraGridColumn6.Width = 147
      UltraGridColumn7.Format = "F2"
      UltraGridColumn7.Header.VisiblePosition = 6
      UltraGridColumn7.Width = 151
      UltraGridColumn8.Format = "F2"
      UltraGridColumn8.Header.VisiblePosition = 7
      UltraGridColumn8.Width = 154
      UltraGridColumn9.Format = "F2"
      UltraGridColumn9.Header.VisiblePosition = 8
      UltraGridColumn9.Width = 154
      UltraGridColumn10.Header.VisiblePosition = 9
      UltraGridColumn10.Width = 34
      UltraGridColumn11.Header.VisiblePosition = 10
      UltraGridColumn11.Width = 37
      UltraGridColumn12.Header.VisiblePosition = 11
      UltraGridColumn12.Width = 34
      UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
      Me.gridIrisDaten.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
      Me.gridIrisDaten.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
      Me.gridIrisDaten.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
      Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
      Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
      Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
      Appearance2.BorderColor = System.Drawing.SystemColors.Window
      Me.gridIrisDaten.DisplayLayout.GroupByBox.Appearance = Appearance2
      Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
      Me.gridIrisDaten.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
      Me.gridIrisDaten.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
      Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
      Appearance4.BackColor2 = System.Drawing.SystemColors.Control
      Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
      Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
      Me.gridIrisDaten.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
      Me.gridIrisDaten.DisplayLayout.MaxColScrollRegions = 1
      Me.gridIrisDaten.DisplayLayout.MaxRowScrollRegions = 1
      Appearance5.BackColor = System.Drawing.SystemColors.Window
      Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
      Me.gridIrisDaten.DisplayLayout.Override.ActiveCellAppearance = Appearance5
      Appearance6.BackColor = System.Drawing.SystemColors.Highlight
      Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
      Me.gridIrisDaten.DisplayLayout.Override.ActiveRowAppearance = Appearance6
      Me.gridIrisDaten.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
      Me.gridIrisDaten.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
      Appearance7.BackColor = System.Drawing.SystemColors.Window
      Me.gridIrisDaten.DisplayLayout.Override.CardAreaAppearance = Appearance7
      Appearance8.BorderColor = System.Drawing.Color.Silver
      Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
      Me.gridIrisDaten.DisplayLayout.Override.CellAppearance = Appearance8
      Me.gridIrisDaten.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
      Me.gridIrisDaten.DisplayLayout.Override.CellPadding = 0
      Appearance9.BackColor = System.Drawing.SystemColors.Control
      Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
      Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
      Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
      Appearance9.BorderColor = System.Drawing.SystemColors.Window
      Me.gridIrisDaten.DisplayLayout.Override.GroupByRowAppearance = Appearance9
      Appearance10.TextHAlignAsString = "Left"
      Me.gridIrisDaten.DisplayLayout.Override.HeaderAppearance = Appearance10
      Me.gridIrisDaten.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
      Me.gridIrisDaten.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
      Appearance11.BackColor = System.Drawing.SystemColors.Window
      Appearance11.BorderColor = System.Drawing.Color.Silver
      Me.gridIrisDaten.DisplayLayout.Override.RowAppearance = Appearance11
      Me.gridIrisDaten.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
      Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
      Me.gridIrisDaten.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
      Me.gridIrisDaten.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
      Me.gridIrisDaten.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
      Me.gridIrisDaten.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
      Me.gridIrisDaten.Location = New System.Drawing.Point(7, 68)
      Me.gridIrisDaten.Name = "gridIrisDaten"
      Me.gridIrisDaten.Size = New System.Drawing.Size(1216, 618)
      Me.gridIrisDaten.TabIndex = 1
      '
      'btnMischen
      '
      Me.btnMischen.Location = New System.Drawing.Point(206, 11)
      Me.btnMischen.Name = "btnMischen"
      Me.btnMischen.Size = New System.Drawing.Size(160, 40)
      Me.btnMischen.TabIndex = 2
      Me.btnMischen.Text = "Daten mischen und Testdaten separieren"
      '
      'gridIrisTestdaten
      '
      Me.gridIrisTestdaten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.gridIrisTestdaten.DataSource = Me.bsIrisDatensatz
      Appearance13.BackColor = System.Drawing.SystemColors.Window
      Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
      Me.gridIrisTestdaten.DisplayLayout.Appearance = Appearance13
      UltraGridColumn13.Header.VisiblePosition = 0
      UltraGridColumn13.Width = 89
      UltraGridColumn14.Header.VisiblePosition = 1
      UltraGridColumn14.Width = 90
      UltraGridColumn15.Header.VisiblePosition = 2
      UltraGridColumn15.Width = 94
      UltraGridColumn16.Header.VisiblePosition = 3
      UltraGridColumn16.Width = 95
      UltraGridColumn17.Header.VisiblePosition = 4
      UltraGridColumn18.Format = "F2"
      UltraGridColumn18.Header.VisiblePosition = 5
      UltraGridColumn18.Width = 147
      UltraGridColumn19.Format = "F2"
      UltraGridColumn19.Header.VisiblePosition = 6
      UltraGridColumn19.Width = 151
      UltraGridColumn20.Format = "F2"
      UltraGridColumn20.Header.VisiblePosition = 7
      UltraGridColumn20.Width = 154
      UltraGridColumn21.Format = "F2"
      UltraGridColumn21.Header.VisiblePosition = 8
      UltraGridColumn21.Width = 154
      UltraGridColumn22.Header.VisiblePosition = 9
      UltraGridColumn22.Width = 34
      UltraGridColumn23.Header.VisiblePosition = 10
      UltraGridColumn23.Width = 37
      UltraGridColumn24.Header.VisiblePosition = 11
      UltraGridColumn24.Width = 34
      UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24})
      Me.gridIrisTestdaten.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
      Me.gridIrisTestdaten.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
      Me.gridIrisTestdaten.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
      Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
      Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
      Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
      Appearance14.BorderColor = System.Drawing.SystemColors.Window
      Me.gridIrisTestdaten.DisplayLayout.GroupByBox.Appearance = Appearance14
      Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
      Me.gridIrisTestdaten.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
      Me.gridIrisTestdaten.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
      Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
      Appearance16.BackColor2 = System.Drawing.SystemColors.Control
      Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
      Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
      Me.gridIrisTestdaten.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
      Me.gridIrisTestdaten.DisplayLayout.MaxColScrollRegions = 1
      Me.gridIrisTestdaten.DisplayLayout.MaxRowScrollRegions = 1
      Appearance17.BackColor = System.Drawing.SystemColors.Window
      Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
      Me.gridIrisTestdaten.DisplayLayout.Override.ActiveCellAppearance = Appearance17
      Appearance18.BackColor = System.Drawing.SystemColors.Highlight
      Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
      Me.gridIrisTestdaten.DisplayLayout.Override.ActiveRowAppearance = Appearance18
      Me.gridIrisTestdaten.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
      Me.gridIrisTestdaten.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
      Appearance19.BackColor = System.Drawing.SystemColors.Window
      Me.gridIrisTestdaten.DisplayLayout.Override.CardAreaAppearance = Appearance19
      Appearance20.BorderColor = System.Drawing.Color.Silver
      Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
      Me.gridIrisTestdaten.DisplayLayout.Override.CellAppearance = Appearance20
      Me.gridIrisTestdaten.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
      Me.gridIrisTestdaten.DisplayLayout.Override.CellPadding = 0
      Appearance21.BackColor = System.Drawing.SystemColors.Control
      Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
      Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
      Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
      Appearance21.BorderColor = System.Drawing.SystemColors.Window
      Me.gridIrisTestdaten.DisplayLayout.Override.GroupByRowAppearance = Appearance21
      Appearance22.TextHAlignAsString = "Left"
      Me.gridIrisTestdaten.DisplayLayout.Override.HeaderAppearance = Appearance22
      Me.gridIrisTestdaten.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
      Me.gridIrisTestdaten.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
      Appearance23.BackColor = System.Drawing.SystemColors.Window
      Appearance23.BorderColor = System.Drawing.Color.Silver
      Me.gridIrisTestdaten.DisplayLayout.Override.RowAppearance = Appearance23
      Me.gridIrisTestdaten.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
      Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
      Me.gridIrisTestdaten.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
      Me.gridIrisTestdaten.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
      Me.gridIrisTestdaten.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
      Me.gridIrisTestdaten.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
      Me.gridIrisTestdaten.Location = New System.Drawing.Point(7, 692)
      Me.gridIrisTestdaten.Name = "gridIrisTestdaten"
      Me.gridIrisTestdaten.Size = New System.Drawing.Size(1216, 205)
      Me.gridIrisTestdaten.TabIndex = 3
      '
      'btnNetzAnzeigen
      '
      Me.btnNetzAnzeigen.Location = New System.Drawing.Point(400, 11)
      Me.btnNetzAnzeigen.Name = "btnNetzAnzeigen"
      Me.btnNetzAnzeigen.Size = New System.Drawing.Size(160, 40)
      Me.btnNetzAnzeigen.TabIndex = 4
      Me.btnNetzAnzeigen.Text = "Netz anzeigen"
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.Iris1.My.Resources.Resources.Iris_setosa
      Me.PictureBox1.Location = New System.Drawing.Point(1233, 16)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(192, 256)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 5
      Me.PictureBox1.TabStop = False
      '
      'bsIrisDatensatz
      '
      Me.bsIrisDatensatz.DataSource = GetType(Iris1.clsIrisDatensatz)
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(1230, 275)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(86, 17)
      Me.Label1.TabIndex = 6
      Me.Label1.Text = "Iris-Setosa"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(1230, 515)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(99, 17)
      Me.Label2.TabIndex = 8
      Me.Label2.Text = "Iris-Virginica"
      '
      'PictureBox2
      '
      Me.PictureBox2.Image = Global.Iris1.My.Resources.Resources.Iris_virginica
      Me.PictureBox2.Location = New System.Drawing.Point(1233, 317)
      Me.PictureBox2.Name = "PictureBox2"
      Me.PictureBox2.Size = New System.Drawing.Size(239, 195)
      Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox2.TabIndex = 7
      Me.PictureBox2.TabStop = False
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(1230, 849)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(109, 17)
      Me.Label3.TabIndex = 10
      Me.Label3.Text = "Iris-Versicolor"
      '
      'PictureBox3
      '
      Me.PictureBox3.Image = Global.Iris1.My.Resources.Resources.Iris_versicolor
      Me.PictureBox3.Location = New System.Drawing.Point(1233, 570)
      Me.PictureBox3.Name = "PictureBox3"
      Me.PictureBox3.Size = New System.Drawing.Size(219, 276)
      Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox3.TabIndex = 9
      Me.PictureBox3.TabStop = False
      '
      'frmStart
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1489, 894)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.PictureBox3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.PictureBox2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.btnNetzAnzeigen)
      Me.Controls.Add(Me.gridIrisTestdaten)
      Me.Controls.Add(Me.btnMischen)
      Me.Controls.Add(Me.gridIrisDaten)
      Me.Controls.Add(Me.btnDatenEinlesen)
      Me.Name = "frmStart"
      Me.Text = "Iris-Klassifikation"
      CType(Me.gridIrisDaten, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.gridIrisTestdaten, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bsIrisDatensatz, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents btnDatenEinlesen As Infragistics.Win.Misc.UltraButton
   Friend WithEvents gridIrisDaten As Infragistics.Win.UltraWinGrid.UltraGrid
   Friend WithEvents bsIrisDatensatz As BindingSource
   Friend WithEvents btnMischen As Infragistics.Win.Misc.UltraButton
   Friend WithEvents gridIrisTestdaten As Infragistics.Win.UltraWinGrid.UltraGrid
   Friend WithEvents btnNetzAnzeigen As Infragistics.Win.Misc.UltraButton
   Friend WithEvents PictureBox1 As PictureBox
   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents PictureBox2 As PictureBox
   Friend WithEvents Label3 As Label
   Friend WithEvents PictureBox3 As PictureBox
End Class
