Imports System.ComponentModel.DataAnnotations
Public Class PatientInsuranceViewModel
    <Required>
    <Display(Name:="PatientID")>
    Public Property PatientID As String

    <Required>
    <Display(Name:="Patient Name")>
    Public Property PatientName As String

    <Display(Name:="Insurance Company")>
    Public Property InsuranceCompanyID As String

    <Required>
    <Display(Name:="Insurance Number")>
    Public Property InsuranceNumber As String

    <Required>
    <Display(Name:="Policy Number")>
    Public Property PolicyNumber As String

    <Required>
    <Display(Name:="Insurance Start Date")>
    Public Property FromDate As String

    <Required>
    <Display(Name:="Coverage Amount")>
    Public Property CoverageAmount As Decimal

    Public Property InsuranceList As IEnumerable(Of InsuranceViewModel
                                                 )
End Class
