Imports Microsoft.VisualBasic
Imports System
Namespace CustomDraw
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
            Me.customBarAndDockingController1 = New CustomBarAndDockingController(Me.components)
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.customBarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customBarAndDockingController1
			' 
			Me.customBarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
			Me.customBarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
'			Me.customBarAndDockingController1.CustomDraw += New CustomDraw.CustomBarAndDockingController.CustomDrawEventHandler(Me.customBarAndDockingController1_CustomDraw);
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
			Me.barManager1.Controller = Me.customBarAndDockingController1
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2, Me.barStaticItem1})
			Me.barManager1.MainMenu = Me.bar2
			Me.barManager1.MaxItemId = 3
			Me.barManager1.StatusBar = Me.bar3
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 1
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2)})
			Me.bar1.Text = "Tools"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "See Messages   "
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1)})
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Green item"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1)})
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Caption = "Static text"
			Me.barStaticItem1.Id = 2
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(508, 51)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 192)
			Me.barDockControlBottom.Size = New System.Drawing.Size(508, 25)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 141)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(508, 51)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 141)
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(84, 57)
			Me.spinEdit1.MenuManager = Me.barManager1
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.spinEdit1.Properties.IsFloatValue = False
			Me.spinEdit1.Properties.Mask.EditMask = "N00"
			Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() { 9, 0, 0, 0})
			Me.spinEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.spinEdit1.Size = New System.Drawing.Size(40, 20)
			Me.spinEdit1.TabIndex = 4
'			Me.spinEdit1.EditValueChanged += New System.EventHandler(Me.spinEdit1_EditValueChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(508, 217)
			Me.Controls.Add(Me.spinEdit1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.customBarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents customBarAndDockingController1 As CustomBarAndDockingController
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem




	End Class
End Namespace

