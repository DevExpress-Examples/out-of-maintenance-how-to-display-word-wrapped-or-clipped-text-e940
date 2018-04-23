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

Namespace WordWrapClippingAndEllipsis
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.DataSource = GetData()
			ASPxGridView1.DataBind()
		End Sub

		Private Function GetData() As DataTable
			Const text1 As String = "The ASPxGridView is a data bound control that provides a two-dimensional representation of data from a data source in grid format."
			Const text2 As String = "The ASPxGridView's appearance can be customized by setting the style properties for different visual elements." & Constants.vbCrLf & Constants.vbCrLf & "Various visual elements display images."

			Dim table As New DataTable()
			table.Columns.Add("WordWrap")
			table.Columns.Add("Clipped")
			table.Columns.Add("Ellipsis")
			table.Rows.Add(text1, text1, text1)
			table.Rows.Add(text2, text2, text2)
			Return table
		End Function

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace
