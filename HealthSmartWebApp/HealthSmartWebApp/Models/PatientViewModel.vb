Imports System.ComponentModel.DataAnnotations
Public Class PatientViewModel

    <Display(Name:="PatientID")>
    Public Property PatientID As String

    <Required>
    <Display(Name:="Last name")>
    Public Property LastName As String

    <Required>
    <Display(Name:="First Name")>
    Public Property FirstName As String

    <Required>
    <Display(Name:="Gender")>
    Public Property Gender As String

    <Required>
    <Display(Name:="Date of Birth")>
    Public Property DOB As Date
End Class
