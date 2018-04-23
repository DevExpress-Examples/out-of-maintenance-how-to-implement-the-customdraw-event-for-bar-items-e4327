Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars.Painters
Imports System.Drawing
Imports System.Windows.Forms

Namespace CustomDraw
	Public Class CustomDrawLinkArgs
		Inherits EventArgs
		Private defaultDraw_Renamed As MethodInvoker
		Private info_Renamed As BarLinkObjectInfoArgs
		Public ReadOnly Property Info() As BarLinkObjectInfoArgs
			Get
				Return info_Renamed
			End Get
		End Property
		Private privateHandled As Boolean
		Public Property Handled() As Boolean
			Get
				Return privateHandled
			End Get
			Set(ByVal value As Boolean)
				privateHandled = value
			End Set
		End Property
		Public ReadOnly Property Graphics() As Graphics
			Get
				Return info_Renamed.Graphics
			End Get
		End Property
		Public ReadOnly Property Bounds() As Rectangle
			Get
				Return Info.Bounds
			End Get
		End Property
		Public Sub New(ByVal barLinkInfo As BarLinkObjectInfoArgs)
			info_Renamed = barLinkInfo
		End Sub
		Friend Sub SetDefaultDraw(ByVal defaultDraw As MethodInvoker)
			Me.defaultDraw_Renamed = defaultDraw
		End Sub
		Public Sub DefaultDraw()
			If defaultDraw_Renamed IsNot Nothing AndAlso (Not Handled) Then
				Handled = True
				defaultDraw_Renamed()
			End If
		End Sub
	End Class
End Namespace