Imports System.ComponentModel.DataAnnotations
Public Class InsuranceViewModel
    <Required>
    <Display(Name:="InsuranceCompanyID")>
    Public Property InsuranceCompanyID As String
    <Required>
    <Display(Name:="Company name")>
    Public Property CompanyName As String

    <Required>
    <Display(Name:="Contact Person")>
    Public Property ContactPersonName As String

    <Required>
    <Display(Name:="AddressLine1")>
    Public Property AddressLine1 As String

    <Display(Name:="AddressLine2")>
    Public Property AddressLine2 As String

    <Required>
    <Display(Name:="City")>
    Public Property City As String

    <Required>
    <Display(Name:="State")>
    Public Property State As String

    <Required>
    <Display(Name:="Pin Code")>
    Public Property PinCode As String

    <Display(Name:="Business Phone")>
    Public Property BusinessPhone As String

    <Required>
    <Display(Name:="Fax Number")>
    Public Property FaxNumber As String

    <Display(Name:="Contact Email")>
    Public Property EmailAddress As String
End Class
