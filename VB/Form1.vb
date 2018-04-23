Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace CustomDraw
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub customBarAndDockingController1_CustomDraw(ByVal sender As Object, ByVal e As CustomDrawLinkArgs) Handles customBarAndDockingController1.CustomDraw
			e.DefaultDraw()
			Dim itemCaption As String = e.Info.LinkInfo.Link.Item.Caption
			If itemCaption = "Green item" Then
				Using p As New Pen(Color.ForestGreen) With {.Width = 3}
					e.Graphics.DrawRectangle(p, e.Info.LinkInfo.CaptionRect)
				End Using
			End If
			If itemCaption = "See Messages   " Then
				Dim side As Integer = 15
				Dim iconRect As New Rectangle(e.Bounds.Right - side, e.Bounds.Y,side, side)
				e.Graphics.FillEllipse(Brushes.IndianRed, iconRect)
				Dim p As New Point(iconRect.Location.X + 2, iconRect.Location.Y)
				e.Graphics.DrawString(spinEdit1.Value.ToString(), e.Info.LinkInfo.AppearanceMenuItemCaption.Normal.Font, Brushes.White, p)
			End If
			If itemCaption = "Static text" Then
				Using br As New SolidBrush(Color.FromArgb(100, 50, 200, 50))
					e.Graphics.FillRectangle(br, e.Info.LinkInfo.Bounds)
				End Using
			End If
			e.Handled = True
		End Sub

		Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEdit1.EditValueChanged
			barButtonItem2.Refresh()
		End Sub
	End Class
End Namespace
