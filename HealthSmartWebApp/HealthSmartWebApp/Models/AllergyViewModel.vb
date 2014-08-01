Imports System.ComponentModel.DataAnnotations
Public Class AllergyViewModel
    <Required>
    <Display(Name:="Allergy Code")>
    Public Property AllergyCode As String
    <Required>
    <Display(Name:="Allergy Description")>
    Public Property AllergyDesc As String
End Class
