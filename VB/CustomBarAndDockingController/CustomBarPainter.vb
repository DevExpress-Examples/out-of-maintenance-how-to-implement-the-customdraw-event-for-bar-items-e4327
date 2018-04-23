Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars.Painters
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.Utils.Drawing

Namespace CustomDraw
	Friend Class CustomBarPainter
		Inherits SkinBarPainter
		Public Sub New(ByVal paintStyle As BarManagerPaintStyle)
			MyBase.New(paintStyle)
		End Sub

		Protected Overrides Sub DrawLink(ByVal e As GraphicsInfoArgs, ByVal viewInfo As BarControlViewInfo, ByVal item As BarLinkViewInfo)
			Dim info As New BarLinkObjectInfoArgs(item) With {.Cache = e.Cache}
			Dim args As New CustomDrawLinkArgs(info)
			Dim controller As CustomBarAndDockingController = TryCast(item.Bar.Manager.Controller, CustomBarAndDockingController)
			If controller IsNot Nothing Then
				args.SetDefaultDraw(Function() AnonymousMethod1(e, viewInfo, item))
				controller.RaiseCustomDraw(args)
			End If
			If (Not args.Handled) Then
				args.DefaultDraw()
			End If
		End Sub
		
		Private Function AnonymousMethod1(ByVal e As GraphicsInfoArgs, ByVal viewInfo As BarControlViewInfo, ByVal item As BarLinkViewInfo) As Boolean
			MyBase.DrawLink(e, viewInfo, item)
			Return True
		End Function
	End Class
End Namespace
