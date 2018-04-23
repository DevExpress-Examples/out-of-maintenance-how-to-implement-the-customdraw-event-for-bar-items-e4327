Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.Painters
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraBars.Controls

Namespace CustomDraw
	Public Class CustomSkinBarManagerPaintStyle
		Inherits SkinBarManagerPaintStyle
		Public Sub New(ByVal collection As BarManagerPaintStyleCollection)
			MyBase.New(collection)
		End Sub

		Protected Overrides Sub RegisterBarInfo()
			BarInfoCollection.Add(New BarControlInfo("BarDockControl", GetType(BarDockControl), GetType(DockControlOffice2003ViewInfo), New DockControlOffice2003Painter(Me)))
			BarInfoCollection.Add(New BarControlInfo("BarControl", GetType(CustomControl), GetType(BarControlViewInfo), New CustomBarPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("DockedBarControl", GetType(DockedBarControl), GetType(SkinDockedBarControlViewInfo), New CustomBarPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("SubMenuControl", GetType(SubMenuBarControl), GetType(SubMenuBarControlViewInfo), New SkinBarSubMenuPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("PopupMenuControl", GetType(PopupMenuBarControl), GetType(PopupMenuBarControlViewInfo), New SkinBarSubMenuPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("PopupContainerControl", GetType(PopupContainerBarControl), GetType(PopupContainerControlViewInfo), New SkinPopupControlContainerBarPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("QuickCustomizationBarControl", GetType(QuickCustomizationBarControl), GetType(QuickCustomizationBarControlViewInfo), New SkinBarPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("FloatingBarControl", GetType(FloatingBarControl), GetType(SkinFloatingBarControlViewInfo), New SkinFloatingBarPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("TitleBarControl", GetType(DevExpress.XtraBars.Objects.TitleBarControl), GetType(DevExpress.XtraBars.Objects.TitleBarControlViewInfo), New SkinTitleBarPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("ControlForm", GetType(DevExpress.XtraBars.Forms.ControlForm), GetType(ControlFormViewInfo), New SkinControlFormPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("SubMenuControlForm", GetType(DevExpress.XtraBars.Forms.SubMenuControlForm), GetType(ControlFormViewInfo), New SkinControlFormPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("PopupContainerControlForm", GetType(DevExpress.XtraBars.Forms.PopupContainerForm), GetType(PopupContainerFormViewInfo), New SkinControlFormPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("FloatingBarControlForm", GetType(DevExpress.XtraBars.Forms.FloatingBarControlForm), GetType(SkinFloatingBarControlFormViewInfo), New SkinFloatingBarControlFormPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("GalleryDropDownBarControl", GetType(GalleryDropDownBarControl), GetType(GalleryDropDownControlViewInfo), New GalleyDropDownBarControlPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("AppMenuBarControl", GetType(AppMenuBarControl), GetType(AppMenuControlViewInfo), New BarSubMenuPainter(Me)))
			BarInfoCollection.Add(New BarControlInfo("AppMenuForm", GetType(DevExpress.XtraBars.Forms.AppMenuForm), GetType(AppMenuFormViewInfo), New SkinAppMenuFormPainter(Me)))
		End Sub
		Protected Overrides Sub RegisterCoreItems()
			MyBase.RegisterCoreItems()
		End Sub
	End Class
End Namespace
