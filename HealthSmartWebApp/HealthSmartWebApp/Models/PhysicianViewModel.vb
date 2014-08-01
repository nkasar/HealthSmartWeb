Imports System.ComponentModel.DataAnnotations
Public Class PhysicianViewModel
    <Required>
    <Display(Name:="Physician ID")>
    Public Property PhysicianID As Integer
    <Required>
    <Display(Name:="Last name")>
    Public Property PhysicianLastName As String
    <Required>
    <Display(Name:="First name")>
    Public Property PhysicianFirstName As String
    <Display(Name:="Middle Initial")>
    Public Property MiddleInitial As String
    <Display(Name:="AddressLine1")>
    Public Property AddressLine1 As String
    <Display(Name:="AddressLine2")>
    Public Property AddressLine2 As String
    <Display(Name:="City")>
    Public Property City As String
    <Display(Name:="State")>
    Public Property State As String
    <Display(Name:="Pin Code")>
    Public Property PinCode As String
    <Display(Name:="Home Phone")>
    Public Property HomePhone As String
    <Display(Name:="Business Phone")>
    Public Property BusinessPhone As String
    <Display(Name:="Email Address")>
    Public Property EmailAddress As String
    <Display(Name:="Fax Number")>
    Public Property FaxNumber As String

End Class
