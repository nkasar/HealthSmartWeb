Imports System.ComponentModel.DataAnnotations
Public Class PatientDiagnosisViewModel
    <Required>
    <Display(Name:="PatientID")>
    Public Property PatientID As String

    <Required>
    <Display(Name:="Patient Name")>
    Public Property PatientName As String

    <Display(Name:="Diagnosis Category")>
    Public Property DiagCategoryCode As String

    <Required>
    <Display(Name:="Diagnosis")>
    Public Property DiagCode As String

    <Required>
    <Display(Name:="Diagnosis Date")>
    Public Property DiagDate As DateTime

    <Required>
    <Display(Name:="Notes")>
    Public Property Notes As String

    <Display(Name:="Physician")>
    Public Property PhysicianID As String

    Public Property DiagnosisList As IEnumerable(Of DiagnosisViewModel)
End Class
