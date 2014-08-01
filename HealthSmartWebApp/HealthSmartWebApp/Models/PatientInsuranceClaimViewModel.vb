Imports System.ComponentModel.DataAnnotations
Public Class PatientInsuranceClaimViewModel
    <Required>
    <Display(Name:="PatientID")>
    Public Property PatientID As String

    <Display(Name:="Patient Name")>
    Public Property PatientName As String

    <Display(Name:="Insurance Company")>
    Public Property InsuranceCompanyName As String

    <Required>
    <Display(Name:="Insurance Number")>
    Public Property InsuranceNumber As String

    <Required>
    <Display(Name:="Policy Number")>
    Public Property PolicyNumber As String

    <Required>
    <Display(Name:="Diagnosis Code")>
    Public Property DiagnosisCode As String

    <Display(Name:="Diagnosis Date")>
    Public Property DiagnosisDate As DateTime

    <Required>
    <Display(Name:="Charge")>
    Public Property Charge As Decimal
End Class
