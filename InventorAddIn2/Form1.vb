
Public Class clsUserForm
    Private Fixtureblock As clsFixtureBlock = New clsFixtureBlock
    Private Sub ModelButton_Click(sender As Object, e As EventArgs) Handles ModelButton.Click
        Me.Hide()
        'Setting Dimensional Vaules to the Class
        Fixtureblock.UnitSystem = cbxUnitSystem.SelectedItem
        Fixtureblock.DimHoleToEdge = TB_HoleToEdge.Text
        Fixtureblock.DimRadius = TB_Radius.Text
        Fixtureblock.DimHeight = TB_Height.Text
        Fixtureblock.DimHoleToCutout = TB_HoleToCutout.Text
        Fixtureblock.DimBottomCut = TB_BottomCut.Text
        Fixtureblock.DimWebThick = TB_WebThick.Text
        Fixtureblock.DimChamfer = TB_Chamfer.Text
        Fixtureblock.DimHoleDia = TB_HoleDia.Text
        'Setting i-Properties to the Class
        Fixtureblock.PartNumber = txtPartNumber.Text
        Fixtureblock.DrawingNumber = txtDrawingNumber.Text
        Fixtureblock.CheckedBy = txtCheckedBy.Text
        Fixtureblock.ApprovedBy = txtApprovedBy.Text
        Fixtureblock.Revision = txtRevision.Text
        Fixtureblock.SheetSize = cbxSheetSize.SelectedItem
        Fixtureblock.Extrude()
        Me.Show()
    End Sub

    Private Sub DrawingButton_Click(sender As Object, e As EventArgs) Handles DrawingButton.Click
        Me.Hide()
        FolderBrowserDialog1.ShowDialog()
        Fixtureblock.FileSaveLocation = FolderBrowserDialog1.SelectedPath
        Fixtureblock.Create2Ddrawing()
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Fixtureblock.ExportPDF()
        Me.Close()
    End Sub

    Private Sub clsUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxUnitSystem.DataSource = {"in", "cm", "mm"}
        cbxSheetSize.DataSource = {"A", "B", "C", "D"}
        txtPartNumber.Text = "FB-12345"
        txtDrawingNumber.Text = "MM-12345"
        txtDrawnBy.Text = "SS"
        txtCheckedBy.Text = "XX"
        txtApprovedBy.Text = "YY"
        txtRevision.Text = "00"
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class