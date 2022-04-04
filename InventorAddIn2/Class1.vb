Imports Inventor
Public Class clsFixtureBlock
    Private InvApp As Application
    Private PartDoc As PartDocument
    Private PartDef As PartComponentDefinition
    Private DrawingDoc As DrawingDocument
    Private UOM As UnitsOfMeasure
    'Declaring Local Variables for Dimensions 
    Private _DimHoleToEdge As Double
    Private _DimRadius As Double
    Private _DimHeight As Double
    Private _DimHoleToCutout As Double
    Private _DimBottomCut As Double
    Private _DimWebThick As Double
    Private _DimChamfer As Double
    Private _DimHoleDia As Double
    'Declaring Local Variables for i-Properties
    Private _PartNumber As String
    Private _DrawingNumber As String
    Private _CheckedBy As String
    Private _ApprovedBy As String
    Private _Revision As String
    Private _SheetSize As String
    Private _UnitSystem As String

    'Class constructor (Get or set Inventor)
    Public Sub New()
        'Checking Inventor Opened or not and create or get the Instance
        Try
            InvApp = GetObject(, "Inventor.Application")
        Catch ex As Exception
            InvApp = CreateObject("Inventor.Application")
            InvApp.Visible = True
        End Try
        UOM = InvApp.UnitsOfMeasure
    End Sub
    'Declaring Dimension Variables
    Public Property UnitSystem() As String
        Get
            Return _UnitSystem
        End Get
        Set(ByVal value As String)
            _UnitSystem = value
        End Set
    End Property
    Public Property DimHoleToEdge As Double
        Get
            Return UOM.ConvertUnits(_DimHoleToEdge, UnitSystem, "cm")
        End Get
        Set(value As Double)
            _DimHoleToEdge = value
        End Set
    End Property
    Public Property DimRadius As Double
        Get
            Return UOM.ConvertUnits(_DimRadius, UnitSystem, "cm")
        End Get
        Set(value As Double)
            _DimRadius = value
        End Set
    End Property
    Public Property DimHeight As Double
        Get
            Return UOM.ConvertUnits(_DimHeight, UnitSystem, "cm")
        End Get
        Set(value As Double)
            _DimHeight = value
        End Set
    End Property
    Public Property DimHoleToCutout As Double
        Get
            Return UOM.ConvertUnits(_DimHoleToCutout, UnitSystem, "cm")
        End Get
        Set(value As Double)
            _DimHoleToCutout = value
        End Set
    End Property
    Public Property DimBottomCut As Double
        Get
            Return UOM.ConvertUnits(_DimBottomCut, UnitSystem, "cm")
        End Get
        Set(value As Double)
            _DimBottomCut = value
        End Set
    End Property
    Public Property DimWebThick As Double
        Get
            Return UOM.ConvertUnits(_DimWebThick, UnitSystem, "cm")
        End Get
        Set(value As Double)
            _DimWebThick = value
        End Set
    End Property
    Public Property DimChamfer As Double
        Get
            Return UOM.ConvertUnits(_DimChamfer, UnitSystem, "cm")
        End Get
        Set(value As Double)
            _DimChamfer = value
        End Set
    End Property
    Public Property DimHoleDia As Double
        Get
            Return UOM.ConvertUnits(_DimHoleDia, UnitSystem, "cm")
        End Get
        Set(value As Double)
            _DimHoleDia = value
        End Set
    End Property
    Public Property PartNumber() As String
        Get
            Return _PartNumber
        End Get
        Set(ByVal value As String)
            _PartNumber = value
        End Set
    End Property
    Public Property DrawingNumber() As String
        Get
            Return _DrawingNumber
        End Get
        Set(ByVal value As String)
            _DrawingNumber = value
        End Set
    End Property
    Public Property CheckedBy() As String
        Get
            Return _CheckedBy
        End Get
        Set(ByVal value As String)
            _CheckedBy = value
        End Set
    End Property
    Public Property ApprovedBy() As String
        Get
            Return _ApprovedBy
        End Get
        Set(ByVal value As String)
            _ApprovedBy = value
        End Set
    End Property
    Public Property Revision() As String
        Get
            Return _Revision
        End Get
        Set(ByVal value As String)
            _Revision = value
        End Set
    End Property
    Public Property SheetSize() As String
        Get
            Return _SheetSize
        End Get
        Set(ByVal value As String)
            _SheetSize = value
        End Set
    End Property
    Public Property FileSaveLocation As String
    'Creates Sketch and Create Extrudes
    Sub Extrude()

        'Check for Part Document, If available set the active file else Create New one 
        Try
            PartDoc = InvApp.ActiveDocument
            PartDef = PartDoc.ComponentDefinition
            If PartDef.Features.Count > 0 Then
                'Dim ExistingFeature As PartFeature

                For i As Integer = PartDef.Features.Count To 1 Step -1
                    PartDef.Features.Item(i).Delete()
                Next
            End If
            If PartDef.Sketches.Count > 0 Then
                Dim ExistingSketch As PlanarSketch
                For Each ExistingSketch In PartDef.Sketches
                    ExistingSketch.Delete()
                Next
            End If
        Catch ex As Exception
            PartDoc = InvApp.Documents.Add(DocumentTypeEnum.kPartDocumentObject)
            PartDef = PartDoc.ComponentDefinition
        End Try


        Dim TGeo As TransientGeometry = InvApp.TransientGeometry
        'Creating Sketch1
        Dim MySketch1 As PlanarSketch = PartDef.Sketches.AddWithOrientation(PartDef.WorkPlanes.Item(2), PartDef.WorkAxes.Item(1), True, True, PartDef.WorkPoints.Item(1))
        Dim Orgpoint1 As SketchPoint = MySketch1.AddByProjectingEntity(PartDef.WorkPoints.Item(1))
        'Adding Arc to Sketch1
        Dim MySketch1Arc As SketchArc = MySketch1.SketchArcs.AddByCenterStartSweepAngle(Orgpoint1, DimRadius, (Math.PI / 180) * 90, Math.PI)
        'Adding Lines to Sketch1
        Dim MySketch1Lines(2) As SketchLine
        MySketch1Lines(0) = MySketch1.SketchLines.AddByTwoPoints(MySketch1Arc.EndSketchPoint, TGeo.CreatePoint2d(DimHoleToEdge, -DimRadius))
        MySketch1Lines(1) = MySketch1.SketchLines.AddByTwoPoints(MySketch1Lines(0).EndSketchPoint, TGeo.CreatePoint2d(DimHoleToEdge, DimRadius))
        MySketch1Lines(2) = MySketch1.SketchLines.AddByTwoPoints(MySketch1Lines(1).EndSketchPoint, MySketch1Arc.StartSketchPoint)
        'Adding Constraints To Sketch1
        MySketch1Arc.CenterSketchPoint.Merge(Orgpoint1) 'Merge Arc center point and Origin point
        MySketch1.GeometricConstraints.AddHorizontal(MySketch1Lines(0))
        MySketch1.GeometricConstraints.AddVertical(MySketch1Lines(1))
        MySketch1.GeometricConstraints.AddHorizontal(MySketch1Lines(2))
        MySketch1.GeometricConstraints.AddTangent(MySketch1Arc, MySketch1Lines(0))
        MySketch1.GeometricConstraints.AddTangent(MySketch1Arc, MySketch1Lines(2))

        'Adding Dimensions To Sketch1
        Dim DimenPlacementPoint(10) As Point2d
        DimenPlacementPoint(0) = TGeo.CreatePoint2d(DimHoleToEdge / 2, -(DimRadius + 1))
        MySketch1.DimensionConstraints.AddTwoPointDistance(MySketch1Arc.CenterSketchPoint, MySketch1Lines(0).EndSketchPoint, DimensionOrientationEnum.kHorizontalDim, DimenPlacementPoint(0))
        DimenPlacementPoint(1) = TGeo.CreatePoint2d(-(DimRadius + 1), DimRadius + 1)
        MySketch1.DimensionConstraints.AddRadius(MySketch1Arc, DimenPlacementPoint(1))

        'Creating Extrude1
        Dim ExtrudeProfile As Profile = MySketch1.Profiles.AddForSolid
        Dim ExtrudeDef As ExtrudeDefinition = PartDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(ExtrudeProfile, PartFeatureOperationEnum.kNewBodyOperation)
        ExtrudeDef.SetDistanceExtent(DimHeight, PartFeatureExtentDirectionEnum.kPositiveExtentDirection)
        Dim Extrude1 As ExtrudeFeature = PartDef.Features.ExtrudeFeatures.Add(ExtrudeDef)



        'Creating Chamfer Feature
        Dim ChamferEdges As EdgeCollection = InvApp.TransientObjects.CreateEdgeCollection
        ChamferEdges.Add(Extrude1.SideFaces.Item(2).Edges.Item(2))
        ChamferEdges.Add(Extrude1.SideFaces.Item(2).Edges.Item(4))
        PartDef.Features.ChamferFeatures.AddUsingDistance(ChamferEdges, DimChamfer)

        'Creating Sketch 2
        Dim MySketch2 As PlanarSketch = PartDef.Sketches.Add(PartDef.WorkPlanes.Item(3))
        Dim OrgPoint2 As SketchPoint = MySketch2.AddByProjectingEntity(PartDef.WorkPoints.Item(1))
        Dim MySketch2Rectangle As SketchEntitiesEnumerator = MySketch2.SketchLines.AddAsTwoPointRectangle(TGeo.CreatePoint2d(DimHoleToCutout, DimBottomCut), TGeo.CreatePoint2d(DimHoleToEdge, DimHeight))
        Dim MySketch2RectangleLine1 As SketchLine = MySketch2Rectangle.Item(1)
        Dim MySketch2RectangleLine2 As SketchLine = MySketch2Rectangle.Item(2)
        Dim MySketch2RectangleLine3 As SketchLine = MySketch2Rectangle.Item(3)
        Dim MySketch2RectangleLine4 As SketchLine = MySketch2Rectangle.Item(4)
        Dim MySketch2RectangleCrossLine As SketchLine = MySketch2.SketchLines.AddByTwoPoints(MySketch2RectangleLine4.StartSketchPoint, MySketch2RectangleLine1.EndSketchPoint)

        'Adding Dimensions to the Sketch2
        MySketch2.DimensionConstraints.AddTwoPointDistance(OrgPoint2, MySketch2RectangleLine1.StartSketchPoint, DimensionOrientationEnum.kHorizontalDim, TGeo.CreatePoint2d(DimHoleToCutout / 2, -1))
        MySketch2.DimensionConstraints.AddTwoPointDistance(OrgPoint2, MySketch2RectangleLine1.StartSketchPoint, DimensionOrientationEnum.kVerticalDim, TGeo.CreatePoint2d(DimRadius + 1, DimBottomCut / 2))
        MySketch2.DimensionConstraints.AddTwoPointDistance(OrgPoint2, MySketch2RectangleLine2.EndSketchPoint, DimensionOrientationEnum.kHorizontalDim, TGeo.CreatePoint2d(DimHoleToEdge / 2, DimHeight + 1))
        MySketch2.DimensionConstraints.AddTwoPointDistance(OrgPoint2, MySketch2RectangleLine2.EndSketchPoint, DimensionOrientationEnum.kVerticalDim, TGeo.CreatePoint2d(DimHoleToEdge + 1, DimHeight / 2))

        'Creating Extrude2
        ExtrudeProfile = MySketch2.Profiles.AddForSolid(False)
        ExtrudeDef = PartDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(ExtrudeProfile, PartFeatureOperationEnum.kCutOperation)
        ExtrudeDef.SetThroughAllExtent(PartFeatureExtentDirectionEnum.kSymmetricExtentDirection)
        PartDef.Features.ExtrudeFeatures.Add(ExtrudeDef)

        'Creating WebExtrude
        Dim MySketch2WebLines As ObjectCollection = InvApp.TransientObjects.CreateObjectCollection

        MySketch2WebLines.Add(MySketch2RectangleLine1)
        MySketch2WebLines.Add(MySketch2RectangleCrossLine)
        MySketch2WebLines.Add(MySketch2RectangleLine4)

        ExtrudeProfile = MySketch2.Profiles.AddForSolid(False, MySketch2WebLines)
        ExtrudeDef = PartDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(ExtrudeProfile, PartFeatureOperationEnum.kJoinOperation)
        ExtrudeDef.SetDistanceExtent(DimWebThick, PartFeatureExtentDirectionEnum.kSymmetricExtentDirection)
        PartDef.Features.ExtrudeFeatures.Add(ExtrudeDef)

        'Creating Hole feature
        Dim HoleCentersColl As ObjectCollection = InvApp.TransientObjects.CreateObjectCollection
        HoleCentersColl.Add(Orgpoint1)
        Dim HolePlacement As HolePlacementDefinition = PartDef.Features.HoleFeatures.CreateSketchPlacementDefinition(HoleCentersColl)
        Dim Hole1 As HoleFeature
        Hole1 = PartDef.Features.HoleFeatures.AddDrilledByThroughAllExtent(HolePlacement, DimHoleDia, PartFeatureExtentDirectionEnum.kNegativeExtentDirection)

        'Adding i-Properties
        Call AddiProperties()

        Dim PartCamera As Camera = InvApp.ActiveView.Camera
        PartCamera.ViewOrientationType = ViewOrientationTypeEnum.kIsoTopRightViewOrientation
        PartCamera.Apply()
        PartCamera.Fit()
        PartCamera.Apply()
        PartDoc.Update()


    End Sub
    Private Sub AddiProperties()
        Dim iProperties As PropertySets = PartDoc.PropertySets
        iProperties.Item("Summary Information").ItemByPropId(PropertiesForSummaryInformationEnum.kTitleSummaryInformation).Value = "FIXTURE BLOCK"
        iProperties.Item("Summary Information").ItemByPropId(PropertiesForSummaryInformationEnum.kAuthorSummaryInformation).Value = "SURESHKUMAR S"
        iProperties.Item("Summary Information").ItemByPropId(PropertiesForSummaryInformationEnum.kRevisionSummaryInformation).Value = _Revision
        iProperties.Item("Design Tracking Properties").ItemByPropId(PropertiesForDesignTrackingPropertiesEnum.kPartNumberDesignTrackingProperties).Value = _PartNumber
        iProperties.Item("Design Tracking Properties").ItemByPropId(PropertiesForDesignTrackingPropertiesEnum.kDesignerDesignTrackingProperties).Value = "SS"
        iProperties.Item("Design Tracking Properties").ItemByPropId(PropertiesForDesignTrackingPropertiesEnum.kCreationDateDesignTrackingProperties).Value = Date.Now()
        iProperties.Item("Design Tracking Properties").ItemByPropId(PropertiesForDesignTrackingPropertiesEnum.kCheckedByDesignTrackingProperties).Value = _CheckedBy
        iProperties.Item("Design Tracking Properties").ItemByPropId(PropertiesForDesignTrackingPropertiesEnum.kEngrApprovedByDesignTrackingProperties).Value = _ApprovedBy
    End Sub
    Public Sub Create2Ddrawing()

        PartDoc.SaveAs(FileSaveLocation & "\" & _PartNumber & ".ipt", False)
        Dim TG As TransientGeometry = InvApp.TransientGeometry
        Try
            DrawingDoc = InvApp.Documents.Add(DocumentTypeEnum.kDrawingDocumentObject, "C:\Users\Public\Documents\Autodesk\Inventor 2020\Templates\en-US\My Template.idw")
        Catch ex As Exception
            DrawingDoc = InvApp.Documents.Add(DocumentTypeEnum.kDrawingDocumentObject, "C:\Users\Public\Documents\Autodesk\Inventor 2020\Templates\en-US\Standard.idw")
        End Try

        Dim DwgSheet As Sheet = DrawingDoc.Sheets.Item(1)
        DwgSheet.Size = DrawingSheetSizeEnum.kBDrawingSheetSize

        Dim View As clsViewOrientationAndScale = New clsViewOrientationAndScale(PartDef, InvApp, DrawingDoc)

        'Method That Calculates Scale and X & Y cordinates for Front View
        View.GetValues(ViewOrientationTypeEnum.kFrontViewOrientation)
        Dim MyFrontView As DrawingView = DwgSheet.DrawingViews.AddBaseView(PartDoc, TG.CreatePoint2d(View.ViewCenterX, View.ViewCenterY), View.ScaleValue, ViewOrientationTypeEnum.kFrontViewOrientation, DrawingViewStyleEnum.kHiddenLineDrawingViewStyle)

        'Method That Calculates Scale and X & Y cordinates for Top View
        View.GetValues(ViewOrientationTypeEnum.kTopViewOrientation)
        Dim MyTopView As DrawingView = DwgSheet.DrawingViews.AddProjectedView(MyFrontView, TG.CreatePoint2d(View.ViewCenterX, View.ViewCenterY), DrawingViewStyleEnum.kFromBaseDrawingViewStyle)

        'Method That Calculates Scale and X & Y cordinates for Isometric View
        View.GetValues(ViewOrientationTypeEnum.kIsoTopRightViewOrientation)
        Dim MyIsometricView As DrawingView = DwgSheet.DrawingViews.AddProjectedView(MyFrontView, TG.CreatePoint2d(View.ViewCenterX, View.ViewCenterY), DrawingViewStyleEnum.kShadedDrawingViewStyle, View.ScaleValue)

        'Placing dimension for Front view
        Dim GIntent1 As GeometryIntent = DwgSheet.CreateGeometryIntent(MyFrontView.DrawingCurves.Item(13))
        Dim GIntent2 As GeometryIntent = DwgSheet.CreateGeometryIntent(MyFrontView.DrawingCurves.Item(14))
        DwgSheet.Centerlines.AddBisector(GIntent1, GIntent2)

        GIntent1 = Nothing
        GIntent2 = Nothing

        GIntent1 = DwgSheet.CreateGeometryIntent(MyFrontView.DrawingCurves.Item(5))
        GIntent2 = DwgSheet.CreateGeometryIntent(MyFrontView.DrawingCurves.Item(12))

        Dim PTX As Double = (MyFrontView.DrawingCurves.Item(5).EndPoint.X - MyFrontView.DrawingCurves.Item(12).EndPoint.X) / 2 + MyFrontView.DrawingCurves.Item(12).EndPoint.X
        Dim PTY As Double = MyFrontView.DrawingCurves.Item(5).StartPoint.Y - 1

        DwgSheet.DrawingDimensions.GeneralDimensions.AddLinear(TG.CreatePoint2d(PTX, PTY), GIntent1, GIntent2)

        PTX = MyFrontView.DrawingCurves.Item(12).EndPoint.X - 1
        PTY = MyFrontView.DrawingCurves.Item(12).MidPoint.Y

        DwgSheet.DrawingDimensions.GeneralDimensions.AddLinear(TG.CreatePoint2d(PTX, PTY), GIntent2)

        PTX = MyFrontView.DrawingCurves.Item(5).EndPoint.X + 1
        PTY = MyFrontView.DrawingCurves.Item(5).MidPoint.Y

        DwgSheet.DrawingDimensions.GeneralDimensions.AddLinear(TG.CreatePoint2d(PTX, PTY), GIntent1)

        'Placing dimension for TOP View
        GIntent1 = Nothing
        GIntent2 = Nothing

        GIntent1 = DwgSheet.CreateGeometryIntent(MyTopView.DrawingCurves.Item(1))
        GIntent2 = DwgSheet.CreateGeometryIntent(MyTopView.DrawingCurves.Item(12))

        Dim CenterM As Centermark = DwgSheet.Centermarks.Add(GIntent1)

        Dim GIntent3 As GeometryIntent = DwgSheet.CreateGeometryIntent(CenterM)

        PTX = MyTopView.DrawingCurves.Item(14).MidPoint.X
        PTY = MyTopView.DrawingCurves.Item(14).MidPoint.Y + 1

        DwgSheet.DrawingDimensions.GeneralDimensions.AddLinear(TG.CreatePoint2d(PTX, PTY), GIntent2, GIntent3)

        Dim Point1 As Point2d = TG.CreatePoint2d(MyTopView.DrawingCurves.Item(1).CenterPoint.X, MyTopView.DrawingCurves.Item(1).CenterPoint.Y)
        Dim Point2 As Point2d = TG.CreatePoint2d(MyTopView.DrawingCurves.Item(14).EndPoint.X, MyTopView.DrawingCurves.Item(14).EndPoint.Y)
        Dim Vector1 As Vector2d = Point1.VectorTo(Point2)

        Dim MyMatrix As Matrix2d = TG.CreateMatrix2d()

        MyMatrix.SetToRotation((Math.PI / 180) * 45, Point1)
        Vector1.TransformBy(MyMatrix)
        Vector1.ScaleBy(1.5)
        Point1.TranslateBy(Vector1)

        GIntent1 = DwgSheet.CreateGeometryIntent(MyTopView.DrawingCurves.Item(16))

        'Adding Radius
        DwgSheet.DrawingDimensions.GeneralDimensions.AddRadius(Point1, GIntent1, True, True)
        MyMatrix.SetToRotation((Math.PI / 180) * 135, Point1)
        Vector1.TransformBy(MyMatrix)
        Vector1.ScaleBy(1.5)
        Point1.TranslateBy(Vector1)
        GIntent1 = DwgSheet.CreateGeometryIntent(MyTopView.DrawingCurves.Item(1))

        'Adding Diameter
        DwgSheet.DrawingDimensions.GeneralDimensions.AddDiameter(Point1, GIntent1, True, True, False)
        GIntent1 = DwgSheet.CreateGeometryIntent(MyTopView.DrawingCurves.Item(5))
        PTX = MyTopView.DrawingCurves.Item(5).MidPoint.X + 1
        PTY = MyTopView.DrawingCurves.Item(5).MidPoint.Y
        DwgSheet.DrawingDimensions.GeneralDimensions.AddLinear(TG.CreatePoint2d(PTX, PTY), GIntent1)

        'Adding Chamfer Note
        Point1 = TG.CreatePoint2d(MyTopView.DrawingCurves.Item(10).MidPoint.X, MyTopView.DrawingCurves.Item(10).MidPoint.Y)
        Point2 = TG.CreatePoint2d(MyTopView.DrawingCurves.Item(10).EndPoint.X, MyTopView.DrawingCurves.Item(10).EndPoint.Y)
        Vector1 = Point1.VectorTo(Point2)
        MyMatrix.SetToRotation((Math.PI / 180) * 90, Point1)
        Vector1.TransformBy(MyMatrix)
        Vector1.ScaleBy(3)
        Point1.TranslateBy(Vector1)
        DwgSheet.DrawingNotes.ChamferNotes.Add(Point1, MyTopView.DrawingCurves.Item(10), MyTopView.DrawingCurves.Item(9))

        'Adding Drawing Number to Drawing Document
        Dim iPropertiesDrawing As PropertySets = DrawingDoc.PropertySets
        Dim DrawingNumbwerProperty As [Property] = iPropertiesDrawing.Item("User Defined Properties").Add(_DrawingNumber, "DRAWING NUMBER")
        DrawingNumbwerProperty.Value = _DrawingNumber
        Dim UnitProperty As [Property] = iPropertiesDrawing.Item("User Defined Properties").Add(_DrawingNumber, "UNIT")
        UnitProperty.Value = _UnitSystem

        Dim CurrentDimensionStyle As DimensionStyle = DrawingDoc.ActiveSheet.DrawingDimensions.GeneralDimensions.Item(1).Style

        'Changing Drawing Unit System
        Select Case _UnitSystem
            Case "mm"
                CurrentDimensionStyle.LinearUnits = UnitsTypeEnum.kMillimeterLengthUnits
                CurrentDimensionStyle.LinearPrecision = LinearPrecisionEnum.kThreeDecimalPlacesLinearPrecision
            Case "cm"
                CurrentDimensionStyle.LinearUnits = UnitsTypeEnum.kCentimeterLengthUnits
                CurrentDimensionStyle.LinearPrecision = LinearPrecisionEnum.kThreeDecimalPlacesLinearPrecision
            Case Else
                CurrentDimensionStyle.LinearUnits = UnitsTypeEnum.kInchLengthUnits
                CurrentDimensionStyle.LinearPrecision = LinearPrecisionEnum.kThreeDecimalPlacesLinearPrecision
        End Select
        Dim NotesPoint As Point2d = InvApp.TransientGeometry.CreatePoint2d(31.2, 12)
        Dim Notes As GeneralNote = DrawingDoc.ActiveSheet.DrawingNotes.GeneralNotes.AddFitted(NotesPoint, DrawingNotes)
        Notes.LineSpacing = 1.5
        DrawingDoc.Update()
    End Sub
    Private Function DrawingNotes() As String
        Dim Notes As String
        Notes = "<StyleOverride Underline='True'>NOTES:</StyleOverride><Br/><Numbering Format='1'>MATERIAL: STEEL.</Numbering><Numbering Format='1'>ALL HOLES MUST BE DRILLED.</Numbering><Numbering Format='1'>DEBUR ALL SHARP EDGES.</Numbering><Numbering Format='1'>STANDARD TOLERANCE APPLICABLE.</Numbering>"
        Return Notes
    End Function
    Private Class clsViewOrientationAndScale
        Public Property ScaleValue As Double
        Public Property ViewCenterX As Double
        Public Property ViewCenterY As Double
        Private PartDef As PartComponentDefinition
        Private InvApp As Inventor.Application
        Private DrawingDoc As DrawingDocument

        Public Sub New(PartDefinition As PartComponentDefinition, InventorApp As Application, DrawingDocument As DrawingDocument)
            PartDef = PartDefinition
            InvApp = InventorApp
            DrawingDoc = DrawingDocument
        End Sub

        Public Sub GetValues(View As ViewOrientationTypeEnum)

            Dim ModelDimX As Double = Math.Abs((PartDef.RangeBox.MinPoint.X - PartDef.RangeBox.MaxPoint.X))
            Dim ModelDimY As Double = Math.Abs((PartDef.RangeBox.MinPoint.Y - PartDef.RangeBox.MaxPoint.Y))
            Dim ModelDimZ As Double = Math.Abs((PartDef.RangeBox.MinPoint.Z - PartDef.RangeBox.MaxPoint.Z))

            Dim BorderZone As Box2d = InvApp.TransientGeometry.CreateBox2d()
            BorderZone.MinPoint = DrawingDoc.ActiveSheet.Border.RangeBox.MinPoint
            BorderZone.MaxPoint = DrawingDoc.ActiveSheet.Border.RangeBox.MaxPoint

            Dim FrontViewZone As Box2d = InvApp.TransientGeometry.CreateBox2d()
            Dim ZoneMaxX As Double = (BorderZone.MaxPoint.X - BorderZone.MinPoint.X) * (4 / 8) + BorderZone.MinPoint.X
            Dim ZoneMaxY As Double = (BorderZone.MaxPoint.Y - BorderZone.MinPoint.Y) * (1 / 2) + BorderZone.MinPoint.Y
            FrontViewZone.MinPoint = BorderZone.MinPoint
            FrontViewZone.MaxPoint = InvApp.TransientGeometry.CreatePoint2d(ZoneMaxX, ZoneMaxY)

            Dim TopViewZone As Box2d = InvApp.TransientGeometry.CreateBox2d()
            ZoneMaxY = BorderZone.MaxPoint.Y
            Dim ZoneMinX As Double = BorderZone.MinPoint.X
            Dim ZoneMinY As Double = (BorderZone.MaxPoint.Y - BorderZone.MinPoint.Y) * (1 / 2) + BorderZone.MinPoint.Y
            TopViewZone.MinPoint = InvApp.TransientGeometry.CreatePoint2d(ZoneMinX, ZoneMinY)
            TopViewZone.MaxPoint = InvApp.TransientGeometry.CreatePoint2d(ZoneMaxX, ZoneMaxY)

            Dim IsoViewZone As Box2d = InvApp.TransientGeometry.CreateBox2d()
            ZoneMinX = (BorderZone.MaxPoint.X - BorderZone.MinPoint.X) * (4 / 8) + BorderZone.MinPoint.X
            ZoneMinY = (BorderZone.MaxPoint.Y - BorderZone.MinPoint.Y) * (1 / 2) + BorderZone.MinPoint.Y
            IsoViewZone.MinPoint = InvApp.TransientGeometry.CreatePoint2d(ZoneMinX, ZoneMinY)
            IsoViewZone.MaxPoint = BorderZone.MaxPoint
            Dim ZoneX As Double
            Dim ZoneY As Double
            Dim SFactor As Double = 0.70
            If View = ViewOrientationTypeEnum.kFrontViewOrientation Then
                ZoneX = FrontViewZone.MaxPoint.X - FrontViewZone.MinPoint.X
                ZoneY = FrontViewZone.MaxPoint.Y - FrontViewZone.MinPoint.Y
                If ModelDimX > ModelDimY Then
                    ScaleValue = (ZoneX * SFactor) / ModelDimX
                    ViewCenterX = ZoneX / 2 + BorderZone.MinPoint.X
                    ViewCenterY = ZoneY / 2 + BorderZone.MinPoint.Y

                Else
                    ScaleValue = (ZoneY * SFactor) / ModelDimY
                    ViewCenterX = ZoneX / 2 + BorderZone.MinPoint.X
                    ViewCenterY = ZoneY / 2 + BorderZone.MinPoint.Y

                End If
            ElseIf View = ViewOrientationTypeEnum.kTopViewOrientation Then
                ZoneX = TopViewZone.MaxPoint.X - TopViewZone.MinPoint.X
                ZoneY = TopViewZone.MaxPoint.Y - TopViewZone.MinPoint.Y
                If ModelDimY > ModelDimZ Then
                    ScaleValue = (ZoneX * SFactor) / ModelDimX
                    ViewCenterX = ZoneX / 2 + BorderZone.MinPoint.X
                    ViewCenterY = ZoneY / 2 + FrontViewZone.MaxPoint.Y
                Else
                    ScaleValue = (ZoneY * SFactor) / ModelDimY
                    ViewCenterX = ZoneX / 2 + BorderZone.MinPoint.X
                    ViewCenterY = ZoneY / 2 + FrontViewZone.MaxPoint.Y
                End If
            ElseIf View = ViewOrientationTypeEnum.kIsoTopRightViewOrientation Then
                ZoneX = IsoViewZone.MaxPoint.X - IsoViewZone.MinPoint.X
                ZoneY = IsoViewZone.MaxPoint.Y - IsoViewZone.MinPoint.Y
                ScaleValue = (ZoneX * SFactor) / ModelDimX
                ViewCenterX = ZoneX / 2 + IsoViewZone.MinPoint.X
                ViewCenterY = ZoneY / 2 + IsoViewZone.MinPoint.Y
            End If
        End Sub

    End Class
    Public Sub ExportPDF()
        Dim InvApp As Inventor.Application = GetObject(, "Inventor.Application")
        Dim PDFAddin As TranslatorAddIn = InvApp.ApplicationAddIns.ItemById("{0AC6FD96-2F4D-42CE-8BE0-8AEA580399E4}")
        Dim Context As TranslationContext = InvApp.TransientObjects.CreateTranslationContext()
        Context.Type = IOMechanismEnum.kFileBrowseIOMechanism
        Dim Options As NameValueMap = InvApp.TransientObjects.CreateNameValueMap()
        Dim TargetData As DataMedium = InvApp.TransientObjects.CreateDataMedium()
        TargetData.FileName = _DrawingNumber & ".pdf"
        PDFAddin.SaveCopyAs(DrawingDoc, Context, Options, TargetData)

    End Sub
End Class


