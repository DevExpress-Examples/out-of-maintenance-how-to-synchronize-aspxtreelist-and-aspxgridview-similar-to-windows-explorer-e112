Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView
Imports System.IO

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private rootPath As String = ""

	Protected Overrides Sub OnInit(ByVal e As EventArgs)
		rootPath = Me.MapPath("")
		MyBase.OnInit(e)
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxTreeList1.DataBind()
		ASPxGridView1.DataBind()
	End Sub
	Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		Dim grid As ASPxGridView = CType(sender, ASPxGridView)
		If ASPxTreeList1.FocusedNode Is Nothing Then
			grid.DataSource = Nothing
		Else
			Dim path As String = ASPxTreeList1.FocusedNode.Key
			Dim di As New DirectoryInfo(path)
			grid.DataSource = di.GetFiles()
		End If
	End Sub
	Protected Sub ASPxTreeList1_VirtualModeCreateChildren(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListVirtualModeCreateChildrenEventArgs)
		Dim path As String
		If (e.NodeObject Is Nothing) Then
			path = rootPath
		Else
			path = e.NodeObject.ToString()
		End If
		e.Children = Directory.GetDirectories(path)
	End Sub
	Protected Sub ASPxTreeList1_VirtualModeNodeCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListVirtualNodeEventArgs)
	End Sub
	Protected Sub ASPxTreeList1_VirtualModeNodeCreating(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListVirtualModeNodeCreatingEventArgs)
		Dim path As String
		If (e.NodeObject Is Nothing) Then
			path = rootPath
		Else
			path = e.NodeObject.ToString()
		End If
		e.NodeKeyValue = path
		e.SetNodeValue("Name", System.IO.Path.GetFileName(path))
	End Sub
End Class
