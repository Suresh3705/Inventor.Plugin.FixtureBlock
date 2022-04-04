<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsUserForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TB_HoleToEdge = New System.Windows.Forms.TextBox()
        Me.TB_HoleToCutout = New System.Windows.Forms.TextBox()
        Me.TB_HoleDia = New System.Windows.Forms.TextBox()
        Me.TB_Radius = New System.Windows.Forms.TextBox()
        Me.TB_WebThick = New System.Windows.Forms.TextBox()
        Me.TB_Height = New System.Windows.Forms.TextBox()
        Me.TB_BottomCut = New System.Windows.Forms.TextBox()
        Me.TB_Chamfer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ModelButton = New System.Windows.Forms.Button()
        Me.DrawingButton = New System.Windows.Forms.Button()
        Me.cbxUnitSystem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.txtDrawingNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRevision = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDrawnBy = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCheckedBy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApprovedBy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxSheetSize = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_HoleToEdge
        '
        Me.TB_HoleToEdge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_HoleToEdge.CausesValidation = False
        Me.TB_HoleToEdge.Location = New System.Drawing.Point(667, 102)
        Me.TB_HoleToEdge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_HoleToEdge.Name = "TB_HoleToEdge"
        Me.TB_HoleToEdge.Size = New System.Drawing.Size(61, 22)
        Me.TB_HoleToEdge.TabIndex = 8
        '
        'TB_HoleToCutout
        '
        Me.TB_HoleToCutout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_HoleToCutout.CausesValidation = False
        Me.TB_HoleToCutout.Location = New System.Drawing.Point(522, 146)
        Me.TB_HoleToCutout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_HoleToCutout.Name = "TB_HoleToCutout"
        Me.TB_HoleToCutout.Size = New System.Drawing.Size(61, 22)
        Me.TB_HoleToCutout.TabIndex = 13
        '
        'TB_HoleDia
        '
        Me.TB_HoleDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_HoleDia.CausesValidation = False
        Me.TB_HoleDia.Location = New System.Drawing.Point(317, 188)
        Me.TB_HoleDia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_HoleDia.Name = "TB_HoleDia"
        Me.TB_HoleDia.Size = New System.Drawing.Size(61, 22)
        Me.TB_HoleDia.TabIndex = 11
        '
        'TB_Radius
        '
        Me.TB_Radius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Radius.CausesValidation = False
        Me.TB_Radius.Location = New System.Drawing.Point(317, 390)
        Me.TB_Radius.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_Radius.Name = "TB_Radius"
        Me.TB_Radius.Size = New System.Drawing.Size(61, 22)
        Me.TB_Radius.TabIndex = 12
        '
        'TB_WebThick
        '
        Me.TB_WebThick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_WebThick.CausesValidation = False
        Me.TB_WebThick.Location = New System.Drawing.Point(932, 288)
        Me.TB_WebThick.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_WebThick.Name = "TB_WebThick"
        Me.TB_WebThick.Size = New System.Drawing.Size(61, 22)
        Me.TB_WebThick.TabIndex = 9
        '
        'TB_Height
        '
        Me.TB_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Height.CausesValidation = False
        Me.TB_Height.Location = New System.Drawing.Point(317, 551)
        Me.TB_Height.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_Height.Name = "TB_Height"
        Me.TB_Height.Size = New System.Drawing.Size(61, 22)
        Me.TB_Height.TabIndex = 15
        '
        'TB_BottomCut
        '
        Me.TB_BottomCut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_BottomCut.CausesValidation = False
        Me.TB_BottomCut.Location = New System.Drawing.Point(932, 621)
        Me.TB_BottomCut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_BottomCut.Name = "TB_BottomCut"
        Me.TB_BottomCut.Size = New System.Drawing.Size(61, 22)
        Me.TB_BottomCut.TabIndex = 14
        '
        'TB_Chamfer
        '
        Me.TB_Chamfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Chamfer.CausesValidation = False
        Me.TB_Chamfer.Location = New System.Drawing.Point(911, 401)
        Me.TB_Chamfer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_Chamfer.Name = "TB_Chamfer"
        Me.TB_Chamfer.Size = New System.Drawing.Size(61, 22)
        Me.TB_Chamfer.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(793, 691)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Export PDF"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ModelButton
        '
        Me.ModelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ModelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ModelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ModelButton.FlatAppearance.BorderSize = 0
        Me.ModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModelButton.ForeColor = System.Drawing.Color.White
        Me.ModelButton.Location = New System.Drawing.Point(317, 691)
        Me.ModelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ModelButton.Name = "ModelButton"
        Me.ModelButton.Size = New System.Drawing.Size(199, 43)
        Me.ModelButton.TabIndex = 16
        Me.ModelButton.Text = "Create Model"
        Me.ModelButton.UseVisualStyleBackColor = False
        '
        'DrawingButton
        '
        Me.DrawingButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DrawingButton.FlatAppearance.BorderSize = 0
        Me.DrawingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DrawingButton.ForeColor = System.Drawing.Color.White
        Me.DrawingButton.Location = New System.Drawing.Point(555, 691)
        Me.DrawingButton.Name = "DrawingButton"
        Me.DrawingButton.Size = New System.Drawing.Size(199, 43)
        Me.DrawingButton.TabIndex = 17
        Me.DrawingButton.Text = "Create Drawing"
        Me.DrawingButton.UseVisualStyleBackColor = False
        '
        'cbxUnitSystem
        '
        Me.cbxUnitSystem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cbxUnitSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUnitSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxUnitSystem.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUnitSystem.FormattingEnabled = True
        Me.cbxUnitSystem.Location = New System.Drawing.Point(27, 43)
        Me.cbxUnitSystem.Name = "cbxUnitSystem"
        Me.cbxUnitSystem.Size = New System.Drawing.Size(210, 27)
        Me.cbxUnitSystem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unit System:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Part Number:"
        '
        'txtPartNumber
        '
        Me.txtPartNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartNumber.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartNumber.Location = New System.Drawing.Point(27, 101)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(210, 27)
        Me.txtPartNumber.TabIndex = 2
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrawingNumber.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrawingNumber.Location = New System.Drawing.Point(27, 159)
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(210, 27)
        Me.txtDrawingNumber.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Drawing Number:"
        '
        'txtRevision
        '
        Me.txtRevision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRevision.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRevision.Location = New System.Drawing.Point(27, 217)
        Me.txtRevision.Name = "txtRevision"
        Me.txtRevision.Size = New System.Drawing.Size(210, 27)
        Me.txtRevision.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Revision:"
        '
        'txtDrawnBy
        '
        Me.txtDrawnBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrawnBy.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrawnBy.Location = New System.Drawing.Point(27, 275)
        Me.txtDrawnBy.Name = "txtDrawnBy"
        Me.txtDrawnBy.Size = New System.Drawing.Size(210, 27)
        Me.txtDrawnBy.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Drawn By:"
        '
        'txtCheckedBy
        '
        Me.txtCheckedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCheckedBy.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckedBy.Location = New System.Drawing.Point(27, 333)
        Me.txtCheckedBy.Name = "txtCheckedBy"
        Me.txtCheckedBy.Size = New System.Drawing.Size(210, 27)
        Me.txtCheckedBy.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Checked By:"
        '
        'txtApprovedBy
        '
        Me.txtApprovedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApprovedBy.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedBy.Location = New System.Drawing.Point(27, 391)
        Me.txtApprovedBy.Name = "txtApprovedBy"
        Me.txtApprovedBy.Size = New System.Drawing.Size(210, 27)
        Me.txtApprovedBy.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Approved By:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(26, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Sheet Size:"
        Me.Label8.Visible = False
        '
        'cbxSheetSize
        '
        Me.cbxSheetSize.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cbxSheetSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSheetSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxSheetSize.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSheetSize.FormattingEnabled = True
        Me.cbxSheetSize.Location = New System.Drawing.Point(27, 449)
        Me.cbxSheetSize.Name = "cbxSheetSize"
        Me.cbxSheetSize.Size = New System.Drawing.Size(210, 27)
        Me.cbxSheetSize.TabIndex = 26
        Me.cbxSheetSize.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SureshAddIn.My.Resources.Resources.Fixture_Block_UI_Image
        Me.PictureBox1.Location = New System.Drawing.Point(275, 47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(757, 672)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 47)
        Me.Panel1.TabIndex = 27
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(991, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(47, 47)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cbxUnitSystem)
        Me.Panel2.Controls.Add(Me.cbxSheetSize)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtApprovedBy)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtPartNumber)
        Me.Panel2.Controls.Add(Me.txtCheckedBy)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtDrawingNumber)
        Me.Panel2.Controls.Add(Me.txtDrawnBy)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtRevision)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 711)
        Me.Panel2.TabIndex = 28
        '
        'clsUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(1038, 758)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DrawingButton)
        Me.Controls.Add(Me.ModelButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_Chamfer)
        Me.Controls.Add(Me.TB_BottomCut)
        Me.Controls.Add(Me.TB_Height)
        Me.Controls.Add(Me.TB_WebThick)
        Me.Controls.Add(Me.TB_Radius)
        Me.Controls.Add(Me.TB_HoleDia)
        Me.Controls.Add(Me.TB_HoleToCutout)
        Me.Controls.Add(Me.TB_HoleToEdge)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "clsUserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fixture Block"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents TB_HoleToEdge As Windows.Forms.TextBox
    Friend WithEvents TB_HoleToCutout As Windows.Forms.TextBox
    Friend WithEvents TB_HoleDia As Windows.Forms.TextBox
    Friend WithEvents TB_Radius As Windows.Forms.TextBox
    Friend WithEvents TB_WebThick As Windows.Forms.TextBox
    Friend WithEvents TB_Height As Windows.Forms.TextBox
    Friend WithEvents TB_BottomCut As Windows.Forms.TextBox
    Friend WithEvents TB_Chamfer As Windows.Forms.TextBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TB_HoleToEdge.Text = 6
        TB_HoleToCutout.Text = 1.8
        TB_HoleDia.Text = 1.5
        TB_Radius.Text = 1.5
        TB_WebThick.Text = 1
        TB_Height.Text = 3
        TB_BottomCut.Text = 1
        TB_Chamfer.Text = 0.5
    End Sub

    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents ModelButton As Windows.Forms.Button
    Friend WithEvents DrawingButton As Windows.Forms.Button
    Friend WithEvents cbxUnitSystem As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtPartNumber As Windows.Forms.TextBox
    Friend WithEvents txtDrawingNumber As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtRevision As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtDrawnBy As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtCheckedBy As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtApprovedBy As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents cbxSheetSize As Windows.Forms.ComboBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents BtnClose As Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As Windows.Forms.FolderBrowserDialog
End Class
