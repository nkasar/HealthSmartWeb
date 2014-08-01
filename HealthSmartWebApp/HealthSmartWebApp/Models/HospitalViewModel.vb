Imports System.ComponentModel.DataAnnotations
Public Class HospitalViewModel
    <Required>
    <Display(Name:="Hospital ID")>
    Public Property HospitalID As String
    <Required>
    <Display(Name:="Hospital name")>
    Public Property HospitalName As String

    <Required>
    <Display(Name:="Speciality")>
    Public Property HospitalSpeciality As String

    <Required>
    <Display(Name:="AddressLine1")>
    Public Property AddressLine1 As String

    <Required>
    <Display(Name:="AddressLine2")>
    Public Property AddressLine2 As String

    <Required>
    <Display(Name:="City")>
    Public Property City As String

    <Required>
    <Display(Name:="State")>
    Public Property State As String

    <Display(Name:="Handcap Access?")>
    Public Property HandicapAccess As Boolean

    Public Property SpecialityList As List(Of HospitalSpeciality)
End Class
