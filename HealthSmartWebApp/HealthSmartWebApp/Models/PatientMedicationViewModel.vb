Imports System.ComponentModel.DataAnnotations
Public Class PatientMedicationViewModel
    <Required>
    <Display(Name:="PatientID")>
    Public Property PatientID As String

    <Required>
    <Display(Name:="Patient Name")>
    Public Property PatientName As String

    <Required>
    <Display(Name:="Medication")>
    Public Property MedicationID As Int32

    <Required>
    <Display(Name:="Medication Date")>
    Public Property MedicationDate As DateTime

    <Required>
    <Display(Name:="Number of times in a day")>
    Public Property NoOfTimesDay As Int32

    <Required>
    <Display(Name:="Number of Days")>
    Public Property NoOfDays As Int32

    <Display(Name:="Dosage")>
    Public Property Dosage As String

    <Display(Name:="Special Note")>
    Public Property Notes As String

    <Display(Name:="Physician")>
    Public Property PhysicianID As String

    Public Property MedicationList As IEnumerable(Of MedicationViewModel)
End Class
