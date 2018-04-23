Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars
Imports System.ComponentModel
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraEditors

Namespace CustomDraw
	<System.ComponentModel.DesignerCategory("")> _
	Public Class CustomBarAndDockingController
		Inherits BarAndDockingController
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)
		End Sub

		Public Sub New()
		End Sub

		Protected Overrides Sub RegisterPaintStyles()
			MyBase.RegisterPaintStyles()
			ReplaceSkinPaintStyle()
		End Sub

		Private Sub ReplaceSkinPaintStyle()
			Dim defaultSkinPaintStyleIndex As Integer = GetDefaultSkinPaintStyleIndex()
			PaintStyles.RemoveAt(defaultSkinPaintStyleIndex)
			Dim ps As New CustomSkinBarManagerPaintStyle(PaintStyles)
			PaintStyles.Add(ps)
		End Sub

		Private Function GetDefaultSkinPaintStyleIndex() As Integer
			Dim defaultSkinPaintStyleIndex As Integer = 0
			For i As Integer = 0 To PaintStyles.Count - 1
				If PaintStyles(i).GetType() Is GetType(SkinBarManagerPaintStyle) Then
					defaultSkinPaintStyleIndex = i
					Exit For
				End If
			Next i
			Return defaultSkinPaintStyleIndex
		End Function

		Public Delegate Sub CustomDrawEventHandler(ByVal sender As Object, ByVal e As CustomDrawLinkArgs)

		<DXCategory("Events")> _
		Public Event CustomDraw As CustomDrawEventHandler

		Protected Friend Overridable Sub RaiseCustomDraw(ByVal e As CustomDrawLinkArgs)
			RaiseEvent CustomDraw(Me, e)
		End Sub
	End Class
End Namespace