'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class PatientDisability
    Public Property PatDisabilityID As Integer
    Public Property PatientID As Integer
    Public Property DisabilityCd As String
    Public Property Active As Nullable(Of Boolean)
    Public Property DateEntered As Nullable(Of Date)
    Public Property EnteredByUserID As Nullable(Of Integer)
    Public Property DateModified As Nullable(Of Date)
    Public Property ModifiedByUserID As Nullable(Of Integer)

    Public Overridable Property Disability As Disability
    Public Overridable Property Patient As Patient

End Class
