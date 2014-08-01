Imports System.ComponentModel.DataAnnotations
Public Class ImmunizationViewModel
    <Required>
    <Display(Name:="Immunization Code")>
    Public Property ImmunizationCode As String
    <Required>
    <Display(Name:="Immunization Description")>
    Public Property ImmunizationDesc As String
End Class
