Imports Microsoft.VisualBasic
Imports DevExpress.Web.Mvc
Imports DXWebApplication1.Models
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace DevExpressMvcApplication1.Controllers
	Public Class HomeController
		Inherits Controller
		Private list As New PersonsList()
		Public Function Index() As ActionResult
			Return View(list.GetPersons())
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView(list.GetPersons())
		End Function

		<HttpPost, ValidateInput(False)> _
		Public Function EditingAddNew(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal personInfo As Person) As ActionResult
			If ModelState.IsValid Then
				list.AddPerson(personInfo)
			End If
			Return PartialView("GridViewPartial", list.GetPersons())
		End Function

		<HttpPost, ValidateInput(False)> _
		Public Function EditingUpdate(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal personInfo As Person) As ActionResult
			If ModelState.IsValid Then
				list.UpdatePerson(personInfo)
			End If
			Return PartialView("GridViewPartial", list.GetPersons())
		End Function

		Private Sub UpdateModelLastNameValue(ByVal personInfo As Person)
			If Request.Params("FirstName").Contains("text") Then
				personInfo.LastName = Request.Params("cmb")
			Else
				personInfo.LastName = Request.Params("txt")
			End If
			ModelState.Clear()
			UpdateModel(Of Person)(personInfo)
		End Sub

		Public Function EditingDelete(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal personId As Integer) As ActionResult
			list.DeletePerson(personId)
			Return PartialView("GridViewPartial", list.GetPersons())
		End Function

	End Class
End Namespace
