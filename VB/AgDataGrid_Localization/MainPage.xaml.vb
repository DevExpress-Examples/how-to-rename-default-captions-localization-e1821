Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.AgDataGrid.Localization

Namespace AgDataGrid_Localization
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			AgDataGridLocalizer.Active = New MyCustomLocalizer()
			grid.DataSource = ProductList.GetData()
		End Sub
	End Class

	Public Class MyCustomLocalizer
		Inherits AgDataGridLocalizer
		' Replaces the default string displayed within the empty Column Chooser.
		Public Overrides Function GetLocalizedString(ByVal id As AgDataGridStringId) As String
			If id = AgDataGridStringId.ColumnChooserEmptyText Then
				Return "To hide a column, drop its header here"
			End If
			Return MyBase.GetLocalizedString(id)
		End Function
	End Class
End Namespace
