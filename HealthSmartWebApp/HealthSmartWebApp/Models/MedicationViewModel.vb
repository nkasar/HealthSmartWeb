Imports System.ComponentModel.DataAnnotations
Public Class MedicationViewModel
    <Required>
    <Display(Name:="Medication ID")>
    Public Property MedicationID As Int32
    <Required>
    <Display(Name:="Medication Description")>
    Public Property MedicationDesc As String
End Class
